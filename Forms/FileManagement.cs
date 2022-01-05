using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Teste;
using Utilities.Classes;

namespace Utilities.Forms
{
    public partial class FileManagement : Form {
        public FileManagement() {
            InitializeComponent();
            folderPicker.InputPath = @"C:\";
            cboOrderBy.SelectedItem = "Descending";
            cboOrderField.SelectedItem = "Filename";
            cboFileExtension.SelectedItem = "TID";
            lblProgressPercent.Text = "0%";
        }

        private FolderPicker folderPicker = new FolderPicker();
        private Task task;
        public readonly string[] arrayForbiddenCombinations = new string[] { ").", "_.", "_03.", "old.", "old--.", "copia.", "copy." };

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

            string orderBy, orderProperty, fromFolder, toFolder, filterExtension;
            bool checkSubDirectories;
            int maxPercent;
            FileInfo[] directoryFiles;
            List<GroupFileDetails> listGroupedFiles = new List<GroupFileDetails>();
            CustomMessage customMessage = new CustomMessage();
            DialogResult result = 0;

            orderBy = cboOrderBy.SelectedItem.ToString();
            orderProperty = cboOrderField.SelectedItem.ToString();
            fromFolder = txtFromFolder.Text;
            toFolder = txtToFolder.Text;
            filterExtension = cboFileExtension.SelectedItem.ToString();
            checkSubDirectories = chkSubFolders.Checked;
            IntPtr handle = this.Handle;
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

                            directoryFiles = GetDirectoryFiles(fromFolder, filterExtension, orderProperty, orderBy);
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

                            directoryFiles = GetDirectoryFiles(fromFolder, filterExtension, orderProperty, orderBy);
                            if (directoryFiles.Length == 0) {
                                WriteLog("No files to " + action);
                                return;
                            }

                            customMessage = new CustomMessage("Copying files. Are you sure?\nFrom: " + fromFolder + "\nTo: " + toFolder + , "Confirmation", "confirmation");
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
                                directoryFiles = GetDirectoryFiles(directories[i].FullName, filterExtension, orderProperty, orderBy);
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
        private FileInfo[] GetDirectoryFiles(string folder, string filterExtension, string orderProperty, string orderBy) {
            FileInfo[] directoryFiles = null;
            List<FileInfo> listFiles = new List<FileInfo>();
            String[] filterExtensions;
            String[] filterName;

            switch (filterExtension) {
                case "*.dll or *.exe":
                    filterExtensions = new String[] { ".dll", ".exe" };
                    filterName = null;
                    break;
                case "*.exe":
                    filterExtensions = new String[] { ".exe" };
                    filterName = null;
                    break;
                case "*.dll":
                    filterExtensions = new String[] { ".dll" };
                    filterName = null;
                    break;
                case "*.tps":
                    filterExtensions = new String[] { ".tps" };
                    filterName = null;
                    break;
                case "TID":
                    filterExtensions = new String[] { ".dll", ".exe", "conexao.tps" };
                    filterName = new String[] { "conexao.tps" };
                    break;
                default:
                    filterExtensions = null;
                    filterName = null;
                    break;
            }


            switch (orderProperty + ";" + orderBy) {
                case "Filename;Descending":
                    if (filterExtensions == null && filterName == null) {
                        directoryFiles = new DirectoryInfo(folder).EnumerateFiles().OrderByDescending(file => file.Name).ToArray();
                        listFiles.AddRange(directoryFiles);
                        break;
                    }

                    if (filterExtensions != null) {
                        foreach (string extension in filterExtensions) {
                            directoryFiles = new DirectoryInfo(folder).EnumerateFiles().OrderByDescending(file => file.Name)
                                                .Where(file => file.Name.Substring(file.Name.LastIndexOf(".")).ToLower() == extension).ToArray();
                            listFiles.AddRange(directoryFiles);
                        }
                    }

                    if (filterName != null) {
                        foreach (string name in filterName) {
                            directoryFiles = new DirectoryInfo(folder).EnumerateFiles().OrderByDescending(file => file.Name)
                                                .Where(file => file.Name.ToLower().Equals(name)).ToArray();
                            listFiles.AddRange(directoryFiles);
                        }
                    }

                    break;

                case "Filename;Ascending":
                    if (filterExtensions == null && filterName == null) {
                        directoryFiles = new DirectoryInfo(folder).EnumerateFiles().OrderBy(file => file.Name).ToArray();
                        listFiles.AddRange(directoryFiles);
                        break;
                    }

                    if (filterExtensions != null) {
                        foreach (string extension in filterExtensions) {
                            directoryFiles = new DirectoryInfo(folder).EnumerateFiles().OrderBy(file => file.Name)
                                                .Where(file => file.Name.Substring(file.Name.LastIndexOf(".")).ToLower() == extension).ToArray();
                            listFiles.AddRange(directoryFiles);
                        }
                    }

                    if (filterName != null) {
                        foreach (string name in filterName) {
                            directoryFiles = new DirectoryInfo(folder).EnumerateFiles().OrderBy(file => file.Name)
                                                .Where(file => file.Name.ToLower().Equals(name)).ToArray();
                            listFiles.AddRange(directoryFiles);
                        }
                    }

                    break;

                case "Creation Time;Descending":

                    if (filterExtensions == null && filterName == null) {
                        directoryFiles = new DirectoryInfo(folder).EnumerateFiles().OrderByDescending(file => file.CreationTime).ToArray();
                        listFiles.AddRange(directoryFiles);
                        break;
                    }

                    if (filterExtensions != null) {
                        foreach (string extension in filterExtensions) {
                            directoryFiles = new DirectoryInfo(folder).EnumerateFiles().OrderByDescending(file => file.CreationTime)
                                                .Where(file => file.Name.Substring(file.Name.LastIndexOf(".")).ToLower() == extension).ToArray();
                            listFiles.AddRange(directoryFiles);
                        }
                    }

                    if (filterName != null) {
                        foreach (string name in filterName) {
                            directoryFiles = new DirectoryInfo(folder).EnumerateFiles().OrderByDescending(file => file.CreationTime)
                                                .Where(file => file.Name.ToLower().Equals(name)).ToArray();
                            listFiles.AddRange(directoryFiles);
                        }
                    }

                    break;
                case "Creation Time;Ascending":

                    if (filterExtensions == null && filterName == null) {
                        directoryFiles = new DirectoryInfo(folder).EnumerateFiles().OrderBy(file => file.CreationTime).ToArray();
                        listFiles.AddRange(directoryFiles);
                        break;
                    }

                    if (filterExtensions != null) {
                        foreach (string extension in filterExtensions) {
                            directoryFiles = new DirectoryInfo(folder).EnumerateFiles().OrderBy(file => file.CreationTime)
                                                .Where(file => file.Name.Substring(file.Name.LastIndexOf(".")).ToLower() == extension).ToArray();
                            listFiles.AddRange(directoryFiles);
                        }
                    }

                    if (filterName != null) {
                        foreach (string name in filterName) {
                            directoryFiles = new DirectoryInfo(folder).EnumerateFiles().OrderBy(file => file.CreationTime)
                                                .Where(file => file.Name.ToLower().Equals(name)).ToArray();
                            listFiles.AddRange(directoryFiles);
                        }
                    }
                    break;

                default:

                    if (filterExtensions == null && filterName == null) {
                        directoryFiles = new DirectoryInfo(folder).EnumerateFiles().OrderBy(file => file.Name).ToArray();
                        listFiles.AddRange(directoryFiles);
                        break;
                    }

                    if (filterExtensions != null) {
                        foreach (string extension in filterExtensions) {
                            directoryFiles = new DirectoryInfo(folder).EnumerateFiles().OrderBy(file => file.Name)
                                                .Where(file => file.Name.Substring(file.Name.LastIndexOf(".")).ToLower() == extension).ToArray();
                            listFiles.AddRange(directoryFiles);
                        }
                    }

                    if (filterName != null) {
                        foreach (string name in filterName) {
                            directoryFiles = new DirectoryInfo(folder).EnumerateFiles().OrderBy(file => file.Name)
                                                .Where(file => file.Name.ToLower().Equals(name)).ToArray();
                            listFiles.AddRange(directoryFiles);
                        }
                    }

                    break;
            }
            if (listFiles.Count > 0) {

                return listFiles.ToArray();
            }
            return new FileInfo[0];
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

            WriteLog("Total duplicate files - " + filesDeleted);
            WriteLog("Total space free up by - " + Math.Round((totalBytesDeletedFiles / 1000000), 2).ToString() + " MB");
        }
        private void MoveFiles(FileInfo[] directoryFiles, string toFolder) {
            double totalBytesFiles = 0;
            int FilesToMove = directoryFiles.Length;

            WriteLog("Moving files...");
            for (int l = 0; l < FilesToMove; l++) {

                WriteLog("Moving: " + directoryFiles[l].FullName);
                totalBytesFiles += directoryFiles[l].Length;

                try {
                    File.Move(directoryFiles[l].FullName, toFolder + "\\" + directoryFiles[l].Name);
                } catch (Exception e) { WriteLog("Error: " + e.Message); }

                UpdateProgress((l + 1) * 100 / FilesToMove);
            }
        }
        private void CopyFiles(FileInfo[] directoryFiles, string toFolder) {
            double totalBytesFiles = 0;
            int FilesToMove = directoryFiles.Length;

            WriteLog("Copying files...");

            for (int l = 0; l < FilesToMove; l++) {
                WriteLog("Copying: " + directoryFiles[l].FullName);
                totalBytesFiles += directoryFiles[l].Length;

                try {
                    File.Copy(directoryFiles[l].FullName, toFolder + "\\" + directoryFiles[l].Name, true);//copy and replace if prompted
                } catch (Exception e) { WriteLog("Error: " + e.Message); }

                UpdateProgress((l + 1) * 100 / FilesToMove);
            }

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
            if (folderPicker.ShowDialog(Handle,false) == true) {
                txtFromFolder.Text = folderPicker.ResultPath;
            }
        }
        private void BtnToBrowser_Click(object sender, EventArgs e) {
            if (folderPicker.ShowDialog(Handle, false) == true) {
                txtToFolder.Text = folderPicker.ResultPath;
            }

        }
        #endregion File Management

        private void close_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
