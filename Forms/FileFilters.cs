using System;
using System.Data;
using System.Windows.Forms;
using Utilities.Classes;

namespace Utilities.Forms
{
    public partial class FileFilters : Form
    {

        private SQLite sqlite;
        public FileFilters() {
            InitializeComponent();
            sqlite = new SQLite();
        }

        private void FileFilters_Load(object sender, EventArgs e) {
            RefreshFileFilterConditions(0);
            RefreshFileFilters();
            btnClearFields_Click(sender, e);
            cboConditionType.SelectedItem = "Name Contains";
        }

        private void RefreshFileFilters() {
            DataTable dataTableFileFilters = sqlite.SelectAllFileFilters();
            dgvFileFilters.DataSource = dataTableFileFilters;
            dgvFileFilters.Columns[0].Visible = false;//ID
            dgvFileFilters.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvFileFilters.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            if (dgvFileFilters.Rows.Count <= 0) {
                btnUpdateCondition.Visible = false;
                btnDeleteCondition.Visible = false;
                btnInsertCondition.Visible = false;
            } else {
                btnUpdateCondition.Visible = true;
                btnDeleteCondition.Visible = true;
                btnInsertCondition.Visible = true;
            }
        }
        private void RefreshFileFilterConditions(int idFileFilter) {
            DataTable dataTableConditions = sqlite.SelectAllFileFilterConditions(idFileFilter, "");
            dgvFileFilterConditions.DataSource = dataTableConditions;
            dgvFileFilterConditions.Columns[0].Visible = false;//ID
            dgvFileFilterConditions.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvFileFilterConditions.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        private void SelectCorrectRowFileFilter(int? selectedId) {
            if (selectedId == null || selectedId == 0) { return; }
            dgvFileFilters.ClearSelection();
            //returns to updated/included row
            foreach (DataGridViewRow row in dgvFileFilters.Rows) {
                if (selectedId == Convert.ToInt32(row.Cells[0].Value)) {
                    row.Selected = true;
                    dgvFileFilters.CurrentCell = row.Cells[1];
                    break;
                }
            }
        }
        private void SelectCorrectRowFileCondition(int? selectedId) {
            if (selectedId == null || selectedId == 0) { return; }
            dgvFileFilterConditions.ClearSelection();
            //returns to updated/included row
            foreach (DataGridViewRow row in dgvFileFilterConditions.Rows) {
                if (selectedId == Convert.ToInt32(row.Cells[0].Value)) {
                    row.Selected = true;
                    dgvFileFilterConditions.CurrentCell = row.Cells[1];
                    break;
                }
            }
        }

        private void btnClearFields_Click(object sender, EventArgs e) {
            txtFilterName.Text = "";
            txtFilterNotes.Text = "";
            txtCondition.Text = "";
            dgvFileFilters.ClearSelection();
        }
        private void dgvFileFilters_SelectionChanged(object sender, EventArgs e) {
            if (dgvFileFilters.GetCellCount(DataGridViewElementStates.Selected) <= 0) {
                RefreshFileFilterConditions(0);
                return;
            }

            int idFileFilter = Convert.ToInt32(dgvFileFilters.SelectedRows[0].Cells[0].Value);

            txtFilterName.Text = dgvFileFilters.SelectedRows[0].Cells[1].Value.ToString();
            txtFilterNotes.Text = dgvFileFilters.SelectedRows[0].Cells[2].Value.ToString();
            RefreshFileFilterConditions(idFileFilter);
        }
        private void dgvFileFilterConditions_SelectionChanged(object sender, EventArgs e) {
            if (dgvFileFilterConditions.GetCellCount(DataGridViewElementStates.Selected) <= 0) {
                return;
            }
            int idFileFilter = Convert.ToInt32(dgvFileFilters.SelectedRows[0].Cells[0].Value);
            int idCondition = Convert.ToInt32(dgvFileFilterConditions.SelectedRows[0].Cells[0].Value);

            txtCondition.Text = dgvFileFilterConditions.SelectedRows[0].Cells[1].Value.ToString();
            cboConditionType.SelectedItem = dgvFileFilterConditions.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void btnInsertCondition_Click(object sender, EventArgs e) {
            CustomMessage customMessage;
            if (dgvFileFilters.GetCellCount(DataGridViewElementStates.Selected) <= 0) {
                customMessage = new CustomMessage("Select a filter on the table below first.", "Information", "Information");
                CustomDialog.ShowCustomDialog(customMessage, this);
                return;
            }
            if (txtCondition.Text.Equals("")) {
                customMessage = new CustomMessage("Invalid extension.", "Information", "Information");
                CustomDialog.ShowCustomDialog(customMessage, this);
                return;
            }
            customMessage = new CustomMessage("Insert new condition?", "Confirmation", "confirmation");
            if (CustomDialog.ShowCustomDialog(customMessage, this) == DialogResult.Cancel) { return; }

            int idFileFilter = Convert.ToInt32(dgvFileFilters.SelectedRows[0].Cells[0].Value);

            int idCondition;
            if (dgvFileFilterConditions.GetCellCount(DataGridViewElementStates.Selected) <= 0) {
                idCondition = 0;
            } else {
                idCondition = Convert.ToInt32(dgvFileFilterConditions.SelectedRows[0].Cells[0].Value);
            }

            FileFilterCondition fileFilterCondition = new FileFilterCondition(0, idFileFilter, cboConditionType.SelectedItem.ToString(), txtCondition.Text);

            customMessage = sqlite.InsertFileFilterCondition(fileFilterCondition);
            CustomDialog.ShowCustomDialog(customMessage, this);

            RefreshFileFilterConditions(idFileFilter);
            SelectCorrectRowFileCondition(idCondition);
        }
        private void btnUpdateCondition_Click(object sender, EventArgs e) {
            CustomMessage customMessage;
            if (dgvFileFilters.GetCellCount(DataGridViewElementStates.Selected) <= 0) {
                customMessage = new CustomMessage("Select a filter on the table below first.", "Information", "Information");
                CustomDialog.ShowCustomDialog(customMessage, this);
                return;
            }
            if (dgvFileFilterConditions.GetCellCount(DataGridViewElementStates.Selected) <= 0) {
                customMessage = new CustomMessage("Select a condition on the table above first.", "Information", "Information");
                CustomDialog.ShowCustomDialog(customMessage, this);
                return;
            }
            if (txtCondition.Text.Equals("")) {
                customMessage = new CustomMessage("Invalid condition.", "Information", "Information");
                CustomDialog.ShowCustomDialog(customMessage, this);
                return;
            }

            int idFileFilter = Convert.ToInt32(dgvFileFilters.SelectedRows[0].Cells[0].Value);
            int idCondition = Convert.ToInt32(dgvFileFilterConditions.SelectedRows[0].Cells[0].Value);

            customMessage = new CustomMessage("Update selected condition?\nSelected: " + txtCondition.Text, "Confirmation", "confirmation");
            if (CustomDialog.ShowCustomDialog(customMessage, this) == DialogResult.Cancel) { return; }

            FileFilterCondition fileFilterCondition = new FileFilterCondition(idCondition, idFileFilter, cboConditionType.SelectedItem.ToString(), txtCondition.Text);

            customMessage = sqlite.UpdateFileFilterCondition(fileFilterCondition);
            CustomDialog.ShowCustomDialog(customMessage, this);

            RefreshFileFilterConditions(idFileFilter);
            SelectCorrectRowFileCondition(idCondition);
        }
        private void btnDeleteCondition_Click(object sender, EventArgs e) {
            CustomMessage customMessage;
            if (dgvFileFilters.GetCellCount(DataGridViewElementStates.Selected) <= 0) {
                customMessage = new CustomMessage("Select a filter on the table below first.", "Information", "Information");
                CustomDialog.ShowCustomDialog(customMessage, this);
                return;
            }
            if (dgvFileFilterConditions.GetCellCount(DataGridViewElementStates.Selected) <= 0) {
                customMessage = new CustomMessage("Select a condition on the table above first.", "Information", "Information");
                CustomDialog.ShowCustomDialog(customMessage, this);
                return;
            }

            int idFileFilter = Convert.ToInt32(dgvFileFilters.SelectedRows[0].Cells[0].Value);
            int idCondition = Convert.ToInt32(dgvFileFilterConditions.SelectedRows[0].Cells[0].Value);

            customMessage = new CustomMessage("Delete selected condition?\nSelected: " + txtCondition.Text, "Confirmation", "confirmation");
            if (CustomDialog.ShowCustomDialog(customMessage, this) == DialogResult.Cancel) { return; }

            FileFilterCondition fileFilterCondition = new FileFilterCondition(idCondition, idFileFilter, cboConditionType.SelectedItem.ToString(), txtCondition.Text);

            customMessage = sqlite.DeleteFileFilterCondition(fileFilterCondition);
            CustomDialog.ShowCustomDialog(customMessage, this);

            RefreshFileFilterConditions(idFileFilter);
        }

        private void btnInsertFileFilter_Click(object sender, EventArgs e) {
            CustomMessage customMessage;
            if (txtFilterName.Text.Equals("")) {
                customMessage = new CustomMessage("Invalid file filter name.", "Information", "Information");
                CustomDialog.ShowCustomDialog(customMessage, this);
                return;
            }
            customMessage = new CustomMessage("Insert new file filter?", "Confirmation", "confirmation");
            if (CustomDialog.ShowCustomDialog(customMessage, this) == DialogResult.Cancel) { return; }

            int idFileFilter;
            if (dgvFileFilters.GetCellCount(DataGridViewElementStates.Selected) <= 0) {
                idFileFilter = 0;
            } else {
                idFileFilter = Convert.ToInt32(dgvFileFilters.SelectedRows[0].Cells[0].Value);
            }

            FileFilter fileFilter = new FileFilter(0, txtFilterName.Text, txtFilterNotes.Text);

            customMessage = sqlite.InsertFileFilter(fileFilter);
            CustomDialog.ShowCustomDialog(customMessage, this);

            RefreshFileFilters();
            SelectCorrectRowFileFilter(idFileFilter);
        }
        private void btnUpdateFileFilter_Click(object sender, EventArgs e) {
            CustomMessage customMessage;
            if (dgvFileFilters.GetCellCount(DataGridViewElementStates.Selected) <= 0) {
                customMessage = new CustomMessage("Select a file filter on the table below first.", "Information", "Information");
                CustomDialog.ShowCustomDialog(customMessage, this);
                return;
            }
            if (txtFilterName.Text.Equals("")) {
                customMessage = new CustomMessage("Invalid file filter name.", "Information", "Information");
                CustomDialog.ShowCustomDialog(customMessage, this);
                return;
            }

            int idFileFilter = Convert.ToInt32(dgvFileFilters.SelectedRows[0].Cells[0].Value);

            customMessage = new CustomMessage("Update selected file filter?\nSelected: " + txtFilterName.Text, "Confirmation", "confirmation");
            if (CustomDialog.ShowCustomDialog(customMessage, this) == DialogResult.Cancel) { return; }

            FileFilter fileFilter = new FileFilter(idFileFilter, txtFilterName.Text, txtFilterNotes.Text);

            customMessage = sqlite.UpdateFileFilter(fileFilter);
            CustomDialog.ShowCustomDialog(customMessage, this);

            RefreshFileFilters();
            SelectCorrectRowFileFilter(idFileFilter);
        }
        private void btnDeleteFileFilter_Click(object sender, EventArgs e) {
            CustomMessage customMessage;
            if (dgvFileFilters.GetCellCount(DataGridViewElementStates.Selected) <= 0) {
                customMessage = new CustomMessage("Select a filter on the table below first.", "Information", "Information");
                CustomDialog.ShowCustomDialog(customMessage, this);
                return;
            }

            int idFileFilter = Convert.ToInt32(dgvFileFilters.SelectedRows[0].Cells[0].Value);
            int selectedRow = Convert.ToInt32(dgvFileFilters.SelectedRows[0].Index);

            customMessage = new CustomMessage("Delete selected file filter?\nSelected: " + txtFilterName.Text, "Confirmation", "confirmation");
            if (CustomDialog.ShowCustomDialog(customMessage, this) == DialogResult.Cancel) { return; }

            FileFilter fileFilter = new FileFilter(idFileFilter, txtFilterName.Text, txtFilterNotes.Text);

            customMessage = sqlite.DeleteFileFilter(fileFilter);
            CustomDialog.ShowCustomDialog(customMessage, this);

            dgvFileFilters.Rows.RemoveAt(selectedRow);
            RefreshFileFilters();
            btnClearFields_Click(sender, e);
        }
    }
}
