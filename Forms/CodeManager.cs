using System;
using System.Data;
using System.Windows.Forms;
using Utilities.Classes;

namespace Utilities.Forms
{
    public partial class CodeManager : Form
    {
        private SQLite sqlite;

        public CodeManager() {
            InitializeComponent();
            sqlite = new SQLite();
        }
        private void CodeManage_Load(object sender, EventArgs e) {
            RefreshCodes();
            BtnClearFields_Click(sender, e);
        }

        private void RefreshCodes() {
            DataTable dtCodes = sqlite.SelectAllCodes("");
            dtCodes.DefaultView.Sort = "ID";
            dgvCodes.DataSource = dtCodes;
            dgvCodes.Columns[0].Visible = false;//ID
            dgvCodes.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvCodes.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvCodes.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }
        private void SelectCorrectRow(int? selectedId) {
            if (selectedId == null || selectedId == 0) { return; }
            dgvCodes.ClearSelection();
            //returns to updated/included row
            foreach (DataGridViewRow row in dgvCodes.Rows) {
                if (selectedId == Int32.Parse(row.Cells[0].Value.ToString())) {
                    row.Selected = true;
                    dgvCodes.CurrentCell = row.Cells[1];
                    break;
                }
            }
        }

        private void DgvCodes_SelectionChanged(object sender, EventArgs e) {
            if (dgvCodes.GetCellCount(DataGridViewElementStates.Selected) <= 0) { return; }

            txtName.Text = dgvCodes.SelectedRows[0].Cells[1].Value.ToString();
            txtType.Text = dgvCodes.SelectedRows[0].Cells[2].Value.ToString();
            txtCodeText.Text = dgvCodes.SelectedRows[0].Cells[3].Value.ToString();
        }
        private void BtnClearFields_Click(object sender, EventArgs e) {
            txtName.Text = "";
            txtCodeText.Text = "";
            txtType.Text = "";
            dgvCodes.ClearSelection();
        }
        private void BtnInsert_Click(object sender, EventArgs e) {
            CustomMessage customMessage;
            if (txtName.Text.Equals("")) {
                customMessage = new CustomMessage("Invalid code name.", "Information", "information");
                CustomDialog.ShowCustomDialog(customMessage, this);
                return;
            }

            customMessage = new CustomMessage("Insert new code?", "Confirmation", "confirmation");
            if (CustomDialog.ShowCustomDialog(customMessage, this) == DialogResult.Cancel) { return; }

            int selectedId;
            if (dgvCodes.GetCellCount(DataGridViewElementStates.Selected) <= 0) {
                selectedId = 0;
            } else {
                selectedId = Int32.Parse(dgvCodes.SelectedRows[0].Cells[0].Value.ToString());
            }

            Code code = new Code(0, txtName.Text, txtType.Text, txtCodeText.Text);
            code.FormatStrings();
            code = sqlite.InsertCode(code,this);

            RefreshCodes();
            SelectCorrectRow(code.ID);
        }
        private void BtnUpdate_Click(object sender, EventArgs e) {
            CustomMessage customMessage;
            if (dgvCodes.GetCellCount(DataGridViewElementStates.Selected) <= 0) {
                customMessage = new CustomMessage("Select a code on the table below first.", "Information", "Information");
                CustomDialog.ShowCustomDialog(customMessage, this);
                return;
            }

            int selectedId;
            selectedId = Int32.Parse(dgvCodes.SelectedRows[0].Cells[0].Value.ToString());
            customMessage = new CustomMessage("Update selected code?\nSelected: " + txtName.Text, "Confirmation", "confirmation");
            if (CustomDialog.ShowCustomDialog(customMessage, this) == DialogResult.Cancel) { return; }

            Code code = new Code(selectedId, txtName.Text, txtType.Text, txtCodeText.Text);
            code.FormatStrings();

            customMessage = sqlite.UpdateCode(code);
            CustomDialog.ShowCustomDialog(customMessage, this);

            RefreshCodes();
            SelectCorrectRow(selectedId);
        }
        private void BtnDelete_Click(object sender, EventArgs e) {
            CustomMessage customMessage;
            if (dgvCodes.GetCellCount(DataGridViewElementStates.Selected) <= 0) {
                customMessage = new CustomMessage("Select a code on the table below first.", "Information", "Information");
                CustomDialog.ShowCustomDialog(customMessage, this);
                return;
            }

            string name, type, codeText;
            int selectedRow, id;
            id = Int32.Parse(dgvCodes.SelectedRows[0].Cells[0].Value.ToString());
            name = dgvCodes.SelectedRows[0].Cells[1].Value.ToString();
            type = dgvCodes.SelectedRows[0].Cells[2].Value.ToString();
            codeText = dgvCodes.SelectedRows[0].Cells[3].Value.ToString();
            selectedRow = dgvCodes.SelectedRows[0].Index;

            customMessage = new CustomMessage("Delete selected code?\nSelected: " + name, "Confirmation", "confirmation");
            if (CustomDialog.ShowCustomDialog(customMessage, this) == DialogResult.Cancel) { return; }

            Code code = new Code(id, name, type, codeText);
            code.FormatStrings();

            customMessage = sqlite.DeleteCode(code);
            CustomDialog.ShowCustomDialog(customMessage, this);

            dgvCodes.Rows.RemoveAt(selectedRow);
            BtnClearFields_Click(sender, e);
        }

        private void btnAddDefaults_Click(object sender, EventArgs e) {
            CustomMessage customMessage = new CustomMessage("Add default list of clarion codes?", "Confirmation", "confirmation");
            if (CustomDialog.ShowCustomDialog(customMessage, this) == DialogResult.Cancel) { return; }
            sqlite.AddDefaultCodes();
            RefreshCodes();
        }
        private void btnDeleteAll_Click(object sender, EventArgs e) {
            CustomMessage customMessage = new CustomMessage("Delete all registered codes?", "Confirmation", "confirmation");
            if (CustomDialog.ShowCustomDialog(customMessage, this) == DialogResult.Cancel) { return; }

            customMessage = sqlite.DeleteAllCodes();
            CustomDialog.ShowCustomDialog(customMessage, this);

            RefreshCodes();
            BtnClearFields_Click(sender, e);
        }

        private void CodeManage_KeyDown(object sender, KeyEventArgs e) {
            switch (e.KeyCode) { 
                case Keys.Enter:
                    if (txtCodeText.Focused) { return; }
                    if (dgvCodes.GetCellCount(DataGridViewElementStates.Selected) == 0) { 
                        BtnInsert_Click(sender, e);
                    } else {
                        BtnUpdate_Click(sender, e);
                    }
                    break;
                case Keys.Delete:
                    BtnDelete_Click(sender, e);
                    break;
                case Keys.Escape:
                    BtnClearFields_Click(sender, e);
                    break;
            }
        }
    }
}
