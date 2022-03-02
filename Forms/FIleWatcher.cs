using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;
using Utilities.Classes;

namespace Utilities.Forms
{
    public partial class FileWatcher : Form
    {
        private DataTable dtWatcherHistory;
        private CustomMessage customMessage;
        private readonly FolderPicker folderPicker = new FolderPicker();
        private FileSystemWatcher fileWatcher = new FileSystemWatcher();

        public FileWatcher() {
            InitializeComponent();
            LoadFileFilterSelection();
            LoadDataGridViewWatcher();
        }

        private void LoadDataGridViewWatcher() {
            dtWatcherHistory = new DataTable();
            dtWatcherHistory.Columns.Add("ID");
            dtWatcherHistory.Columns.Add("File/Folder Path");
            dtWatcherHistory.Columns.Add("File/Folder Name");
            dtWatcherHistory.Columns.Add("Action");
            dtWatcherHistory.Columns.Add("New File/Folder Name");

            dgvWatchHistory.DataSource = dtWatcherHistory;
            //dgvWatchHistory.Columns[0].Visible = false;
            dgvWatchHistory.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvWatchHistory.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvWatchHistory.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvWatchHistory.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvWatchHistory.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
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

            fileWatcher.Path = folderPath;
            fileWatcher.IncludeSubdirectories = includeSubdirectories;
            fileWatcher.NotifyFilter = NotifyFilters.CreationTime | NotifyFilters.Size | NotifyFilters.Attributes |
                                       NotifyFilters.FileName | NotifyFilters.DirectoryName | NotifyFilters.LastWrite;

            SQLite sqlite = new SQLite();
            int idFileFilter = selectedFileFilter;
            if (idFileFilter > 0) {
                List<FileFilterCondition> filterConditions = new List<FileFilterCondition>();
                filterConditions = sqlite.SelectFileFilterConditions(idFileFilter, "");
                foreach (FileFilterCondition condition in filterConditions) {
                    switch (condition.Type) {
                        case "Name Ends With":
                            fileWatcher.Filters.Add("*" + condition.ToString());
                            break;
                        case "Name is Exactly":
                            fileWatcher.Filters.Add(condition.ToString());
                            break;
                        case "Name Contains":
                            fileWatcher.Filters.Add("*" + condition.ToString() + "*");
                            break;
                    }
                }
            } else {
                fileWatcher.Filter = "*.*";
            }
            fileWatcher.Created += FileWatcherOnCreated;
            fileWatcher.Changed += FileWatcherOnChanged;
            fileWatcher.Deleted += FileWatcherOnDeleted;
            fileWatcher.Renamed += FileWatcherOnRenamed;
            fileWatcher.EnableRaisingEvents = true;
        }

        private void StopFileWatcher() {
            fileWatcher.EnableRaisingEvents = false;
            lblFileWatcherStatus.Visible = false;
            fileWatcher.Dispose();
            BtnWatcher.Text = "Start File Watcher";
        }

        private void FileWatcherOnCreated(object sender, FileSystemEventArgs e) {
            dtWatcherHistory.Rows.Add(dgvWatchHistory.Rows.Count + 1, e.FullPath, e.Name, "Created", "");
            dgvWatchHistory.Invoke(new Action(() => { RefreshWatcherHistory(); }));
        }
        private void FileWatcherOnChanged(object sender, FileSystemEventArgs e) {
            if (e.ChangeType != WatcherChangeTypes.Changed) {
                return;
            }
            dtWatcherHistory.Rows.Add(dgvWatchHistory.Rows.Count + 1, e.FullPath, e.Name, "Changed", "");
            dgvWatchHistory.Invoke(new Action(() => { RefreshWatcherHistory(); }));
        }
        private void FileWatcherOnDeleted(object sender, FileSystemEventArgs e) {
            dtWatcherHistory.Rows.Add(dgvWatchHistory.Rows.Count + 1, e.FullPath, e.Name, "Deleted", "");
            dgvWatchHistory.Invoke(new Action(() => { RefreshWatcherHistory(); }));
        }
        private void FileWatcherOnRenamed(object sender, RenamedEventArgs e) {
            dtWatcherHistory.Rows.Add(dgvWatchHistory.Rows.Count + 1, e.OldFullPath, e.OldName, "Renamed", e.FullPath);
            dgvWatchHistory.Invoke(new Action(() => { RefreshWatcherHistory(); }));
        }
        # endregion File Watcher

        private void BtnWatcher_Click(object sender, EventArgs e) {
            if (!fileWatcher.Path.Equals("")) {
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

                customMessage = new CustomMessage("Starting file watcher. Are you sure ?\nFolder to watch: " + txtWatcherFolder.Text, "Confirmation", "confirmation");
                DialogResult result = CustomDialog.ShowCustomDialog(customMessage, this);
                if (result == DialogResult.Cancel) {
                    return;
                }
                StartFileWatcher();
            }
        }

        private void BtnFolderBrowser_Click(object sender, EventArgs e) {
            if (folderPicker.ShowDialog(Handle, false) == true) {
                txtWatcherFolder.Text = folderPicker.ResultPath;
            }
        }

        private void FileWatcher_FormClosing(object sender, FormClosingEventArgs e) {
            if (!fileWatcher.Path.Equals("")) {
                StopFileWatcher();
            }
        }
    }
}
