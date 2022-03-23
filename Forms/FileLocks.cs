using System;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Security.Principal;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilities.Classes;
using static Utilities.Classes.NativeMembers;
using static Utilities.Classes.NativeMethods;

namespace Utilities.Forms
{
    public partial class FileLocks : Form
    {
        public FileLocks() {
            InitializeComponent();
        }
        private void FileLocks_Load(object sender, EventArgs e) {
            RefreshProcessList(GetProcessGridDataTable());
            RefreshSharedFilesList(GetSharedFilesGridDataTable());
            if (!IsAdministrator()) {
                btnDisconnectSelectedFile.Enabled = false;
                btnListAllSharedFiles.Enabled = false;
                btnDisconnectSelectedFile.BackColor = System.Drawing.Color.DarkGray;
                btnListAllSharedFiles.BackColor = System.Drawing.Color.DarkGray;
                CustomMessage customMessage = new CustomMessage("Aplication not running as Administrator. Some restrictions are activated:" +
                                "\nNot all processes may appear,\nButtons related to Shared Files are disabled.", "Information", "information");
                CustomDialog.ShowCustomDialog(customMessage, this);
            }
        }

        private Task task;

        private DataTable GetProcessGridDataTable() {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ID");
            dataTable.Columns.Add("Name");
            dataTable.Columns.Add("User");
            dataTable.Columns["ID"].DataType = Type.GetType("System.Int32");
            return dataTable;
        }
        private DataTable GetSharedFilesGridDataTable() {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Host");
            dataTable.Columns.Add("ID");
            dataTable.Columns.Add("Accessed By");
            dataTable.Columns.Add("Type");
            dataTable.Columns.Add("Locks");
            dataTable.Columns.Add("Access Type");
            dataTable.Columns.Add("File Path");
            dataTable.Columns["ID"].DataType = Type.GetType("System.Int64");
            dataTable.Columns["Locks"].DataType = Type.GetType("System.Int32");
            return dataTable;
        }

        private void RefreshProcessList(DataTable dataTable) {
                dataTable.DefaultView.Sort = "ID";
                dgvProcess.DataSource = dataTable;
                //dgvProcess.Sort(dgvProcess.Columns[0],System.ComponentModel.ListSortDirection.Ascending);
                dgvProcess.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgvProcess.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgvProcess.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        private void RefreshSharedFilesList(DataTable dataTable) {
            dgvSharedFiles.DataSource = dataTable;
            dgvSharedFiles.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvSharedFiles.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvSharedFiles.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvSharedFiles.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvSharedFiles.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvSharedFiles.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvSharedFiles.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void InvokeMessage(CustomMessage customMessage) {
            Invoke(new Action(() => {
                CustomDialog.ShowCustomDialog(customMessage, this);
            }));
        }
        private async Task GetLockedFileProcesses() {
            string lockedFile = txtLockedFilePath.Text;
            if (lockedFile == null || lockedFile.Length == 0) {
                CustomDialog.ShowCustomDialog(new CustomMessage("Select a file", "Error", "error"), this);
                return;
            }
            lblListProcesses.Visible = true;
            await Task.Run(() => {
                Thread.Sleep(1000);
                RM_PROCESS_INFO[] rm = null;
                Process process = null;
                DataTable dataTable = GetProcessGridDataTable();
                string owner = "";
                try {
                    rm = FindLockedFileProcesses(lockedFile);
                    rm.OrderBy(rm => rm.Process.dwProcessId);
                    for (int i = 0; i < rm.Count(); i++) {
                        process = Process.GetProcessById(rm[i].Process.dwProcessId);
                        owner = GetProcessUser(process);
                        if (owner == null || owner.Equals("")) {
                            owner = "Unknown";
                        }
                        dataTable.Rows.Add(process.Id, process.ProcessName, owner);
                    }
                    RefreshProcessList(dataTable);
                } catch (Exception ex) {
                    InvokeMessage(new CustomMessage("Error getting processes :\n" + ex.Message, "Error", "error"));
                }

            });
            lblListProcesses.Visible = false;
        }

        private async Task ListAllProcesses() {
            lblListProcesses.Visible = true;
            bool showUnknownUsers = chkShowUnknownUsers.Checked;
            await Task.Run(() => {
                Thread.Sleep(1000);
                DataTable dataTable = GetProcessGridDataTable();
                string owner = "Unknown";
                try {
                    if (!OperatingSystem.IsWindows()) { throw new Exception("Operating System is not Windows"); }

                    Process[] processes = Process.GetProcesses(".");
                    foreach (Process process in processes) {
                        owner = GetProcessUser(process);
                        if (owner.Equals("")) {
                            owner = "Unknown";
                        }
                        if (showUnknownUsers == false && owner.Equals("Unknown")) {
                            continue;
                        }
                        dataTable.Rows.Add(process.Id, process.ProcessName, owner);
                    }
                    Invoke(new MethodInvoker(delegate {
                        RefreshProcessList(dataTable);
                    }));
                } catch (Exception ex) {
                    InvokeMessage(new CustomMessage("Error listing processes: \n" + ex.Message, "Error", "error"));
                }
            });
            lblListProcesses.Visible = false;
        }
        private async Task KillProcess(int processId,int selectedRow) {
            await Task.Run(() => {
                try {
                    if (!OperatingSystem.IsWindows()) { throw new Exception("Operating System is not Windows"); }
                    Process process = Process.GetProcessById(processId);
                    process.Kill();
                    Invoke(new Action(() => {
                        dgvProcess.Rows.RemoveAt(selectedRow);
                    }));
                } catch (Exception ex) {
                    InvokeMessage(new CustomMessage("Error ending process: \n" + ex.Message, "Error", "error"));
                }
            });

        }

        private async Task OpenFilesSearch(string? filePath) {
            DataTable dataTable = GetSharedFilesGridDataTable();
            lblListSharedFiles.Visible = true;
            Process process = new Process();
            process.StartInfo.FileName = Environment.SystemDirectory + "\\cmd.exe";
            process.StartInfo.Arguments = "/C openfiles.exe /query /FO CSV /v";
            if (filePath != null) {
                process.StartInfo.Arguments = "/C openfiles.exe /query /FO CSV /v | findstr /i /c:\"" + filePath + "\"";
            }
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardError = true;

            await Task.Run(() => {
                Thread.Sleep(1000);
                try {
                    process.Start();
                    string output = String.Empty;
                    string errorOutput = String.Empty;
                    output = process.StandardOutput.ReadToEnd();
                    errorOutput = process.StandardError.ReadToEnd();
                    process.WaitForExit();
                    if (output.Contains("\"")) {
                        output = output.Substring(output.IndexOf("\"")).Replace("\"", "");
                    } else {
                        if (errorOutput.Length > 0) {
                            throw new Exception(errorOutput);
                        }
                    }
                    string[] outputLines;

                    outputLines = output.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
                    foreach (string line in outputLines) {
                        if (line.Equals(outputLines[0]) && filePath == null) { continue; }
                        string[] lineItems = line.Split(",");
                        if (lineItems.Length < 6) { continue; }
                        dataTable.Rows.Add(lineItems[0], Convert.ToInt64(lineItems[1]), lineItems[2],
                                           lineItems[3], Convert.ToInt64(lineItems[4]), lineItems[5],
                                           lineItems[6]);
                    }
                    Invoke(new MethodInvoker(delegate {
                        RefreshSharedFilesList(dataTable);
                    }));
                } catch (Exception ex) {
                    InvokeMessage(new CustomMessage("Error listing open shared files, action cancelled.\n" + ex.Message, "Error", "error"));
                }
            });
            lblListSharedFiles.Visible = false;
        }
        private async Task DisconnectOpenFile(Int64 id, int selectedRow) {
            if (id == null) { return; }
            Process process = new Process();
            process.StartInfo.FileName = Environment.SystemDirectory + "\\cmd.exe";
            process.StartInfo.Arguments = "/C openfiles.exe /disconnect /id " + id;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardError = true;
            await Task.Run(() => {
                Thread.Sleep(1000);
                try {
                    process.Start();
                    string output = String.Empty;
                    string errorOutput = String.Empty;
                    output = process.StandardOutput.ReadToEnd();
                    errorOutput = process.StandardError.ReadToEnd();
                    process.WaitForExit();
                    if (errorOutput.Length > 0) {
                        throw new Exception(errorOutput);
                    }
                    Invoke(new Action(() => {
                        dgvSharedFiles.Rows.RemoveAt(selectedRow);
                    }));
                    InvokeMessage(new CustomMessage("Selected shared file disconnected.\n" + output, "Success", "success"));
                } catch (Exception ex) {
                    InvokeMessage(new CustomMessage("Error disconnecting shared file, action cancelled.\n" + ex.Message, "Error", "error"));
                }
            });
        }

        private void btnLockedFileBrowser_Click(object sender, EventArgs e) {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog(this);
            txtLockedFilePath.Text = openFileDialog.FileName;
        }
        private async void BtnCheckLockedFile_Click(object sender, EventArgs e) {
            if (task == null || task.IsCompleted) {
                lblSearchLocks.Visible = true;
                task = GetLockedFileProcesses();
                await task;
                task = OpenFilesSearch(txtLockedFilePath.Text);
                await task;
                lblSearchLocks.Visible = false;
                return;
            }
        }

        private async void BtnListAllProcesses_Click(object sender, EventArgs e) {
            if (task == null || task.IsCompleted) {
                task = ListAllProcesses();
                await task;
                return;
            }
        }
        private async void BtnEndSelectedProcess_Click(object sender, EventArgs e) {
            if (dgvProcess.GetCellCount(DataGridViewElementStates.Selected) <= 0) { return; }

            int processId = Int32.Parse(dgvProcess.SelectedRows[0].Cells[0].Value.ToString());
            int selectedRow = dgvProcess.SelectedRows[0].Index;
            string processName = dgvProcess.SelectedRows[0].Cells[1].Value.ToString();
            string processOwner = dgvProcess.SelectedRows[0].Cells[2].Value.ToString();

            if (task == null || task.IsCompleted) {
                CustomMessage customMessage = new CustomMessage("You are about to end this process:\nID: " +
                              processId + "  Name: " + processName + "  Owner: " + processOwner + "\nAre you sure?", "Confirmation", "confirmation");
                DialogResult result = CustomDialog.ShowCustomDialog(customMessage, this);
                if (result == DialogResult.Cancel) {
                    return;
                }
                task = KillProcess(processId, selectedRow);
                await task;
                return;
            }
        }

        private async void BtnListAllSharedFiles_Click(object sender, EventArgs e) {
            if (task == null || task.IsCompleted) {
                task = OpenFilesSearch(null);
                await task;
                return;
            }
        }
        private async void BtnDisconnectSelectedFile_Click(object sender, EventArgs e) {
            if (dgvSharedFiles.GetCellCount(DataGridViewElementStates.Selected) <= 0) { return; }

            int sharedId = Int32.Parse(dgvSharedFiles.SelectedRows[0].Cells[1].Value.ToString());
            int selectedRow = dgvSharedFiles.SelectedRows[0].Index;
            string filePath = dgvSharedFiles.SelectedRows[0].Cells[6].Value.ToString();

            if (task == null || task.IsCompleted) {
                CustomMessage customMessage = new CustomMessage("You are about to diconnect this file:\nID: " +
                                              sharedId + "  Name: " + filePath + "\nAre you sure?", "Confirmation", "confirmation");
                DialogResult result = CustomDialog.ShowCustomDialog(customMessage, this);
                if (result == DialogResult.Cancel) {
                    return;
                }
                task = DisconnectOpenFile(sharedId,selectedRow);
                await task;
                return;
            }

        }
    }
}
