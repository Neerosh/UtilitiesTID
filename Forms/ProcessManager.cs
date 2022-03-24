using System;
using System.Data;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilities.Classes;
using static Utilities.Classes.NativeMethods;

namespace Utilities.Forms
{
    public partial class ProcessManager : Form
    {
        private Task taskListProcesses;
        private CancellationTokenSource ctsListProcesses;

        public ProcessManager() {
            InitializeComponent();
        }
        private void ProcessManagement_Load(object sender, EventArgs e) {
            RefreshProcessList(GetProcessesDataTable());
            cboWhereField.SelectedIndex = 0;
        }

        private DataTable GetProcessesDataTable() {
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

        private void InvokeMessage(CustomMessage customMessage) {
            Invoke(new Action(() => {
                CustomDialog.ShowCustomDialog(customMessage, this);
            }));
        }
        private async Task ListProcesses(bool useFilters,CancellationTokenSource cancellationTokenSource) {
            lblListProgress.Visible = true;
            bool showUnknownUsers = chkShowUnknownUsers.Checked;
            string conditionField = String.Empty;
            string conditionValue = String.Empty;
            if (useFilters) {
                conditionField = cboWhereField.SelectedItem.ToString();
                conditionValue = txtWhereValue.Text;
                if (conditionField.Equals("") || conditionValue.Equals("")) {
                    InvokeMessage(new CustomMessage("Error condition cannot have empty fields.", "Error", "error"));
                    return;
                }
            }
            await Task.Run(() => {
                Thread.Sleep(1000);
                DataTable dataTable = GetProcessesDataTable();
                string owner = "Unknown";
                try {
                    Process[] processes;
                    switch (conditionField) {
                        case "ID":
                            Process process = Process.GetProcessById(Convert.ToInt32(conditionValue));
                            processes = new Process[1] { process };
                            break;
                        case "Name":
                            processes = Process.GetProcessesByName(conditionValue);
                            break;
                        default:
                            processes = Process.GetProcesses(".");
                            break;
                    }

                    cancellationTokenSource.Token.ThrowIfCancellationRequested();

                    foreach (Process process in processes) {
                        owner = GetProcessUser(process);
                        if (owner.Equals("")) {
                            owner = "Unknown";
                        }
                        if (showUnknownUsers == false && owner.Equals("Unknown")) {
                            continue;
                        }
                        dataTable.Rows.Add(process.Id, process.ProcessName, owner);
                        cancellationTokenSource.Token.ThrowIfCancellationRequested();
                    }
                    RefreshProcessList(dataTable);
                } catch (OperationCanceledException) {
                } catch (Exception ex) {
                    InvokeMessage(new CustomMessage("Error listing processes: \n" + ex.Message, "Error", "error"));
                }
            }, cancellationTokenSource.Token);
            btnListProcesses.Text = "List Running Processes";
            btnListFilteredProcesses.Text = "List Filtered Processes";
            lblListProgress.Visible = false;
            cancellationTokenSource.Dispose();
        }

        private void BtnListFilteredProcesses_Click(object sender, EventArgs e) {
            if (btnListFilteredProcesses.Text == "Stop Listing Processes") {
                ctsListProcesses.Cancel();
                return;
            }
            if (taskListProcesses == null || taskListProcesses.IsCompleted) {
                string conditionField = cboWhereField.SelectedItem.ToString();
                string conditionValue = txtWhereValue.Text;
                if (conditionField.Equals("") || conditionValue.Equals("")) {
                    InvokeMessage(new CustomMessage("Error condition cannot have empty fields.", "Error", "error"));
                    return;
                }

                ctsListProcesses = new CancellationTokenSource();
                taskListProcesses = ListProcesses(true, ctsListProcesses);
                btnListFilteredProcesses.Text = "Stop Listing Processes";
            }
        }
        private void BtnListProcesses_Click(object sender, EventArgs e) {
            if (btnListProcesses.Text == "Stop Listing Processes") {
                ctsListProcesses.Cancel();
                return;
            }
            if (taskListProcesses == null || taskListProcesses.IsCompleted) {
                ctsListProcesses = new CancellationTokenSource();
                taskListProcesses = ListProcesses(false, ctsListProcesses);
                btnListProcesses.Text = "Stop Listing Processes";
            }
        }
        private void BtnEndSelectedProcess_Click(object sender, EventArgs e) {
            if (dgvProcess.GetCellCount(DataGridViewElementStates.Selected) <= 0) { return; }

            int processId = Int32.Parse(dgvProcess.SelectedRows[0].Cells[0].Value.ToString());
            string processName = dgvProcess.SelectedRows[0].Cells[1].Value.ToString();
            string processOwner = dgvProcess.SelectedRows[0].Cells[2].Value.ToString();

            CustomMessage customMessage = new CustomMessage("You are about to end this process:\nID: " +
                                            processId + "  Name: " + processName + "  Owner: " + processOwner + "\nAre you sure?", "Confirmation", "confirmation");
            DialogResult result = CustomDialog.ShowCustomDialog(customMessage, this);
            if (result == DialogResult.Cancel) {
                return;
            }

            try {
                Process process = Process.GetProcessById(processId);
                process.Kill();
                dgvProcess.Rows.RemoveAt(dgvProcess.SelectedRows[0].Index);
            } catch (Exception ex) {
                CustomDialog.ShowCustomDialog(new CustomMessage("Error ending process: \n" + ex.Message, "Error", "error"), this);
            }
        }

        private void TxtWhereValue_Validated(object sender, EventArgs e) {
            string whereField = cboWhereField.SelectedItem.ToString();
            bool onlyDigits = true;
            foreach (char character in txtWhereValue.Text) {
                onlyDigits = char.IsDigit(character);
                if (onlyDigits == false) { break; }
            }

            if (whereField.Equals("ID") && onlyDigits == false) {
                txtWhereValue.Text = "";
            }
        }

        private void cboWhereField_SelectionChangeCommitted(object sender, EventArgs e) {
            TxtWhereValue_Validated(sender, e);
        }
    }
}
