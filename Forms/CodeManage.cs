using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilities.Classes;

namespace Utilities.Forms
{
    public partial class CodeManage : Form
    {
        private readonly SQLite sqlite = new SQLite();

        public CodeManage() {
            InitializeComponent();
        }
        private void CodeManage_Load(object sender, EventArgs e) {
            RefreshCodes();
            BtnClearFields_Click(sender, e);
        }

        private void RefreshCodes() {
            DataTable dtCodes = sqlite.SelectAllCodes("");
            dgvCodes.DataSource = dtCodes;
            dgvCodes.Columns[0].Visible = false;//ID
            dgvCodes.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        private void SelectCorrectRow(Code code) {
            dgvCodes.ClearSelection();
            //returns to updated/included row
            foreach (DataGridViewRow row in dgvCodes.Rows) {
                if (code.ID == Int32.Parse(row.Cells[0].Value.ToString())) {
                    row.Selected = true;
                    dgvCodes.CurrentCell = row.Cells[1];
                    break;
                }
            }
        }

        private bool ShowConfirmationDialog(string title, string message) {
            DialogResult dr = MessageBox.Show(message, title, MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes) {
                return true;
            } else {
                return false;
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
        }
        private void BtnInsert_Click(object sender, EventArgs e) {
            int id;
            id = Int32.Parse(dgvCodes.SelectedRows[0].Cells[0].Value.ToString());
            Code code = new Code(id, txtName.Text,txtType.Text,txtCodeText.Text);
            code.FormatStrings();
            sqlite.InsertCode(code);
            RefreshCodes();
            SelectCorrectRow(code);
        }
        private void BtnUpdate_Click(object sender, EventArgs e) {
            if (dgvCodes.GetCellCount(DataGridViewElementStates.Selected) <= 0) { return; }
            if (ShowConfirmationDialog("Update Code", "Update selected code?") == false) { return; }
            int id;
            id = Int32.Parse(dgvCodes.SelectedRows[0].Cells[0].Value.ToString());
            Code code = new Code(id, txtName.Text, txtType.Text, txtCodeText.Text);
            code.FormatStrings();
            sqlite.UpdateCode(code);
            RefreshCodes();
            SelectCorrectRow(code);
        }
        private void BtnDelete_Click(object sender, EventArgs e) {
            if (dgvCodes.GetCellCount(DataGridViewElementStates.Selected) <= 0) { return; }
            if (ShowConfirmationDialog("Delete Code","Delete selected code?") == false) { return; }

            string name, type, codeText;
            int selectedRow,id;
            id = Int32.Parse(dgvCodes.SelectedRows[0].Cells[0].Value.ToString());
            name = dgvCodes.SelectedRows[0].Cells[1].Value.ToString();
            type = dgvCodes.SelectedRows[0].Cells[2].Value.ToString();
            codeText = dgvCodes.SelectedRows[0].Cells[3].Value.ToString();
            selectedRow = dgvCodes.SelectedRows[0].Index;

            Code code = new Code(id, name, type, codeText);
            code.FormatStrings();
            sqlite.DeleteCode(code);
            dgvCodes.Rows.RemoveAt(selectedRow);
            BtnClearFields_Click(sender, e);
        }

    }
}
