using System;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Security.Principal;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilities.Classes;
using static Utilities.Classes.NativeMembers;

namespace Utilities.Forms
{
    public partial class FileLocks : Form
    {
        public FileLocks() {
            InitializeComponent();
        }
        private void ProcessManagement_Load(object sender, EventArgs e) {
            RefreshProcessList(GetProcessGridDataTable());
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
        private static string GetProcessUser(Process process) {

            IntPtr processHandle = IntPtr.Zero;
            try {
                NativeMethods.OpenProcessToken(process.Handle, 8, out processHandle);
                WindowsIdentity wi = new WindowsIdentity(processHandle);
                string user = wi.Name;
                return user.Contains(@"\") ? user.Substring(user.IndexOf(@"\") + 1) : user;
            } catch {
                return "";
            } finally {
                if (processHandle != IntPtr.Zero) {
                    NativeMethods.CloseHandle(processHandle);
                }
            }
        }

        private static RM_PROCESS_INFO[] FindLockedFileProcesses(string path) {
            int handle;
            if (NativeMethods.RmStartSession(out handle, 0, strSessionKey: Guid.NewGuid().ToString()) != RmResult.ERROR_SUCCESS)
                throw new Exception("Could not begin session. Unable to determine file lockers.");

            try {
                string[] resources = { path }; // Just checking on one resource.

                if (NativeMethods.RmRegisterResources(handle, (uint)resources.LongLength, resources, 0, null, 0, null) != RmResult.ERROR_SUCCESS)
                    throw new Exception("Could not register resource.");

                // The first try is done expecting at most ten processes to lock the file.
                uint arraySize = 10;
                RmResult result;
                do {
                    var array = new RM_PROCESS_INFO[arraySize];
                    uint arrayCount;
                    RM_REBOOT_REASON lpdwRebootReasons;
                    result = NativeMethods.RmGetList(handle, out arrayCount, ref arraySize, array, out lpdwRebootReasons);
                    if (result == RmResult.ERROR_SUCCESS) {
                        // Adjust the array length to fit the actual count.

                        Array.Resize(ref array, (int)arrayCount);
                        return array;
                    } else if (result == RmResult.ERROR_MORE_DATA) {
                        // We need to initialize a bigger array. We only set the size, and do another iteration.
                        // (the out parameter arrayCount contains the expected value for the next try)
                        arraySize = arrayCount;
                    } else {
                        throw new Exception("Could not list processes locking resource. Failed to get size of result.");
                    }
                } while (result != RmResult.ERROR_SUCCESS);
            } finally {
                NativeMethods.RmEndSession(handle);
            }
            return new RM_PROCESS_INFO[0];
        }

        private void InvokeMessage(CustomMessage customMessage) {
            Invoke(new Action(() => {
                CustomDialog.ShowCustomDialog(customMessage, this);
            }));
        }

        private DataTable OpenFilesSearch(string? filePath) {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Host");
            dataTable.Columns.Add("Identification");
            dataTable.Columns.Add("Accessed By");
            dataTable.Columns.Add("Type");
            dataTable.Columns.Add("Locks");
            dataTable.Columns.Add("Access Type");
            dataTable.Columns.Add("File Path");
            dataTable.Columns["Identification"].DataType = Type.GetType("System.Int32");
            dataTable.Columns["Locks"].DataType = Type.GetType("System.Int32");

            Process process = new Process();
            MessageBox.Show(Environment.SystemDirectory + "\\openfiles.exe");
            process.StartInfo.FileName = Environment.SystemDirectory + "\\openfiles.exe";
            process.StartInfo.Arguments = " /query /FO CSV /v";
            if (filePath != null && filePath != "") {
                process.StartInfo.Arguments = " /query /FO CSV /v | findstr /i /c:\""+filePath.Trim()+"\"";
            }
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardError = true;
            try {
                process.Start();
                //This string is used to contain what openfiles program returns
                string output = String.Empty;
                string errorOutput = String.Empty;
                output = process.StandardOutput.ReadToEnd();
                errorOutput = process.StandardError.ReadToEnd();
                MessageBox.Show("Waiting for Exit");
                process.WaitForExit();
                MessageBox.Show("Exited");
                if (output.Contains("\"")) {
                    output = output.Substring(output.IndexOf("\"")).Replace("\"", "");
                } else {
                    output = "Error";
                    return dataTable;
                }

                string[] outputLines;

                outputLines = output.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
                foreach (string line in outputLines) {
                    string[] lineItems = line.Split(",");
                    if (lineItems.Length < 7) { continue; }
                    dataTable.Rows.Add(lineItems[0],lineItems[1],lineItems[2],
                                       lineItems[3],lineItems[4],lineItems[5],
                                       lineItems[6]);
                }


            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
            return dataTable;
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
        private async Task ListAllProcesses() {
            bool showUnknownUsers = chkShowUnknownUsers.Checked;
            await Task.Run(() => {
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
                    RefreshProcessList(dataTable);
                } catch (Exception ex) {
                    InvokeMessage(new CustomMessage("Error listing processes: \n" + ex.Message, "Error", "error"));
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
                await task;
                return;
            }
        }
        private void btnLockedFileBrowser_Click(object sender, EventArgs e) {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog(this);
            txtLockedFilePath.Text = openFileDialog.FileName;
        }
        private async void btnEndSelectedProcess_Click(object sender, EventArgs e) {
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

        private void BtnCheckSharedFiles_Click(object sender, EventArgs e) {
            dgvSharedFiles.DataSource = OpenFilesSearch(null);
            dgvSharedFiles.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvSharedFiles.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvSharedFiles.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvSharedFiles.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvSharedFiles.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvSharedFiles.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvSharedFiles.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
    }
}
