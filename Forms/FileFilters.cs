using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Utilities.Classes;

namespace Utilities.Forms
{
    public partial class FileFilters : Form
    {

        private readonly SQLite sqlite = new SQLite();
        public FileFilters() {
            InitializeComponent();
        }

        private void FileFilters_Load(object sender, EventArgs e) {
            RefreshFileFilters();
            lsbFileExtensions_SelectedIndexChanged(sender, e);
            lsbFiles_SelectedIndexChanged(sender, e);
            btnClearFields_Click(sender, e);
        }

        private void RefreshFileFilters() { 
            DataTable dataTableFileFilters = sqlite.SelectAllFileFilters();
            dgvFileFilters.DataSource = dataTableFileFilters;
            dgvFileFilters.Columns[0].Visible = false;//ID
            dgvFileFilters.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvFileFilters.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            if (dgvFileFilters.Rows.Count <= 0) {
                btnDeleteFile.Visible = false;
                btnInsertFile.Visible = false;
                btnUpdateFile.Visible = false;
                btnUpdateExtension.Visible = false;
                btnDeleteExtension.Visible = false;
                btnInsertExtension.Visible = false;
            } else {
                btnDeleteFile.Visible = true;
                btnInsertFile.Visible = true;
                btnUpdateFile.Visible = true;
                btnUpdateExtension.Visible = true;
                btnDeleteExtension.Visible = true;
                btnInsertExtension.Visible = true;
            }
        }
        private void SelectCorrectRow(int? selectedId) {
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

        private void RefreshFileFilterFiles(int idFileFilter) {
            if (idFileFilter == 0) {
                lsbFiles.DataSource = null;
                return;
            }
            DataTable dataTableFiles = sqlite.SelectAllFileFilterFiles(idFileFilter);
            lsbFiles.DataSource = dataTableFiles;
            lsbFiles.DisplayMember = "FileName";
            lsbFiles.ValueMember = "Id";
        }
        private void RefreshFileFilterExtensions(int idFileFilter) {
            if (idFileFilter == 0) {
                lsbFileExtensions.DataSource = null;
                return;
            }
            DataTable dataTableExtensions = sqlite.SelectAllFileFilterExtensions(idFileFilter);
            lsbFileExtensions.DataSource = dataTableExtensions;
            lsbFileExtensions.DisplayMember = "Extension";
            lsbFileExtensions.ValueMember = "Id";
        }

        private void btnClearFields_Click(object sender, EventArgs e) {
            txtFilterName.Text = "";
            txtFilterNotes.Text = "";
            txtFileName.Text = "";
            txtFileExtension.Text = "";
            dgvFileFilters.ClearSelection();
        }
        private void dgvFileFilters_SelectionChanged(object sender, EventArgs e) {
            if (dgvFileFilters.GetCellCount(DataGridViewElementStates.Selected) <= 0) {
                RefreshFileFilterFiles(0);
                RefreshFileFilterExtensions(0);
                return; }

            int idFileFilter = Convert.ToInt32(dgvFileFilters.SelectedRows[0].Cells[0].Value);

            txtFilterName.Text = dgvFileFilters.SelectedRows[0].Cells[1].Value.ToString();
            txtFilterNotes.Text = dgvFileFilters.SelectedRows[0].Cells[2].Value.ToString();
            RefreshFileFilterFiles(idFileFilter);
            RefreshFileFilterExtensions(idFileFilter);
        }

        private void btnInsertFile_Click(object sender, EventArgs e) {
            CustomMessage customMessage;
            if (dgvFileFilters.GetCellCount(DataGridViewElementStates.Selected) <= 0) {
                customMessage = new CustomMessage("Select a filter on the table below first.", "Information", "Information");
                CustomDialog.ShowCustomDialog(customMessage, Handle);
                return;
            }
            if (txtFileName.Text.Equals("")) {
                customMessage = new CustomMessage("Invalid filname.", "Information", "Information");
                CustomDialog.ShowCustomDialog(customMessage, Handle);
                return;
            }
            customMessage = new CustomMessage("Insert new file?", "Confirmation", "confirmation");
            if (CustomDialog.ShowCustomDialog(customMessage, Handle) == DialogResult.Cancel) { return; }

            int idFileFilter = Convert.ToInt32(dgvFileFilters.SelectedRows[0].Cells[0].Value);

            FileFilterFile fileFilterFile = new FileFilterFile(0, idFileFilter,txtFileName.Text);

            customMessage = sqlite.InsertFileFilterFile(fileFilterFile);
            CustomDialog.ShowCustomDialog(customMessage, Handle);

            RefreshFileFilterFiles(idFileFilter);
        }
        private void btnUpdateFile_Click(object sender, EventArgs e) {
            CustomMessage customMessage;
            if (dgvFileFilters.GetCellCount(DataGridViewElementStates.Selected) <= 0) {
                customMessage = new CustomMessage("Select a filter on the table below first.", "Information", "Information");
                CustomDialog.ShowCustomDialog(customMessage, Handle);
                return;
            }
            if (txtFileName.Text.Equals("")) {
                customMessage = new CustomMessage("Invalid filname.", "Information", "Information");
                CustomDialog.ShowCustomDialog(customMessage, Handle);
                return;
            }
            if (lsbFiles.SelectedIndex < 0) { return; }

            int idFileFilter = Convert.ToInt32(dgvFileFilters.SelectedRows[0].Cells[0].Value);
            int idFile = Convert.ToInt32(lsbFiles.SelectedValue);

            customMessage = new CustomMessage("Update selected file?\nSelected: " + txtFileName.Text, "Confirmation", "confirmation");
            if (CustomDialog.ShowCustomDialog(customMessage, Handle) == DialogResult.Cancel) { return; }

            FileFilterFile fileFilterFile = new FileFilterFile(idFile, idFileFilter, txtFileName.Text);

            customMessage = sqlite.UpdateFileFilterFile(fileFilterFile);
            CustomDialog.ShowCustomDialog(customMessage, Handle);

            RefreshFileFilterFiles(idFileFilter);
        }
        private void btnDeleteFile_Click(object sender, EventArgs e) {
            CustomMessage customMessage;
            if (dgvFileFilters.GetCellCount(DataGridViewElementStates.Selected) <= 0) {
                customMessage = new CustomMessage("Select a filter on the table below first.", "Information", "Information");
                CustomDialog.ShowCustomDialog(customMessage, Handle);
                return;
            }
            if (lsbFiles.SelectedIndex < 0) { return; }

            int idFileFilter = Convert.ToInt32(dgvFileFilters.SelectedRows[0].Cells[0].Value);
            int idFile = Convert.ToInt32(lsbFiles.SelectedValue);

            customMessage = new CustomMessage("Delete selected file?\nSelected: " + txtFileName.Text, "Confirmation", "confirmation");
            if (CustomDialog.ShowCustomDialog(customMessage, Handle) == DialogResult.Cancel) { return; }

            FileFilterFile fileFilterFile = new FileFilterFile(idFile, idFileFilter, txtFileName.Text);

            customMessage = sqlite.DeleteFileFilterFile(fileFilterFile);
            CustomDialog.ShowCustomDialog(customMessage, Handle);

            RefreshFileFilterFiles(idFileFilter);
        }

        private void btnInsertExtension_Click(object sender, EventArgs e) {
            CustomMessage customMessage;
            if (dgvFileFilters.GetCellCount(DataGridViewElementStates.Selected) <= 0) {
                customMessage = new CustomMessage("Select a filter on the table below first.", "Information", "Information");
                CustomDialog.ShowCustomDialog(customMessage, Handle);
                return;
            }
            if (txtFileExtension.Text.Equals("")) {
                customMessage = new CustomMessage("Invalid extension.", "Information", "Information");
                CustomDialog.ShowCustomDialog(customMessage, Handle);
                return;
            }
            customMessage = new CustomMessage("Insert new extension?", "Confirmation", "confirmation");
            if (CustomDialog.ShowCustomDialog(customMessage, Handle) == DialogResult.Cancel) { return; }

            int idFileFilter = Convert.ToInt32(dgvFileFilters.SelectedRows[0].Cells[0].Value);

            FileFilterExtension fileFilterFile = new FileFilterExtension(0, idFileFilter, txtFileExtension.Text);

            customMessage = sqlite.InsertFileFilterExtension(fileFilterFile);
            CustomDialog.ShowCustomDialog(customMessage, Handle);

            RefreshFileFilterExtensions(idFileFilter);
        }
        private void btnUpdateExtension_Click(object sender, EventArgs e) {
            CustomMessage customMessage;
            if (dgvFileFilters.GetCellCount(DataGridViewElementStates.Selected) <= 0) {
                customMessage = new CustomMessage("Select a filter on the table below first.", "Information", "Information");
                CustomDialog.ShowCustomDialog(customMessage, Handle);
                return;
            }
            if (txtFileExtension.Text.Equals("")) {
                customMessage = new CustomMessage("Invalid extension.", "Information", "Information");
                CustomDialog.ShowCustomDialog(customMessage, Handle);
                return;
            }
            if (lsbFileExtensions.SelectedIndex < 0) { return; }

            int idFileFilter = Convert.ToInt32(dgvFileFilters.SelectedRows[0].Cells[0].Value);
            int idExtension = Convert.ToInt32(lsbFileExtensions.SelectedValue);

            customMessage = new CustomMessage("Update selected extension?\nSelected: " + txtFileExtension.Text, "Confirmation", "confirmation");
            if (CustomDialog.ShowCustomDialog(customMessage, Handle) == DialogResult.Cancel) { return; }

            FileFilterExtension fileFilterExtension = new FileFilterExtension(idExtension, idFileFilter, txtFileExtension.Text);

            customMessage = sqlite.UpdateFileFilterExtension(fileFilterExtension);
            CustomDialog.ShowCustomDialog(customMessage, Handle);

            RefreshFileFilterExtensions(idFileFilter);
        }
        private void btnDeleteExtension_Click(object sender, EventArgs e) {
            CustomMessage customMessage;
            if (dgvFileFilters.GetCellCount(DataGridViewElementStates.Selected) <= 0) {
                customMessage = new CustomMessage("Select a filter on the table below first.", "Information", "Information");
                CustomDialog.ShowCustomDialog(customMessage, Handle);
                return;
            }
            if (lsbFileExtensions.SelectedIndex < 0) { return; }

            int idFileFilter = Convert.ToInt32(dgvFileFilters.SelectedRows[0].Cells[0].Value);
            int idFile = Convert.ToInt32(lsbFileExtensions.SelectedValue);

            customMessage = new CustomMessage("Delete selected extension?\nSelected: " + txtFileExtension.Text, "Confirmation", "confirmation");
            if (CustomDialog.ShowCustomDialog(customMessage, Handle) == DialogResult.Cancel) { return; }

            FileFilterExtension fileFilterExtension = new FileFilterExtension(idFile, idFileFilter, txtFileExtension.Text);

            customMessage = sqlite.DeleteFileFilterExtension(fileFilterExtension);
            CustomDialog.ShowCustomDialog(customMessage, Handle);

            RefreshFileFilterExtensions(idFileFilter);
        }

        private void btnInsertFileFilter_Click(object sender, EventArgs e) {
            CustomMessage customMessage;
            if (txtFilterName.Text.Equals("")) {
                customMessage = new CustomMessage("Invalid file filter name.", "Information", "Information");
                CustomDialog.ShowCustomDialog(customMessage, Handle);
                return;
            }
            customMessage = new CustomMessage("Insert new file filter?", "Confirmation", "confirmation");
            if (CustomDialog.ShowCustomDialog(customMessage, Handle) == DialogResult.Cancel) { return; }

            int idFileFilter;
            if (dgvFileFilters.GetCellCount(DataGridViewElementStates.Selected) <= 0) {
                idFileFilter = 0;
            } else {
                idFileFilter = Convert.ToInt32(dgvFileFilters.SelectedRows[0].Cells[0].Value);
            }

            FileFilter fileFilter = new FileFilter(0, txtFilterName.Text,txtFilterNotes.Text);

            customMessage = sqlite.InsertFileFilter(fileFilter);
            CustomDialog.ShowCustomDialog(customMessage, Handle);

            RefreshFileFilters();
            SelectCorrectRow(idFileFilter);
        }
        private void btnUpdateFileFilter_Click(object sender, EventArgs e) {
            CustomMessage customMessage;
            if (dgvFileFilters.GetCellCount(DataGridViewElementStates.Selected) <= 0) {
                customMessage = new CustomMessage("Select a file filter on the table below first.", "Information", "Information");
                CustomDialog.ShowCustomDialog(customMessage, Handle);
                return;
            }
            if (txtFilterName.Text.Equals("")) {
                customMessage = new CustomMessage("Invalid file filter name.", "Information", "Information");
                CustomDialog.ShowCustomDialog(customMessage, Handle);
                return;
            }

            int idFileFilter = Convert.ToInt32(dgvFileFilters.SelectedRows[0].Cells[0].Value);

            customMessage = new CustomMessage("Update selected file filter?\nSelected: " + txtFilterName.Text, "Confirmation", "confirmation");
            if (CustomDialog.ShowCustomDialog(customMessage, Handle) == DialogResult.Cancel) { return; }

            FileFilter fileFilter = new FileFilter(idFileFilter, txtFileName.Text,txtFilterNotes.Text);

            customMessage = sqlite.UpdateFileFilter(fileFilter);
            CustomDialog.ShowCustomDialog(customMessage, Handle);

            RefreshFileFilters();
            SelectCorrectRow(idFileFilter);
        }
        private void btnDeleteFileFilter_Click(object sender, EventArgs e) {
            CustomMessage customMessage;
            if (dgvFileFilters.GetCellCount(DataGridViewElementStates.Selected) <= 0) {
                customMessage = new CustomMessage("Select a filter on the table below first.", "Information", "Information");
                CustomDialog.ShowCustomDialog(customMessage, Handle);
                return;
            }

            int idFileFilter = Convert.ToInt32(dgvFileFilters.SelectedRows[0].Cells[0].Value);
            int selectedRow = Convert.ToInt32(dgvFileFilters.SelectedRows[0].Index);

            customMessage = new CustomMessage("Delete selected file filter?\nSelected: " + txtFilterName.Text, "Confirmation", "confirmation");
            if (CustomDialog.ShowCustomDialog(customMessage, Handle) == DialogResult.Cancel) { return; }

            FileFilter fileFilter = new FileFilter(idFileFilter, txtFileName.Text, txtFilterNotes.Text);

            customMessage = sqlite.DeleteFileFilter(fileFilter);
            CustomDialog.ShowCustomDialog(customMessage, Handle);

            dgvFileFilters.Rows.RemoveAt(selectedRow);
            RefreshFileFilterFiles(0);
            RefreshFileFilterExtensions(0);
            btnClearFields_Click(sender, e);
        }

        private void lsbFiles_SelectedIndexChanged(object sender, EventArgs e) {
            if (lsbFiles.SelectedIndex < 0) {
                txtFileName.Text = "";
                return;
            }
            txtFileName.Text = lsbFiles.Text;
        }

        private void lsbFileExtensions_SelectedIndexChanged(object sender, EventArgs e) {
            if (lsbFileExtensions.SelectedIndex < 0) {
                txtFileExtension.Text = "";
                return;
            }
            txtFileExtension.Text = lsbFileExtensions.Text;
        }

        private void lsbFileExtensions_DrawItem(object sender, DrawItemEventArgs e) {
            e.DrawBackground();

            bool isItemSelected = ((e.State & DrawItemState.Selected) == DrawItemState.Selected);
            int itemIndex = e.Index;
            if (itemIndex >= 0 && itemIndex < lsbFileExtensions.Items.Count) {
                Graphics g = e.Graphics;

                // Background Color
                SolidBrush backgroundColorBrush = new SolidBrush((isItemSelected) ? Color.FromArgb(153, 15, 15) : Color.FromArgb(31, 31, 31));
                g.FillRectangle(backgroundColorBrush, e.Bounds);

                // Set text color
                string itemText = ((DataRowView)lsbFileExtensions.Items[itemIndex])["Extension"].ToString();

                SolidBrush itemTextColorBrush =new SolidBrush(Color.White);
                g.DrawString(itemText, e.Font, itemTextColorBrush, lsbFileExtensions.GetItemRectangle(itemIndex).Location);

                // Clean up
                backgroundColorBrush.Dispose();
                itemTextColorBrush.Dispose();
            }

            e.DrawFocusRectangle();
        }

        private void lsbFiles_DrawItem(object sender, DrawItemEventArgs e) {
            e.DrawBackground();

            bool isItemSelected = ((e.State & DrawItemState.Selected) == DrawItemState.Selected);
            int itemIndex = e.Index;
            if (itemIndex >= 0 && itemIndex < lsbFiles.Items.Count) {
                Graphics g = e.Graphics;

                // Background Color
                SolidBrush backgroundColorBrush = new SolidBrush((isItemSelected) ? Color.FromArgb(153, 15, 15) : Color.FromArgb(31, 31, 31));
                g.FillRectangle(backgroundColorBrush, e.Bounds);

                // Set text color
                string itemText = ((DataRowView)lsbFiles.Items[itemIndex])["FileName"].ToString();

                SolidBrush itemTextColorBrush = new SolidBrush(Color.White);
                g.DrawString(itemText, e.Font, itemTextColorBrush, lsbFiles.GetItemRectangle(itemIndex).Location);

                // Clean up
                backgroundColorBrush.Dispose();
                itemTextColorBrush.Dispose();
            }

            e.DrawFocusRectangle();
        }
    }
}
