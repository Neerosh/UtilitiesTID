using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;
using Utilities;
using Utilities.Classes;
using Utilities.Forms;

namespace Teste
{
    public partial class Main : Form
    {
        private readonly CultureInfo culture = new CultureInfo("en-US");
        private readonly SQLite sqlite = new SQLite();
        private CommonOpenFileDialog folderPicker = new CommonOpenFileDialog();
        private Task task;
        public readonly string[] arrayForbiddenCombinations = new string[] { ").", "_.", "_03.", "old.", "old--.", "copia.", "copy." };

        public Main() {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e) {
            mnsMenuBar.Renderer = new ToolStripProfessionalRenderer(new MenuColors());
            cboOrderBy.SelectedItem = "Descending";
            cboOrderField.SelectedItem = "Filename";
            cboFileExtension.SelectedItem = "TID";
            lblProgressPercent.Text = "0%";
            folderPicker.IsFolderPicker = true;
            CultureInfo.DefaultThreadCurrentCulture = culture;
            CultureInfo.DefaultThreadCurrentUICulture = culture;
        }

        #region Menu
        private void MenuScriptWriter_Click(object sender, EventArgs e) {
            ScriptWriter scriptWriter = new ScriptWriter();
            scriptWriter.ShowDialog();
        }
        private void MenuNotes_Click(object sender, EventArgs e) {
            Notes notes = new Notes(arrayForbiddenCombinations);
            notes.ShowDialog();
        }

        private void MenuItemCodeToClipboard_Click(object sender, EventArgs e) {
            CodeToClipboard codeToClipboard = new CodeToClipboard();
            codeToClipboard.ShowDialog();
        }
        private void MenuItemManageCode_Click(object sender, EventArgs e) {
            CodeManage codeToClipboardMaintenance = new CodeManage();
            codeToClipboardMaintenance.ShowDialog();
        }
        #endregion

        #region Clarion Date / Time Conversion
        private void ConvertDate(string toFormat) {
            DateTime dateField, dateClarion = DateTime.ParseExact("01/01/1801", "dd/MM/yyyy", CultureInfo.InvariantCulture);
            string dateFormat;
            long dateValueClarion;

            if (toFormat.Equals("ClarionDate")) {
                dateFormat = txtDate.Text;
                try {
                    dateField = DateTime.ParseExact(dateFormat, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                } catch (Exception) {
                    dateField = DateTime.ParseExact("01/01/1801", "dd/MM/yyyy", CultureInfo.InvariantCulture);
                }

                if (Int32.Parse(dateFormat.Substring(6, 4)) <= 1801) {
                    txtClarionDate.Text = "0000004";
                    txtDate.Text = "01/01/1801";
                } else {
                    dateValueClarion = (dateField - dateClarion).Days + 4;
                    txtClarionDate.Text = dateValueClarion.ToString();
                    while (!txtClarionDate.MaskCompleted) {
                        txtClarionDate.Text = "0" + txtClarionDate.Text;
                    }
                }
            } else {
                dateValueClarion = Int32.Parse(txtClarionDate.Text);

                if (dateValueClarion <= 4) {
                    txtClarionDate.Text = "0000004";
                    txtDate.Text = "01/01/1801";
                } else {
                    dateClarion = dateClarion.AddDays(dateValueClarion - 4);
                    txtDate.Text = dateClarion.ToString("dd/MM/yyyy");
                }
            }
        }
        private void ConvertTime(string toFormat) {
            string timeFormat;
            long timeMinutes, timeHours;
            long timeValueClarion = 0;

            if (toFormat.Equals("ClarionTime")) {
                if (txtTime.Text.Length == 0) { return; }
                timeFormat = txtTime.Text.Replace(":", "");
                if (!timeFormat.Equals("0000")) {
                    timeMinutes = (Int32.Parse(timeFormat.Substring(0, 2))) * 60 + Int32.Parse(timeFormat.Substring(2, 2));
                    timeValueClarion += (timeMinutes * 6000) + 1;
                } else {
                    timeValueClarion = 4;
                }

                txtClarionTime.Text = timeValueClarion.ToString();
                while (!txtClarionTime.MaskCompleted) {
                    txtClarionTime.Text = "0" + txtClarionTime.Text;
                }
            } else {
                if (txtClarionTime.Text.Length == 0) { return; }
                timeFormat = "00:00";
                timeValueClarion = Int32.Parse(txtClarionTime.Text);

                if (timeValueClarion <= 4) {
                    txtTime.Text = timeFormat;
                    timeValueClarion = 4;
                    txtClarionTime.Text = timeValueClarion.ToString();
                    while (!txtClarionTime.MaskCompleted) {
                        txtClarionTime.Text = "0" + txtClarionTime.Text;
                    }
                    return;
                }

                timeHours = 0;
                if (timeValueClarion > 360000) {
                    timeHours = timeValueClarion / 360000;
                }

                timeFormat = timeHours.ToString();

                if (timeHours <= 9) {
                    timeFormat = "0" + timeHours.ToString();
                }

                timeMinutes = (timeValueClarion - (timeHours * 360000)) / 6000;

                if (timeMinutes <= 9) {
                    timeFormat += ":0" + timeMinutes.ToString();
                } else {
                    timeFormat += ":" + timeMinutes.ToString();
                }

                txtTime.Text = timeFormat;
            }
        }

        private void TxtTime_Validated(object sender, EventArgs e) {
            string fieldText = txtTime.Text;
            while (!txtTime.MaskCompleted) {
                fieldText = "0" + fieldText;
                txtTime.Text = fieldText;
            }
            ConvertTime("ClarionTime");
        }
        private void TxtClarionTime_Validated(object sender, EventArgs e) {
            string fieldText = txtClarionTime.Text;
            while (!txtClarionTime.MaskCompleted) {
                fieldText = "0" + fieldText;
                txtClarionTime.Text = fieldText;
            }
            ConvertTime("Time");
        }
        private void TxtDate_Validated(object sender, EventArgs e) {
            if (!txtDate.MaskCompleted) {
                txtDate.Text = "01/01/1801";
            }
            ConvertDate("ClarionDate");
        }
        private void TxtClarionDate_Validated(object sender, EventArgs e) {
            string fieldText = txtClarionDate.Text;
            while (!txtClarionDate.MaskCompleted) {
                fieldText = "0" + fieldText;
                txtClarionDate.Text = fieldText;
            }
            ConvertDate("Date");

        }
        #endregion

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
                    txtLogProcess.ForeColor = Color.Lime;
                    txtLogProcess.AppendText(text);
                    return;
                }

                txtLogProcess.AppendText("\r\n" + text);

                if (text.StartsWith("Error:")) {
                    txtLogProcess.ForeColor = Color.Yellow;
                }

            }));

        }
        private async Task TaskFileManagement(string action) {
            if (!action.Equals("Move") && !action.Equals("Copy") && !action.Equals("DeleteDuplicates")) { return; }

            string orderBy, orderProperty, fromFolder, toFolder, filterExtension;
            bool checkSubDirectories;
            int maxPercent;
            FileInfo[] directoryFiles;
            List<GroupFileDetails> listGroupedFiles = new List<GroupFileDetails>();

            orderBy = cboOrderBy.SelectedItem.ToString();
            orderProperty = cboOrderField.SelectedItem.ToString();
            fromFolder = txtFromFolder.Text;
            toFolder = txtToFolder.Text;
            filterExtension = cboFileExtension.SelectedItem.ToString();
            checkSubDirectories = chkSubFolders.Checked;

            txtLogProcess.Clear();
            UpdateProgress(0);
            WriteLog("Starting...");
            await Task.Run(() => {
                try {
                    if (Directory.Exists(fromFolder) == false) {
                        throw new Exception("From folder must be a valid folder path");
                    }

                    if (action.Equals("Move") || action.Equals("Copy")) {

                        if (Directory.Exists(toFolder) == false) {
                            throw new Exception("To folder must be a valid folder path");
                        }

                        directoryFiles = GetDirectoryFiles(fromFolder, filterExtension, orderProperty, orderBy);

                        if (directoryFiles.Length == 0) {
                            WriteLog("No files to " + action);
                            return;
                        }

                        if (action.Equals("Move")) {
                            MoveFiles(directoryFiles, toFolder);
                            return;
                        }

                        CopyFiles(directoryFiles, toFolder);
                        return;
                    }

                    List<DirectoryInfo> directories = GetDirectories(fromFolder, checkSubDirectories);
                    if (directories.Count == 0) {
                        WriteLog("No files found");
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
                    //skip first file from each group then delete the rest
                    DeleteDuplicatedFiles(listGroupedFiles);

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
            FileInfo[] directoryFiles;
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
                task = TaskFileManagement("DeleteDuplicates");
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
            if (folderPicker.ShowDialog() == CommonFileDialogResult.Ok) {
                txtFromFolder.Text = Path.GetFullPath(folderPicker.FileName);
            }
        }
        private void BtnToBrowser_Click(object sender, EventArgs e) {
            if (folderPicker.ShowDialog() == CommonFileDialogResult.Ok) {
                txtToFolder.Text = Path.GetFullPath(folderPicker.FileName);
            }
        }
        #endregion File Management

    }
}
