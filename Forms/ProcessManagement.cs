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
    public partial class ProcessManagement : Form
    {
        public ProcessManagement() {
            InitializeComponent();
        }
        private void ProcessManagement_Load(object sender, EventArgs e) {
            RefreshProcessList(GetGridDataTable());
        }

        private Task task;

        private DataTable GetGridDataTable() {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ID");
            dataTable.Columns.Add("Name");
            dataTable.Columns.Add("User");
            dataTable.Columns["ID"].DataType = Type.GetType("System.Int32");
            return dataTable;
        }
        private void RefreshProcessList(DataTable dataTable) {
            Invoke(new MethodInvoker(delegate {
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
                return null;
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

        private async Task GetLockedFileProcesses() {
            string lockedFile = txtLockedFilePath.Text;
            if (lockedFile == null || lockedFile.Length == 0) {
                CustomDialog.ShowCustomDialog(new CustomMessage("Select a file", "Error", "error"), Handle);
                return;
            }
            IntPtr handle = this.Handle;

            await Task.Run(() => {
                RM_PROCESS_INFO[] rm = null;
                Process process = null;
                DataTable dataTable = GetGridDataTable();
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
                    CustomDialog.ShowCustomDialog(new CustomMessage("Error getting processes :\n" + ex.Message, "Error", "error"), handle);
                }

            });
        }
        private async Task ListAllProcesses() {
            IntPtr handle = this.Handle;

            await Task.Run(() => {
                DataTable dataTable = GetGridDataTable();
                string owner = "";

                try {
                    foreach (Process process in Process.GetProcesses().OrderBy(p => p.Id)) {
                        owner = GetProcessUser(process);
                        if (owner == null || owner.Equals("")) {
                            owner = "Unknown";
                        }
                        if (!chkShowUnknownUsers.Checked && owner.Equals("Unknown")) { continue; }
                        dataTable.Rows.Add(process.Id, process.ProcessName, owner);
                    }
                    RefreshProcessList(dataTable);
                } catch (Exception ex) {
                    CustomDialog.ShowCustomDialog(new CustomMessage("Error listing processes: \n" + ex.Message, "Error", "error"), handle);
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
        private async void btnListProcesses_Click(object sender, EventArgs e) {
            if (task == null || task.IsCompleted) {
                task = ListAllProcesses();
                await task;
                return;
            }
        }
        private void btnLockedFileBrowser_Click(object sender, EventArgs e) {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog(this);
            txtLockedFilePath.Text = openFileDialog.FileName;
        }
        private void btnEndSelectedProcess_Click(object sender, EventArgs e) {
            if (dgvProcess.GetCellCount(DataGridViewElementStates.Selected) <= 0) { return; }
            int id = Int32.Parse(dgvProcess.SelectedRows[0].Cells[0].Value.ToString());
            string name, owner;
            name = dgvProcess.SelectedRows[0].Cells[1].Value.ToString();
            owner = dgvProcess.SelectedRows[0].Cells[2].Value.ToString();

            CustomMessage customMessage = new CustomMessage("You are about to end the process below. Are you sure?\nID: " +id+"    Name: "+name+"\nOwner: "+owner , "Confirmation", "confirmation");
            DialogResult result = CustomDialog.ShowCustomDialog(customMessage, Handle);
            if (result == DialogResult.Cancel) {
                customMessage = new CustomMessage("Action aborted.", "Information", "information");
                CustomDialog.ShowCustomDialog(customMessage, Handle);
                return;
            }
            try { 
                Process process = Process.GetProcessById(id);
                process.Kill();
                dgvProcess.Rows.RemoveAt(dgvProcess.SelectedRows[0].Index);
                customMessage = new CustomMessage("Process ended successfully.", "Success", "success");
            } catch (Exception ex) {
                customMessage = new CustomMessage("Error trying to end selected process :\n" + ex.Message, "Error", "error");
            }
            CustomDialog.ShowCustomDialog(customMessage, Handle);
        }
    }
}
