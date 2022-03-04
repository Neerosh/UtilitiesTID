using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;
using Utilities.Classes;

namespace Utilities.Forms
{
    public partial class FileWatcher : Form {
        private DataTable dtWatcherHistory;
        private CustomMessage customMessage;
        private readonly FolderPicker folderPicker = new FolderPicker();
        private FileSystemWatcher fileWatcher = null;
        private CheckedListBox fileWatcherFilters = new CheckedListBox();

        public FileWatcher() {
            InitializeComponent();
            LoadFileFilterSelection();
            LoadDataGridViewWatcher();

            fileWatcherFilters.Items.Add(chkFilterAttributes);
            fileWatcherFilters.Items.Add(chkFilterCreationTime);
            fileWatcherFilters.Items.Add(chkFilterDirectoryName);
            fileWatcherFilters.Items.Add(chkFilterFileName);
            fileWatcherFilters.Items.Add(chkFilterLastAccess);
            fileWatcherFilters.Items.Add(chkFilterLastWrite);
            fileWatcherFilters.Items.Add(chkFilterSecurity);
            fileWatcherFilters.Items.Add(chkFilterSize);
        }

        private void UpdateCheckedFilters(CheckBox checkBox) {
            int index = fileWatcherFilters.Items.IndexOf(checkBox);
            if (checkBox.Checked) {
                fileWatcherFilters.SetItemChecked(index, true);
            } else {
                fileWatcherFilters.SetItemChecked(index, false);
            }
        }

        private void LoadDataGridViewWatcher() {
            dtWatcherHistory = new DataTable();
            dtWatcherHistory.Columns.Add("ID");
            dtWatcherHistory.Columns.Add("File/Folder Path");
            dtWatcherHistory.Columns.Add("Action");
            dtWatcherHistory.Columns.Add("Renamed File/Folder Path");

            dgvWatchHistory.DataSource = dtWatcherHistory;
            dgvWatchHistory.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvWatchHistory.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvWatchHistory.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvWatchHistory.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        private void LoadFileFilterSelection() {
            SQLite sqlite = new SQLite();
            DataTable dt = sqlite.SelectAllFileFilters();
            dt.Rows.Add(0, "All Files");
            cboFileFilter.DataSource = dt;
            cboFileFilter.ValueMember = "Id";
            cboFileFilter.DisplayMember = "Name";
            dt.DefaultView.Sort = "Name";
        }

        private void RefreshWatcherHistory() {
            dgvWatchHistory.AutoResizeColumn(0, DataGridViewAutoSizeColumnMode.DisplayedCells);
            dgvWatchHistory.AutoResizeColumn(1, DataGridViewAutoSizeColumnMode.DisplayedCells);
            dgvWatchHistory.AutoResizeColumn(2, DataGridViewAutoSizeColumnMode.DisplayedCells);
            dgvWatchHistory.AutoResizeColumn(3, DataGridViewAutoSizeColumnMode.DisplayedCells);
            dgvWatchHistory.Refresh();
        }

        #region File Watcher
        private void StartFileWatcher() {
            BtnWatcher.Text = "Stop File Watcher";
            lblFileWatcherStatus.Visible = true;
            string folderPath = txtWatcherFolder.Text;
            int selectedFileFilter = Convert.ToInt32(cboFileFilter.SelectedValue);
            bool includeSubdirectories = chkSubdirectories.Checked;

            fileWatcher = new FileSystemWatcher();
            fileWatcher.Path = folderPath;
            fileWatcher.IncludeSubdirectories = includeSubdirectories;
            fileWatcher.NotifyFilter -= NotifyFilters.LastWrite | NotifyFilters.FileName | NotifyFilters.DirectoryName;
            //checked filters---------------------------------------------------------
            if (chkFilterAttributes.Checked)
                fileWatcher.NotifyFilter |= NotifyFilters.Attributes;
            if (chkFilterCreationTime.Checked)
                fileWatcher.NotifyFilter |= NotifyFilters.CreationTime;
            if (chkFilterDirectoryName.Checked)
                fileWatcher.NotifyFilter |= NotifyFilters.DirectoryName;
            if (chkFilterFileName.Checked)
                fileWatcher.NotifyFilter |= NotifyFilters.FileName;
            if (chkFilterLastAccess.Checked)
                fileWatcher.NotifyFilter |= NotifyFilters.LastAccess;
            if (chkFilterLastWrite.Checked)
                fileWatcher.NotifyFilter |= NotifyFilters.LastWrite;
            if (chkFilterSecurity.Checked)
                fileWatcher.NotifyFilter |= NotifyFilters.Security;
            if (chkFilterSize.Checked)
                fileWatcher.NotifyFilter |= NotifyFilters.Size;
            //end checked filters---------------------------------------------------------

            SQLite sqlite = new SQLite();
            int idFileFilter = selectedFileFilter;
            if (idFileFilter > 0) {
                List<FileFilterCondition> filterConditions = new List<FileFilterCondition>();
                filterConditions = sqlite.SelectFileFilterConditions(idFileFilter, "");
                foreach (FileFilterCondition Filtercondition in filterConditions) {
                    switch (Filtercondition.Type) {
                        case "Name Ends With":
                            fileWatcher.Filters.Add("*" + Filtercondition.Condition.ToString());
                            break;
                        case "Name is Exactly":
                            fileWatcher.Filters.Add(Filtercondition.Condition.ToString());
                            break;
                        case "Name Contains":
                            fileWatcher.Filters.Add("*" + Filtercondition.Condition.ToString() + "*");
                            break;
                    }
                }
            } else {
                fileWatcher.Filter = "*.*";
            }
            fileWatcher.Created += FileWatcherOnCreated_Changed_Deleted;
            fileWatcher.Changed += FileWatcherOnCreated_Changed_Deleted;
            fileWatcher.Deleted += FileWatcherOnCreated_Changed_Deleted;
            fileWatcher.Renamed += FileWatcherOnRenamed;
            fileWatcher.EnableRaisingEvents = true;
        }

        private void StopFileWatcher() {
            fileWatcher.EnableRaisingEvents = false;
            lblFileWatcherStatus.Visible = false;
            fileWatcher.Dispose();
            fileWatcher = null;
            BtnWatcher.Text = "Start File Watcher";
        }

        private void FileWatcherOnCreated_Changed_Deleted(object sender, FileSystemEventArgs e) {
            dtWatcherHistory.Rows.Add(dgvWatchHistory.Rows.Count + 1, e.FullPath, e.ChangeType, "");
            dgvWatchHistory.Invoke(new Action(() => { RefreshWatcherHistory(); }));
        }
        private void FileWatcherOnRenamed(object sender, RenamedEventArgs e) {
            dtWatcherHistory.Rows.Add(dgvWatchHistory.Rows.Count + 1, e.OldFullPath, e.ChangeType, e.FullPath);
            dgvWatchHistory.Invoke(new Action(() => { RefreshWatcherHistory(); }));
        }
        #endregion File Watcher


        private void btnClearHistory_Click(object sender, EventArgs e) {
            customMessage = new CustomMessage("Clearing watcher history. Are you sure ?", "Confirmation", "confirmation");
            DialogResult result = CustomDialog.ShowCustomDialog(customMessage, this);
            if (result == DialogResult.Cancel) {
                return;
            }
            dtWatcherHistory.Clear();
            RefreshWatcherHistory();
        }
        private void BtnFolderBrowser_Click(object sender, EventArgs e) {
            if (folderPicker.ShowDialog(Handle, false) == true) {
                txtWatcherFolder.Text = folderPicker.ResultPath;
            }
        }
        private void BtnWatcher_Click(object sender, EventArgs e) {
            if (fileWatcher != null) {
                customMessage = new CustomMessage("Stopping file watcher. Are you sure ?", "Confirmation", "confirmation");
                DialogResult result = CustomDialog.ShowCustomDialog(customMessage, this);
                if (result == DialogResult.Cancel) {
                    return;
                }
                StopFileWatcher();
            } else {
                if (txtWatcherFolder.Text.Equals("")) {
                    customMessage = new CustomMessage("Select a folder first.", "Infomation", "information");
                    CustomDialog.ShowCustomDialog(customMessage, this);
                    return;
                }
                if (fileWatcherFilters.CheckedItems.Count == 0) {
                    customMessage = new CustomMessage("Select at least one filter of Notify Changes On.", "Infomation", "information");
                    CustomDialog.ShowCustomDialog(customMessage, this);
                    return;
                }
                

                customMessage = new CustomMessage("Starting file watcher. Are you sure ?\nFolder to watch: " + txtWatcherFolder.Text, "Confirmation", "confirmation");
                DialogResult result = CustomDialog.ShowCustomDialog(customMessage, this);
                if (result == DialogResult.Cancel) {
                    return;
                }
                StartFileWatcher();
            }
        }
        private void ChkFilter_CheckStateChanged(object sender, EventArgs e) {
            UpdateCheckedFilters((CheckBox)sender);
        }

        private void FileWatcher_FormClosing(object sender, FormClosingEventArgs e) {
            if (fileWatcher != null) {
                StopFileWatcher();
            }
        }
    }
}
