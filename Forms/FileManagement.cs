using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilities.Classes;

namespace Utilities.Forms
{
    public partial class FileManagement : Form
    {
        public FileManagement() {
            InitializeComponent();
            folderPicker.InputPath = @"C:\";
            cboOrderBy.SelectedItem = "Descending";
            cboOrderField.SelectedItem = "Filename";
            lblProgressPercent.Text = "0%";
            LoadFileFilterSelection();
        }

        private FolderPicker folderPicker = new FolderPicker();
        private Task task;
        public readonly string[] arrayForbiddenCombinations = new string[] { ").", "_.", "_03.", "old.", "old--.", "copia.", "copy." };

        private void LoadFileFilterSelection() {
            SQLite sqlite = new SQLite();
            DataTable dt = sqlite.SelectAllFileFilters();
            dt.Rows.Add(0, "All Files");
            cboFileFilter.DataSource = dt;
            cboFileFilter.ValueMember = "Id";
            cboFileFilter.DisplayMember = "Name";
            dt.DefaultView.Sort = "Name";
        }

        #region MouseHover
        private void MouseHoverDynamicFields(string button, string action) {
            List<Control> controlList = new List<Control>();
            switch (button) {
                case "Delete Duplicate Files":
                    controlList.Add(lblToMoveFiles);
                    controlList.Add(txtToFolder);
                    controlList.Add(btnToBrowser);
                    break;
                case "Copy Files":
                    controlList.Add(chkSubFolders);
                    break;
                case "Move Files":
                    controlList.Add(chkSubFolders);
                    break;
            }

            foreach (Control c in controlList) {
                if (action.Equals("Hide")) {
                    c.Hide();
                    continue;
                }
                c.Show();

            }
        }
        private void BtnDeleteDuplicate_MouseHover(object sender, EventArgs e) {
            MouseHoverDynamicFields("Delete Duplicate Files", "Hide");
        }
        private void BtnDeleteDuplicate_MouseLeave(object sender, EventArgs e) {
            MouseHoverDynamicFields("Delete Duplicate Files", "Show");
        }
        private void BtnMoveFiles_MouseHover(object sender, EventArgs e) {
            MouseHoverDynamicFields("Move Files", "Hide");
        }
        private void BtnMoveFiles_MouseLeave(object sender, EventArgs e) {
            MouseHoverDynamicFields("Move Files", "Show");
        }
        private void BtnCopyFiles_MouseHover(object sender, EventArgs e) {
            MouseHoverDynamicFields("Copy Files", "Hide");
        }
        private void BtnCopyFiles_MouseLeave(object sender, EventArgs e) {
            MouseHoverDynamicFields("Copy Files", "Show");
        }
        #endregion

        #region File Management
        private void UpdateProgress(int percent) {
            pgsFileManagement.Invoke(new MethodInvoker(delegate { pgsFileManagement.Value = percent; }));
            lblProgressPercent.Invoke(new MethodInvoker(delegate { lblProgressPercent.Text = pgsFileManagement.Value + " %"; }));
        }
        private void WriteLog(string text) {
            txtLogProcess.Invoke(new MethodInvoker(delegate {
                if (txtLogProcess.Text.Equals("")) {
                    txtLogProcess.ForeColor = Color.FromArgb(68, 204, 0);
                    txtLogProcess.AppendText(text);
                    txtLogProcess.SelectionStart = txtLogProcess.Text.Length;
                    txtLogProcess.ScrollToCaret();
                    return;
                }

                txtLogProcess.AppendText("\r\n" + text);

                if (text.StartsWith("Error:")) {
                    txtLogProcess.ForeColor = Color.Yellow;
                }

            }));

        }
        private async Task TaskFileManagement(string action) {
            if (!action.Equals("Move") && !action.Equals("Copy") && !action.Equals("DeleteDuplicated")) { return; }

            string orderBy, orderProperty, fromFolder, toFolder;
            bool checkSubDirectories;
            int maxPercent, idFileFilter;
            FileInfo[] directoryFiles;
            List<GroupFileDetails> listGroupedFiles = new List<GroupFileDetails>();
            CustomMessage customMessage = new CustomMessage();
            IntPtr handle = this.Handle;
            DialogResult result = 0;

            orderBy = cboOrderBy.SelectedItem.ToString();
            orderProperty = cboOrderField.SelectedItem.ToString();
            fromFolder = txtFromFolder.Text;
            toFolder = txtToFolder.Text;
            idFileFilter = Convert.ToInt32(cboFileFilter.SelectedValue);
            checkSubDirectories = chkSubFolders.Checked;

            txtLogProcess.Clear();
            UpdateProgress(0);
            WriteLog("Starting...");
            await Task.Run(() => {
                try {
                    if (Directory.Exists(fromFolder) == false) {
                        throw new Exception("From folder must be a valid folder path");
                    }

                    switch (action) {
                        case "Move":
                            if (Directory.Exists(toFolder) == false) {
                                throw new Exception("To folder must be a valid folder path");
                            }

                            directoryFiles = GetDirectoryFiles(fromFolder, idFileFilter, orderProperty, orderBy);
                            if (directoryFiles.Length == 0) {
                                WriteLog("No files to " + action);
                                return;
                            }

                            customMessage = new CustomMessage("Moving files. Are you sure ?\nFrom: " + fromFolder + "\nTo: " + toFolder, "Confirmation", "confirmation");
                            result = CustomDialog.ShowCustomDialog(customMessage, handle);
                            if (result == DialogResult.Cancel) {
                                WriteLog("Process Aborted");
                                return;
                            }
                            MoveFiles(directoryFiles, toFolder);
                            break;
                        case "Copy":
                            if (Directory.Exists(toFolder) == false) {
                                throw new Exception("To folder must be a valid folder path");
                            }

                            directoryFiles = GetDirectoryFiles(fromFolder, idFileFilter, orderProperty, orderBy);
                            if (directoryFiles.Length == 0) {
                                WriteLog("No files to " + action);
                                return;
                            }

                            customMessage = new CustomMessage("Copying files. Are you sure?\nFrom: " + fromFolder + "\nTo: " + toFolder, "Confirmation", "confirmation");
                            result = CustomDialog.ShowCustomDialog(customMessage, handle);
                            if (result == DialogResult.Cancel) {
                                WriteLog("Process Aborted");
                                return;
                            }
                            CopyFiles(directoryFiles, toFolder);
                            break;
                        case "DeleteDuplicated":
                            List<DirectoryInfo> directories = GetDirectories(fromFolder, checkSubDirectories);
                            if (directories.Count == 0) {
                                WriteLog("No files found");
                                return;
                            }

                            customMessage = new CustomMessage("Deleting duplicated files on:\n" + fromFolder + "\nAre you sure?", "Confirmation", "confirmation");
                            result = CustomDialog.ShowCustomDialog(customMessage, handle);
                            if (result == DialogResult.Cancel) {
                                WriteLog("Process Aborted");
                                return;
                            }

                            for (int i = 0; i < directories.Count; i++) {
                                WriteLog("\r\nGrouping files from: " + directories[i].FullName);
                                maxPercent = (i + 1) * 50 / directories.Count;
                                directoryFiles = GetDirectoryFiles(directories[i].FullName, idFileFilter, orderProperty, orderBy);
                                GroupDirectoryFilesByHash(listGroupedFiles, directoryFiles, maxPercent);
                            }

                            if (listGroupedFiles.Count == 0) {
                                WriteLog("No files found.");
                                return;
                            }
                            DeleteDuplicatedFiles(listGroupedFiles);
                            break;
                    }
                } catch (Exception e) {
                    WriteLog("Error: " + e.Message);
                }
            });
        }
        private List<DirectoryInfo> GetDirectories(string folder, bool checkSubDirectories) {
            DirectoryInfo[] directoryFiles;
            List<DirectoryInfo> returnList = new List<DirectoryInfo> { new DirectoryInfo(folder) };
            if (checkSubDirectories) {
                directoryFiles = new DirectoryInfo(folder).GetDirectories().OrderByDescending(directory => directory.Name).ToArray();

                foreach (DirectoryInfo dinfo in directoryFiles) {
                    returnList.Add(dinfo);
                }
            }
            return returnList;
        }
        private FileInfo[] GetDirectoryFiles(string folder, int IdFileFilter, string orderProperty, string orderBy) {
            SQLite sqlite = new SQLite();
            List<FileInfo> listFiles = new List<FileInfo>();
            List<FileFilterCondition> filterConditions = new List<FileFilterCondition>();
            IEnumerable<FileInfo> files = new DirectoryInfo(folder).EnumerateFiles();

            if (IdFileFilter > 0) {
                filterConditions = sqlite.SelectFileFilterConditions(IdFileFilter, "");
            }
            switch (orderProperty + ";" + orderBy) {
                case "Filename;Descending":
                    files = new DirectoryInfo(folder).EnumerateFiles().OrderByDescending(file => file.Name);
                    break;
                case "Filename;Ascending":
                    files = new DirectoryInfo(folder).EnumerateFiles().OrderBy(file => file.Name);
                    break;
                case "Creation Time;Descending":
                    files = new DirectoryInfo(folder).EnumerateFiles().OrderByDescending(file => file.CreationTime);
                    break;
                case "Creation Time;Ascending":
                    files = new DirectoryInfo(folder).EnumerateFiles().OrderBy(file => file.CreationTime);
                    break;
                default:
                    files = new DirectoryInfo(folder).EnumerateFiles().OrderBy(file => file.Name);
                    break;
            }

            if (files.Count() <= 0) {
                return new FileInfo[0];
            }

            if (filterConditions.Count > 0) {
                FileInfo[] directoryFiles = null;
                foreach (FileFilterCondition condition in filterConditions) {
                    directoryFiles = null;
                    switch (condition.Type) {
                        case "Name Ends With":
                            directoryFiles = files.Where(file => file.Name.ToLower().EndsWith(condition.Condition)).ToArray();
                            break;
                        case "Name is Exactly":
                            directoryFiles = files.Where(file => file.Name.ToLower().Equals(condition.Condition)).ToArray();
                            break;
                        case "Name Contains":
                            directoryFiles = files.Where(file => file.Name.ToLower().Contains(condition.Condition)).ToArray();
                            break;

                    }
                    if (directoryFiles.Length > 0 && directoryFiles != null) {
                        listFiles.AddRange(directoryFiles);
                    }
                }
                listFiles.DistinctBy(file => file.Name);
            } else {
                listFiles.AddRange(files);
            }

            return listFiles.ToArray();
        }
        private void GroupDirectoryFilesByHash(List<GroupFileDetails> listGroupedFiles, FileInfo[] directoryFiles, int maxPercent) {
            string fileHash;
            bool hashExist;

            for (int i = 0; i < directoryFiles.Length; i++) {
                try {
                    hashExist = false;
                    using (FileStream fs = new FileStream(directoryFiles[i].FullName, FileMode.Open, FileAccess.Read)) {
                        fileHash = BitConverter.ToString(SHA1.Create().ComputeHash(fs));

                        for (int l = 0; l < listGroupedFiles.Count; l++) {
                            if (listGroupedFiles[l].GetFile(0).FileHash == fileHash) {
                                hashExist = true;
                                listGroupedFiles[l].AddFileDetail(new FileDetails(directoryFiles[i].FullName, fileHash));
                                break;
                            }
                        }

                        if (hashExist == false) {
                            listGroupedFiles.Add(new GroupFileDetails(new FileDetails(directoryFiles[i].FullName, fileHash)));
                        }
                    }
                    UpdateProgress((i + 1) * maxPercent / directoryFiles.Length);
                } catch (Exception) {
                    WriteLog("Error: " + directoryFiles[i].FullName);
                }
            }

        }
        private void DeleteDuplicatedFiles(List<GroupFileDetails> listGroupedFiles) {
            bool contain;
            double totalBytesDeletedFiles = 0;
            int filesDeleted = 0;
            WriteLog("Deleting files...");
            for (int group = 0; group < listGroupedFiles.Count; group++) {
                for (int list = 0; list < listGroupedFiles[group].ListCount(); list++) {
                    FileInfo file = new FileInfo(listGroupedFiles[group].GetFile(list).FileName);

                    //If string does not contain array
                    contain = false;
                    foreach (string str in arrayForbiddenCombinations) {
                        if (file.Name.ToLower().Contains(str)) {
                            contain = true;
                            break;
                        }
                    }
                    if (list == 0 && contain == false) { continue; }

                    //get total size of duplicate files
                    totalBytesDeletedFiles += file.Length;
                    WriteLog("Deleting: " + file.FullName);

                    try {
                        File.Delete(file.FullName);
                    } catch (Exception e) { WriteLog("Error: " + e.Message); }
                    filesDeleted += 1;
                }
                UpdateProgress(((group + 1) * 50 / listGroupedFiles.Count) + 50);
            }

            if (filesDeleted == 0) {
                WriteLog("No files to delete");
                return;
            }
            WriteLog("----------------------------------------");
            WriteLog("Total Duplicate Files - " + filesDeleted);
            WriteLog("Total Space Free Up - " + Math.Round((totalBytesDeletedFiles / 1000000), 2).ToString() + " MB");
        }
        private void MoveFiles(FileInfo[] directoryFiles, string toFolder) {
            double totalBytesFiles = 0;
            int FilesToMove = directoryFiles.Length;
            int filesMoved = 0;

            WriteLog("Moving files...");
            for (int l = 0; l < FilesToMove; l++) {

                WriteLog("Moving: " + directoryFiles[l].FullName);

                try {
                    File.Move(directoryFiles[l].FullName, toFolder + "\\" + directoryFiles[l].Name);
                    totalBytesFiles += directoryFiles[l].Length;
                    filesMoved += 1;
                } catch (Exception e) { WriteLog("Error: " + e.Message); }

                UpdateProgress((l + 1) * 100 / FilesToMove);
            }
            WriteLog("----------------------------------------");
            WriteLog("Total Moved Files - " + filesMoved);
            WriteLog("Total Size - " + Math.Round((totalBytesFiles / 1000000), 2).ToString() + " MB");
        }
        private void CopyFiles(FileInfo[] directoryFiles, string toFolder) {
            double totalBytesFiles = 0;
            int FilesToMove = directoryFiles.Length;
            int filesCopied = 0;

            WriteLog("Copying files...");

            for (int l = 0; l < FilesToMove; l++) {
                WriteLog("Copying: " + directoryFiles[l].FullName);
                

                try {
                    File.Copy(directoryFiles[l].FullName, toFolder + "\\" + directoryFiles[l].Name, true);//copy and replace if prompted
                    totalBytesFiles += directoryFiles[l].Length;
                    filesCopied += 1;
                } catch (Exception e) { WriteLog("Error: " + e.Message); }

                UpdateProgress((l + 1) * 100 / FilesToMove);
            }
            WriteLog("----------------------------------------");
            WriteLog("Total Copied Files - " + filesCopied);
            WriteLog("Total Size - " + Math.Round((totalBytesFiles / 1000000), 2).ToString() + " MB");
        }

        private async void BtnDeleteDuplicate_Click(object sender, EventArgs e) {
            if (task == null || task.IsCompleted) {
                task = TaskFileManagement("DeleteDuplicated");
                await task;
                return;
            }
        }
        private async void BtnMoveFiles_Click(object sender, EventArgs e) {
            if (task == null || task.IsCompleted) {
                task = TaskFileManagement("Move");
                await task;
                return;
            }
        }
        private async void BtnCopyFiles_Click(object sender, EventArgs e) {
            if (task == null || task.IsCompleted) {
                task = TaskFileManagement("Copy");
                await task;
                return;
            }
        }

        private void BtnFromBrowser_Click(object sender, EventArgs e) {
            if (folderPicker.ShowDialog(Handle, false) == true) {
                txtFromFolder.Text = folderPicker.ResultPath;
            }
        }
        private void BtnToBrowser_Click(object sender, EventArgs e) {
            if (folderPicker.ShowDialog(Handle, false) == true) {
                txtToFolder.Text = folderPicker.ResultPath;
            }

        }
        #endregion File Management
    }
}
