using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
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
        private Task taskListProcesses;
        private CancellationTokenSource ctsListProcesses;
        private Task taskListOpenSharedFiles;
        private CancellationTokenSource ctsListOpenSharedFiles;
        private Task taskCheckLockedFile;
        private CancellationTokenSource ctsCheckLockedFile;

        public FileLocks() {
            InitializeComponent();
        }
        private void FileLocks_Load(object sender, EventArgs e) {
            RefreshProcessList(GetProcessGridDataTable());
            RefreshSharedFilesList(GetSharedFilesGridDataTable());
            if (!IsAdministrator()) {
                btnDisconnectSelectedFile.Enabled = false;
                btnListSharedFiles.Enabled = false;
                btnDisconnectSelectedFile.BackColor = System.Drawing.Color.DarkGray;
                btnListSharedFiles.BackColor = System.Drawing.Color.DarkGray;
            }
        }

        private DataTable GetProcessGridDataTable() {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ID");
            dataTable.Columns.Add("User");
            dataTable.Columns.Add("User Status");
            dataTable.Columns.Add("Process Name");
            dataTable.Columns["ID"].DataType = Type.GetType("System.Int32");
            return dataTable;
        }
        private DataTable GetSharedFilesGridDataTable() {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ID");
            dataTable.Columns.Add("Host");
            dataTable.Columns.Add("User");
            dataTable.Columns.Add("User Status");
            dataTable.Columns.Add("Access Type");
            dataTable.Columns.Add("File Path");
            dataTable.Columns["ID"].DataType = Type.GetType("System.Int64");
            return dataTable;
        }

        private void RefreshProcessList(DataTable dataTable) {
            dataTable.DefaultView.Sort = "ID";
            dgvProcess.DataSource = dataTable;
            //dgvProcess.Sort(dgvProcess.Columns[0],System.ComponentModel.ListSortDirection.Ascending);
            dgvProcess.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvProcess.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvProcess.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvProcess.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        private void RefreshSharedFilesList(DataTable dataTable) {
            dgvSharedFiles.DataSource = dataTable;
            dgvSharedFiles.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvSharedFiles.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvSharedFiles.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvSharedFiles.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvSharedFiles.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvSharedFiles.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        private void DisconnectOpenFile(Int64? id, int selectedRow) {
            if (id == null) { return; }
            Process process = new Process();
            process.StartInfo.FileName = Environment.SystemDirectory + "\\cmd.exe";
            process.StartInfo.Arguments = "/C openfiles.exe /disconnect /id " + id;
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
                dgvSharedFiles.Rows.RemoveAt(selectedRow);
                InvokeMessage(new CustomMessage("Selected shared file disconnected.\n" + output, "Success", "success"));
            } catch (Exception ex) {
                InvokeMessage(new CustomMessage("Error disconnecting shared file, action cancelled.\n" + ex.Message, "Error", "error"));
            }
        }
        private void InvokeMessage(CustomMessage customMessage) {
            Invoke(new Action(() => {
                CustomDialog.ShowCustomDialog(customMessage, this);
            }));
        }

        private async Task CheckLockedFile(string filePath,CancellationTokenSource cancellationTokenSource) {
            lblCheckLockedFile.Visible = true;
            btnCheckLockedFile.Text = "Stop Checking Locked File";
            Task taskSharedFiles = null;

            if (IsAdministrator() && !cancellationTokenSource.IsCancellationRequested) {
                taskSharedFiles = ListOpenSharedFiles(filePath, cancellationTokenSource); 
            
            }
            await Task.Run(() => {
                Thread.Sleep(1000);

                RM_PROCESS_INFO[] rm = null;
                Process process = null;
                DataTable dataTable = GetProcessGridDataTable();
                List<User> listUsersStatus = NativeMethods.ListUsersWithStatus();
                User user;
                string status = String.Empty;
                string owner = "";

                try {
                    rm = FindLockedFileProcesses(filePath);
                    rm.OrderBy(rm => rm.Process.dwProcessId);

                    for (int i = 0; i < rm.Count(); i++) {
                        status = "Unknown";
                        process = Process.GetProcessById(rm[i].Process.dwProcessId);
                        owner = GetProcessUser(process);

                        if (owner == null || owner.Equals("")) { owner = "Unknown"; }

                        if (!owner.Equals("Unknown")) {
                            user = listUsersStatus.FirstOrDefault(user => string.Equals(user.Name, owner, StringComparison.InvariantCultureIgnoreCase));
                            if (user != null) { status = user.Status; }
                        }

                        dataTable.Rows.Add(process.Id, owner, status, process.ProcessName);
                        cancellationTokenSource.Token.ThrowIfCancellationRequested();
                    }
                    Invoke(new MethodInvoker(delegate {
                        RefreshProcessList(dataTable);
                    }));

                } catch (OperationCanceledException) {
                } catch (Exception ex) {
                    InvokeMessage(new CustomMessage("Error getting locked file processes :\n" + ex.Message, "Error", "error"));
                }

            }, cancellationTokenSource.Token);
            if (taskSharedFiles != null) { await taskSharedFiles; }
      
            btnCheckLockedFile.Text = "Check Locked File";
            lblCheckLockedFile.Visible = false;
            cancellationTokenSource.Dispose();
        }
        private async Task ListProcesses(CancellationTokenSource cancellationTokenSource) {
            lblListProcesses.Visible = true;
            btnListProcesses.Text = "Stop Listing Processes";
            bool showUnknownUsers = chkShowUnknownUsers.Checked;

            await Task.Run(() => {
                Thread.Sleep(1000);

                DataTable dataTable = GetProcessGridDataTable();
                List<User> listUsersStatus = NativeMethods.ListUsersWithStatus();
                User user;
                string status = String.Empty;
                string owner = "Unknown";

                try {
                    Process[] processes = Process.GetProcesses(".");

                    foreach (Process process in processes) {
                        status = "Unknown";
                        owner = GetProcessUser(process);

                        if (owner.Equals("")) { owner = "Unknown"; }

                        if (showUnknownUsers == false && owner.Equals("Unknown")) { continue; }

                        if (!owner.Equals("Unknown")) {
                            user = listUsersStatus.FirstOrDefault(user => string.Equals(user.Name, owner, StringComparison.InvariantCultureIgnoreCase));
                            if (user != null) { status = user.Status; }
                        }

                        dataTable.Rows.Add(process.Id, owner, status, process.ProcessName);
                        cancellationTokenSource.Token.ThrowIfCancellationRequested();
                    }
                    Invoke(new MethodInvoker(delegate {
                        RefreshProcessList(dataTable);
                    }));

                } catch (OperationCanceledException) {
                } catch (Exception ex) {
                    InvokeMessage(new CustomMessage("Error listing processes: \n" + ex.Message, "Error", "error"));
                }
            }, cancellationTokenSource.Token);
            btnListProcesses.Text = "List Processes";
            lblListProcesses.Visible = false;
            cancellationTokenSource.Dispose();
        }
        private async Task ListOpenSharedFiles(string? filePath, CancellationTokenSource cancellationTokenSource) {
            DataTable dataTable = GetSharedFilesGridDataTable();
            Process process = new Process();
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardError = true;
            process.StartInfo.FileName = Environment.SystemDirectory + "\\cmd.exe";

            if (filePath != null) {
                process.StartInfo.Arguments = "/C openfiles.exe /query /FO CSV /v | findstr /i /c:\"" + filePath + "\"";
            } else {
                process.StartInfo.Arguments = "/C openfiles.exe /query /FO CSV /v";
                lblListSharedFiles.Visible = true;
                btnListSharedFiles.Text = "Stop Listing Shared Files";
            }

            await Task.Run(() => {
                Thread.Sleep(1000);

                try {
                    process.Start();
                    string output = String.Empty;
                    string errorOutput = String.Empty;
                    string status = String.Empty;
                    string[] outputLines;
                    string[] lineItems;
                    List <User> listUsersStatus = NativeMethods.ListUsersWithStatus();
                    User user;
                    output = process.StandardOutput.ReadToEnd();
                    errorOutput = process.StandardError.ReadToEnd();
                    cancellationTokenSource.Token.ThrowIfCancellationRequested();

                    process.WaitForExit();
                    if (output.Contains("\"")) {
                        output = output.Substring(output.IndexOf("\"")).Replace("\"", "");
                    } else {
                        if (errorOutput.Length > 0) {
                            throw new Exception(errorOutput);
                        }
                    }

                    outputLines = output.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

                    foreach (string line in outputLines) {
                        if (line.Equals(outputLines[0]) && filePath == null) { continue; }
                        status = "Unknown";
                        lineItems = line.Split(",");
                        if (lineItems.Length < 6) { continue; }
                        SharedItem sharedItem = new SharedItem(lineItems[0],
                                                                Convert.ToInt64(lineItems[1]),
                                                                lineItems[2],
                                                                lineItems[3],
                                                                Convert.ToInt32(lineItems[4]),
                                                                lineItems[5],
                                                                lineItems[6]);

                        user = listUsersStatus.FirstOrDefault(user => string.Equals(user.Name, sharedItem.AccessedBy, StringComparison.InvariantCultureIgnoreCase));
                        
                        if (user != null) { status = user.Status; }

                        dataTable.Rows.Add(sharedItem.Id,sharedItem.Host,sharedItem.AccessedBy, status, sharedItem.AccessType,sharedItem.ItemPath) ;
                        cancellationTokenSource.Token.ThrowIfCancellationRequested();
                    }

                    Invoke(new MethodInvoker(delegate {
                        RefreshSharedFilesList(dataTable);
                    }));

                } catch (OperationCanceledException) {
                } catch (Exception ex) {
                    InvokeMessage(new CustomMessage("Error listing open shared files, action cancelled.\n" + ex.Message, "Error", "error"));
                }
            }, cancellationTokenSource.Token);
            lblListSharedFiles.Visible = false;
            btnListSharedFiles.Text = "List Shared Files";
            cancellationTokenSource.Dispose();
        }

        private void BtnLockedFileBrowser_Click(object sender, EventArgs e) {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog(this);
            txtLockedFilePath.Text = openFileDialog.FileName;
        }
        private void BtnCheckLockedFile_Click(object sender, EventArgs e) {
            if ((taskListOpenSharedFiles != null && !taskListOpenSharedFiles.IsCompleted) ||
                (taskListProcesses != null && !taskListProcesses.IsCompleted)) {
                CustomDialog.ShowCustomDialog(new CustomMessage("Wait or stop running actions!", "Information", "information"), this);
                return;
            }
            if (taskCheckLockedFile == null || taskCheckLockedFile.IsCompleted) {
                string lockedFile = txtLockedFilePath.Text;
                if (lockedFile == null || lockedFile.Length == 0) {
                    CustomDialog.ShowCustomDialog(new CustomMessage("Select a file", "Error", "error"), this);
                    return;
                }
                ctsCheckLockedFile = new CancellationTokenSource();
                taskCheckLockedFile = CheckLockedFile(lockedFile, ctsCheckLockedFile);
            } else {
                ctsCheckLockedFile.Cancel();
            }
        }
        private void BtnListProcesses_Click(object sender, EventArgs e) {
            if (taskCheckLockedFile != null && !taskCheckLockedFile.IsCompleted) {
                CustomDialog.ShowCustomDialog(new CustomMessage("Wait or stop locked file check!", "Information", "information"), this);
                return;
            }
            if (taskListProcesses == null || taskListProcesses.IsCompleted) {
                ctsListProcesses = new CancellationTokenSource();
                taskListProcesses = ListProcesses(ctsListProcesses);
            } else {
                ctsListProcesses.Cancel();
            }
        }
        private void BtnEndSelectedProcess_Click(object sender, EventArgs e) {
            if (dgvProcess.GetCellCount(DataGridViewElementStates.Selected) <= 0) { return; }

            int processId = Int32.Parse(dgvProcess.SelectedRows[0].Cells[0].Value.ToString());
            int selectedRow = dgvProcess.SelectedRows[0].Index;
            string processName = dgvProcess.SelectedRows[0].Cells[1].Value.ToString();
            string processOwner = dgvProcess.SelectedRows[0].Cells[2].Value.ToString();

            CustomMessage customMessage = new CustomMessage("You are about to end this process:\nID: " +
                            processId + "  Name: " + processName + "  Owner: " + processOwner + "\nAre you sure?", "Confirmation", "confirmation");
            DialogResult result = CustomDialog.ShowCustomDialog(customMessage, this);
            if (result == DialogResult.Cancel) {
                return;
            }

            try {
                if (!OperatingSystem.IsWindows()) { throw new Exception("Operating System is not Windows"); }
                Process process = Process.GetProcessById(processId);
                process.Kill();
                dgvProcess.Rows.RemoveAt(selectedRow);
            } catch (Exception ex) {
                InvokeMessage(new CustomMessage("Error ending process: \n" + ex.Message, "Error", "error"));
            }
            return;

        }
        private void BtnListSharedFiles_Click(object sender, EventArgs e) {
            if (taskCheckLockedFile != null && !taskCheckLockedFile.IsCompleted) {
                CustomDialog.ShowCustomDialog(new CustomMessage("Wait or stop locked file check!", "Information", "information"), this);
                return;
            }
            if (taskListOpenSharedFiles == null || taskListOpenSharedFiles.IsCompleted) {
                ctsListOpenSharedFiles = new CancellationTokenSource();
                taskListOpenSharedFiles = ListOpenSharedFiles(null, ctsListOpenSharedFiles);
            } else {
                ctsListOpenSharedFiles.Cancel();
            }
        }
        private void BtnDisconnectSelectedFile_Click(object sender, EventArgs e) {
            if (dgvSharedFiles.GetCellCount(DataGridViewElementStates.Selected) <= 0) { return; }

            int sharedId = Int32.Parse(dgvSharedFiles.SelectedRows[0].Cells[1].Value.ToString());
            int selectedRow = dgvSharedFiles.SelectedRows[0].Index;
            string filePath = dgvSharedFiles.SelectedRows[0].Cells[6].Value.ToString();

            CustomMessage customMessage = new CustomMessage("You are about to diconnect this file:\nID: " +
                                            sharedId + "  Name: " + filePath + "\nAre you sure?", "Confirmation", "confirmation");
            DialogResult result = CustomDialog.ShowCustomDialog(customMessage, this);
            if (result == DialogResult.Cancel) {
                return;
            }
            DisconnectOpenFile(sharedId,selectedRow);
        }
    }
}
