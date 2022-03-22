using System;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Security.Principal;
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
        private void ProcessManagement_Load(object sender, EventArgs e) {
            RefreshProcessList(GetProcessGridDataTable());
            RefreshSharedFilesList(GetSharedFilesGridDataTable());
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
            dataTable.Columns["ID"].DataType = Type.GetType("System.Int32");
            dataTable.Columns["Locks"].DataType = Type.GetType("System.Int32");
            return dataTable;
        }


        private void RefreshProcessList(DataTable dataTable) {
            Invoke(new MethodInvoker(delegate {
                dataTable.DefaultView.Sort = "ID";
                dgvProcess.DataSource = dataTable;
                //dgvProcess.Sort(dgvProcess.Columns[0],System.ComponentModel.ListSortDirection.Ascending);
                dgvProcess.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgvProcess.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgvProcess.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }));
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

            await Task.Run(() => {
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
        }
        private async Task KillProcess(int processId) {
            await Task.Run(() => {
                try {
                    if (!OperatingSystem.IsWindows()) { throw new Exception("Operating System is not Windows"); }
                    Process process = Process.GetProcessById(processId);
                    process.Kill();
                    Invoke(new Action(() => {
                        dgvProcess.Rows.RemoveAt(dgvProcess.SelectedRows[0].Index);
                    }));
                } catch (Exception ex) {
                    InvokeMessage(new CustomMessage("Error ending process: \n" + ex.Message, "Error", "error"));
                }
            });

        }

        private async void BtnCheckLockedFile_Click(object sender, EventArgs e) {
            if (task == null || task.IsCompleted) {
                task = GetLockedFileProcesses();
                RefreshSharedFilesList(OpenFilesSearch(txtLockedFilePath.Text));
                await task;
                return;
            }
        }
        private void btnLockedFileBrowser_Click(object sender, EventArgs e) {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog(this);
            txtLockedFilePath.Text = openFileDialog.FileName;
        }
        private async void BtnEndSelectedProcess_Click(object sender, EventArgs e) {
            if (dgvProcess.GetCellCount(DataGridViewElementStates.Selected) <= 0) { return; }

            int processId = Int32.Parse(dgvProcess.SelectedRows[0].Cells[0].Value.ToString());
            string processName = dgvProcess.SelectedRows[0].Cells[1].Value.ToString();
            string processOwner = dgvProcess.SelectedRows[0].Cells[2].Value.ToString();

            CustomMessage customMessage = new CustomMessage("You are about to end this process:\nID: " +
                                          processId + "  Name: "+ processName + "  Owner: "+ processOwner + "\nAre you sure?", "Confirmation", "confirmation");
            DialogResult result = CustomDialog.ShowCustomDialog(customMessage, this);
            if (result == DialogResult.Cancel) {
                return;
            }

            if (task == null || task.IsCompleted) {
                task = KillProcess(processId);
                await task;
                return;
            }
        }


        private DataTable OpenFilesSearch(string? filePath) {
            DataTable dataTable = GetSharedFilesGridDataTable();
            CustomMessage customMessage = null;
            Process process = new Process();
            //process.StartInfo.FileName = Environment.SystemDirectory + "\\openfiles.exe";
            process.StartInfo.FileName = Environment.SystemDirectory + "\\cmd.exe";
            process.StartInfo.Arguments = "/C openfiles.exe /query /FO CSV /v";
            if (filePath != null) {
                process.StartInfo.Arguments = "/C openfiles.exe /query /FO CSV /v | findstr /i /c:\"" + filePath + "\"";
            }
            Clipboard.SetText(process.StartInfo.Arguments);
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardError = true;
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
                    return dataTable;
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
            } catch (Exception ex) {
                customMessage = new CustomMessage("Error listing open shared files, action cancelled.\n" + ex.Message, "Error", "error");
                CustomDialog.ShowCustomDialog(customMessage, this);
            }
            return dataTable;
        }

        private void DisconnectOpenFile(Int64 id) {
            if (id == null) { return; }
            CustomMessage customMessage = null;
            if (!IsAdministrator()) {
                customMessage = new CustomMessage("Aplication not running as Administrator." +
                                "\nTo use this action run this aplication as Administrator.", "Information", "information");
                CustomDialog.ShowCustomDialog(customMessage, this);
                return;
            }
            Process process = new Process();
            process.StartInfo.FileName = Environment.SystemDirectory + "\\cmd.exe";

            process.StartInfo.Arguments = "/C openfiles.exe /disconnect /id "+id;
            
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardError = true;
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
                customMessage = new CustomMessage("Selected shared file disconnected.\n"+output, "Success", "success");
                CustomDialog.ShowCustomDialog(customMessage, this);
            } catch (Exception ex) {
                customMessage = new CustomMessage("Error disconnecting shared file, action cancelled.\n" + ex.Message, "Error", "error");
                CustomDialog.ShowCustomDialog(customMessage, this);
            }
        }

        private void BtnListAllSharedFiles_Click(object sender, EventArgs e) {
            RefreshSharedFilesList(OpenFilesSearch(null));
        }
        private void BtnDisconnectSelectedFile_Click(object sender, EventArgs e) {
            if (dgvSharedFiles.GetCellCount(DataGridViewElementStates.Selected) <= 0) { return; }

            int sharedId = Int32.Parse(dgvSharedFiles.SelectedRows[0].Cells[1].Value.ToString());
            string filePath = dgvSharedFiles.SelectedRows[0].Cells[6].Value.ToString();
            CustomMessage customMessage = new CustomMessage("You are about to diconnect this file:\nID: " +
                                          sharedId + "  Name: " + filePath +"\nAre you sure?", "Confirmation", "confirmation");
            DialogResult result = CustomDialog.ShowCustomDialog(customMessage, this);
            if (result == DialogResult.Cancel) {
                return;
            }
            DisconnectOpenFile(sharedId);
            //dgvSharedFiles.Rows.RemoveAt(dgvProcess.SelectedRows[0].Index);

        }
    }
}
