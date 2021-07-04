using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Utilities.Forms {
    public partial class ScriptWriter : Form {

        private readonly CommonOpenFileDialog folderPickerWriter = new CommonOpenFileDialog();
        private Task task;

        public ScriptWriter() {
            InitializeComponent();
        }

        #region Script Writer
        private async Task TaskGenerateSQL(string scriptType) {
            if (!scriptType.Equals("Unified") && !scriptType.Equals("Regular")) { return; }

            string procedureName, folderScript, folderSQL;

            procedureName = txtProcedureName.Text;
            folderScript = txtScriptFolder.Text + "\\" + txtScriptName.Text + ".sql";
            folderSQL = txtFolderSQL.Text;

            string directoryScript = folderScript.Substring(0, folderScript.LastIndexOf('\\'));

            await Task.Run(() => {
                try {
                    if (Directory.Exists(directoryScript) == false) {
                        Directory.CreateDirectory(directoryScript);
                    }
                    if (File.Exists(folderScript)) {
                        File.Delete(folderScript);
                    }

                    if (scriptType.Equals("Regular")) {
                        if (txtScriptName.Text.Equals("")) {
                            folderScript = txtScriptFolder.Text + "\\RegularScript.sql";
                        }
                        GenerateRegularScript(folderSQL, folderScript);
                        return;
                    }

                    if (txtProcedureName.Text.Equals("")) {
                        procedureName = "UnifiedScript";
                    }
                    if (txtScriptName.Text.Equals("")) {
                        folderScript = txtScriptFolder.Text + "\\UnifiedScript.sql";
                    }
                    GenerateUnifiedScript(folderSQL, folderScript, procedureName);

                } catch (Exception e) {
                    MessageBox.Show("Error: " + e.Message);
                }
            });
        }
        private void GenerateUnifiedScript(string folderSQL, string folderScript, string procedureName) {
            Byte[] line;
            string scriptText;

            using (FileStream fileStream = File.Create(folderScript)) {

                scriptText = "\r\n IF EXISTS (SELECT 1 FROM sys.procedures WHERE name = '" + procedureName + "')" +
                                "\r\n BEGIN" +
                                "\r\n    DROP PROCEDURE [" + procedureName + "]" +
                                "\r\n END" +
                                "\r\n" +
                                "\r\n USE [master]" +
                                "\r\n GO" +
                                "\r\n CREATE PROCEDURE [dbo].[" + procedureName + "]" +
                                "\r\n AS BEGIN " +
                                "\r\n SET NOCOUNT ON" +
                                "\r\n DECLARE @detach int ," +
                                "\r\n @mdfExist int ," +
                                "\r\n @ldfExist int ," +
                                "\r\n @bakExist int ;";

                line = new UTF8Encoding(true).GetBytes(scriptText);
                fileStream.Write(line, 0, line.Length);

                for (int c = 1; c <= 30; c++) {
                    if (c < 10) {
                        WriteUnifiedCode("TID_EMP0" + c, fileStream, folderSQL);
                        continue;
                    }
                    WriteUnifiedCode("TID_EMP" + c, fileStream, folderSQL);
                }

                WriteUnifiedCode("PORTALVENDAS", fileStream, folderSQL);
                WriteUnifiedCode("TID_AUDITORIA", fileStream, folderSQL);
                WriteUnifiedCode("TID_ECOMMERCE", fileStream, folderSQL);
                WriteUnifiedCode("TID_EXETPS", fileStream, folderSQL);
                WriteUnifiedCode("TID_NUVEMSHOP", fileStream, folderSQL);
                WriteUnifiedCode("TID_WEB", fileStream, folderSQL);
                WriteUnifiedCode("TID_TEMP", fileStream, folderSQL);
                WriteUnifiedCode("TIDDF", fileStream, folderSQL);
                WriteUnifiedCode("TIDMOBILE", fileStream, folderSQL);
                WriteUnifiedCode("TIDMOBILE_DEACO", fileStream, folderSQL);
                WriteUnifiedCode("TIDVENDAS", fileStream, folderSQL);
                WriteUnifiedCode("TIDWEB", fileStream, folderSQL);
                WriteUnifiedCode("WEBCENTER", fileStream, folderSQL);
                WriteUnifiedCode("WEBCENTER_BRUTAL", fileStream, folderSQL);

                scriptText = "\r\n SET NOCOUNT OFF" +
                            "\r\n END" +
                            "\r\n GO";
                line = new UTF8Encoding(true).GetBytes(scriptText);
                fileStream.Write(line, 0, line.Length);

            }
            MessageBox.Show("Script generated: " + folderScript);

        }
        private void WriteUnifiedCode(string database, FileStream fileStream, string folderSQL) {
            string fileText;
            Byte[] line;
            if (database == "TID_TEMP") {
                fileText = "\r\n IF NOT EXISTS (SELECT name FROM master.sys.databases WHERE name = N'" + database + "')" +
                           "\r\n BEGIN" +
                           "\r\n    CREATE DATABASE " + database + "" +
                           "\r\n END";
                line = new UTF8Encoding(true).GetBytes(fileText);
                fileStream.Write(line, 0, line.Length);
                return;
            }
            fileText = "\r\n SET @detach = 0;" +
                        "\r\n SET @mdfExist = 0;" +
                        "\r\n SET @ldfExist = 0;" +
                        "\r\n SET @bakExist = 0;" +
                        "\r\n IF EXISTS (SELECT name FROM master.sys.databases WHERE name = N'" + database + "')" +
                        "\r\n BEGIN" +
                        "\r\n    EXEC master.dbo.sp_detach_db @dbname = N'" + database + "' " +
                        "\r\n    SET @detach = 1;" +
                        "\r\n END" +
                        //Check for _log files
                        "\r\n" +
                        "\r\n ELSE" +
                        "\r\n BEGIN" +
                        "\r\n    Exec master..xp_fileexist'" + folderSQL + "\\" + database + "_log.mdf',@mdfExist OUT" +
                        "\r\n    IF @mdfExist = 1" +
                        "\r\n    BEGIN" +
                        "\r\n       PRINT 'Rename the file: " + folderSQL + "\\" + database + "_log.mdf'" +
                        "\r\n       PRINT 'and execute the procedure again'" +
                        "\r\n       SET @mdfExist = 0;" +
                        "\r\n    END" +
                        "\r\n    Exec master..xp_fileexist'" + folderSQL + "\\" + database + "_log.ldf',@ldfExist OUT" +
                        "\r\n    IF @ldfExist = 1" +
                        "\r\n    BEGIN" +
                        "\r\n       PRINT 'Rename the file: " + folderSQL + "\\" + database + "_log.ldf'" +
                        "\r\n       PRINT 'and execute the procedure again'" +
                        "\r\n       SET @ldfExist = 0;" +
                        "\r\n    END" +
                        //ATTACH
                        "\r\n" +
                        "\r\n    ELSE" +
                        "\r\n    BEGIN" +
                        "\r\n       Exec master..xp_fileexist'" + folderSQL + "\\" + database + ".mdf',@mdfExist OUT" +
                        "\r\n       IF @mdfExist = 1" +
                        "\r\n       BEGIN" +
                        "\r\n    	   Exec master..xp_fileexist'" + folderSQL + "\\" + database + ".ldf',@ldfExist OUT" +
                        "\r\n          IF @ldfExist = 1" +
                        "\r\n          BEGIN" +
                        "\r\n             CREATE DATABASE [" + database + "] ON" +
                        "\r\n             ( FILENAME = N'" + folderSQL + "\\" + database + ".mdf' )," +
                        "\r\n             ( FILENAME = N'" + folderSQL + "\\" + database + ".ldf' )" +
                        "\r\n             FOR ATTACH" +
                        "\r\n          END" +
                        "\r\n       END" +
                        //BACKUP
                        "\r\n" +
                        "\r\n       ELSE" +
                        "\r\n       BEGIN" +
                        "\r\n          Exec master..xp_fileexist'" + folderSQL + "\\" + database + ".bak',@bakExist OUT" +
                        "\r\n          IF @bakExist = 1" +
                        "\r\n          BEGIN" +
                        "\r\n             RESTORE DATABASE [" + database + "] FROM  " +
                        "\r\n             DISK = N'" + folderSQL + "\\" + database + ".bak' WITH FILE = 1," +
                        "\r\n             MOVE N'" + database + "'" +
                        "\r\n             TO N'" + folderSQL + "\\" + database + ".mdf'," +
                        "\r\n             MOVE N'" + database + "_log'" +
                        "\r\n             TO N'" + folderSQL + "\\" + database + ".ldf'," +
                        "\r\n             NOUNLOAD, REPLACE, STATS = 100" +
                        "\r\n          END" +
                        "\r\n       END" +
                        "\r\n    END" +
                        "\r\n END" +
                        //RESULT
                        "\r\n" +
                        "\r\n IF @detach = 1" +
                        "\r\n BEGIN" +
                        "\r\n     PRINT 'Database " + database + " detached'" +
                        "\r\n END" +
                        "\r\n IF @bakExist = 1" +
                        "\r\n BEGIN" +
                        "\r\n     PRINT 'Database " + database + " restored'" +
                        "\r\n END" +
                        "\r\n IF @mdfExist = 1 AND @ldfExist = 1" +
                        "\r\n BEGIN" +
                        "\r\n     PRINT 'Database " + database + " attached'" +
                        "\r\n END";
            line = new UTF8Encoding(true).GetBytes(fileText);
            fileStream.Write(line, 0, line.Length);
        }
        private void GenerateRegularScript(string folderSQL, string folderScript) {
            Byte[] line;
            String[] procedures = { "AttachTID", "DetachTID", "RestoreTID" };
            string scriptText;

            using (FileStream fileStream = File.Create(folderScript)) {
                for (int i = 0; i < procedures.Length; i++) {

                    scriptText = "\r\n IF EXISTS (SELECT 1 FROM sys.procedures WHERE name = '" + procedures[i] + "')" +
                                    "\r\n BEGIN" +
                                    "\r\n    DROP PROCEDURE [" + procedures[i] + "]" +
                                    "\r\n END" +
                                    "\r\n" +
                                    "\r\n USE [master]" +
                                    "\r\n GO" +
                                    "\r\n CREATE PROCEDURE [dbo].[" + procedures[i] + "]" +
                                    "\r\n AS BEGIN " +
                                    "\r\n SET NOCOUNT ON" +
                                    "\r\n DECLARE @detach int ," +
                                    "\r\n @mdfExist int ," +
                                    "\r\n @ldfExist int ," +
                                    "\r\n @bakExist int ;"; ;
                    switch (procedures[i]) {
                        case "Attach":
                            scriptText += "\r\n DECLARE @mdfExist int ," +
                                            "\r\n @ldfExist int ;";
                            break;
                        case "Detach":
                            scriptText += "\r\n DECLARE @detach int;";
                            break;
                        case "Restore":
                            scriptText += "\r\n DECLARE @bakExist int ;";
                            break;
                    }

                    line = new UTF8Encoding(true).GetBytes(scriptText);
                    fileStream.Write(line, 0, line.Length);
                    procedures[i] = procedures[i].Substring(0, procedures[i].Length - 3);

                    WriteRegularCode("PORTALVENDAS", folderSQL, fileStream, procedures[i]);
                    WriteRegularCode("TID_AUDITORIA", folderSQL, fileStream, procedures[i]);
                    WriteRegularCode("TID_ECOMMERCE", folderSQL, fileStream, procedures[i]);
                    WriteRegularCode("TID_EXETPS", folderSQL, fileStream, procedures[i]);
                    WriteRegularCode("TID_NUVEMSHOP", folderSQL, fileStream, procedures[i]);
                    WriteRegularCode("TID_WEB", folderSQL, fileStream, procedures[i]);
                    WriteRegularCode("TID_TEMP", folderSQL, fileStream, procedures[i]);
                    WriteRegularCode("TIDDF", folderSQL, fileStream, procedures[i]);
                    WriteRegularCode("TIDMOBILE", folderSQL, fileStream, procedures[i]);
                    WriteRegularCode("TIDMOBILE_DEACO", folderSQL, fileStream, procedures[i]);
                    WriteRegularCode("TIDVENDAS", folderSQL, fileStream, procedures[i]);
                    WriteRegularCode("TIDWEB", folderSQL, fileStream, procedures[i]);
                    WriteRegularCode("WEBCENTER", folderSQL, fileStream, procedures[i]);
                    WriteRegularCode("WEBCENTER_BRUTAL", folderSQL, fileStream, procedures[i]);

                    for (int c = 1; c <= 30; c++) {
                        if (c < 10) {
                            WriteRegularCode("TID_EMP0" + c, folderSQL, fileStream, procedures[i]);
                        } else {
                            WriteRegularCode("TID_EMP" + c, folderSQL, fileStream, procedures[i]);
                        }
                    }
                    scriptText = "\r\n SET NOCOUNT OFF" +
                                 "\r\n END" +
                                 "\r\n GO" +
                                 "\r\n ";
                    line = new UTF8Encoding(true).GetBytes(scriptText);
                    fileStream.Write(line, 0, line.Length);
                }
            }
            MessageBox.Show("Script generated:\n" + folderScript);
        }
        private void WriteRegularCode(string database, string folderSQL, FileStream fileStream, string action) {
            string fileText = "";
            Byte[] line;
            if (database == "TID_TEMP") {
                fileText = "\r\n    IF NOT EXISTS (SELECT name FROM master.sys.databases WHERE name = N'" + database + "')" +
                           "\r\n    BEGIN" +
                           "\r\n        CREATE DATABASE " + database + "" +
                           "\r\n    END";
                line = new UTF8Encoding(true).GetBytes(fileText);
                fileStream.Write(line, 0, line.Length);
                return;
            }
            switch (action) {
                case "Detach":
                    fileText = "\r\n   SET @detach = 0;" +
                                "\r\n   IF EXISTS (SELECT name FROM master.sys.databases WHERE name = N'" + database + "')" +
                                "\r\n   BEGIN" +
                                "\r\n       EXEC master.dbo.sp_detach_db @dbname = N'" + database + "' " +
                                "\r\n       SET @detach = 1;" +
                                "\r\n   END" +
                                "\r\n   IF @detach = 1" +
                                "\r\n   BEGIN" +
                                "\r\n       PRINT 'Database " + database + " detached'" +
                                "\r\n   END";
                    break;
                case "Attach":
                    fileText = "\r\n   SET @mdfExist = 0;" +
                                "\r\n   SET @ldfExist = 0;" +
                                "\r\n   Exec master..xp_fileexist'" + folderSQL + "\\" + database + ".mdf',@mdfExist OUT" +
                                "\r\n   IF @mdfExist = 1" +
                                "\r\n   BEGIN" +
                                "\r\n       Exec master..xp_fileexist'" + folderSQL + "\\" + database + ".ldf',@ldfExist OUT" +
                                "\r\n       IF @ldfExist = 1" +
                                "\r\n       BEGIN" +
                                "\r\n           CREATE DATABASE [" + database + "] ON" +
                                "\r\n           ( FILENAME = N'" + folderSQL + "\\" + database + ".mdf' )," +
                                "\r\n           ( FILENAME = N'" + folderSQL + "\\" + database + ".ldf' )" +
                                "\r\n           FOR ATTACH" +
                                "\r\n       END" +
                                "\r\n   END" +
                                "\r\n   IF @mdfExist = 1 AND @ldfExist = 1" +
                                "\r\n   BEGIN" +
                                "\r\n       PRINT 'Database " + database + " attached'" +
                                "\r\n   END";
                    break;
                case "Restore":
                    fileText = "\r\n   SET @bakExist = 0;" +
                                "\r\n   Exec master..xp_fileexist'" + folderSQL + "\\" + database + ".bak',@bakExist OUT" +
                                "\r\n   IF @bakExist = 1" +
                                "\r\n   BEGIN" +
                                "\r\n       RESTORE DATABASE [" + database + "] FROM  " +
                                "\r\n       DISK = N'" + folderSQL + "\\" + database + ".bak' WITH FILE = 1," +
                                "\r\n       MOVE N'" + database + "'" +
                                "\r\n       TO N'" + folderSQL + "\\" + database + ".mdf'," +
                                "\r\n       MOVE N'" + database + "_log'" +
                                "\r\n       TO N'" + folderSQL + "\\" + database + ".ldf'," +
                                "\r\n       NOUNLOAD, REPLACE, STATS = 10" +
                                "\r\n   END" +
                                "\r\n   IF @bakExist = 1" +
                                "\r\n   BEGIN" +
                                "\r\n       PRINT 'Database " + database + " restored'" +
                                "\r\n   END";
                    break;
            }
            line = new UTF8Encoding(true).GetBytes(fileText);
            fileStream.Write(line, 0, line.Length);
        }
        #endregion Script Generator

        private void MouseHoverDynamicFields(string button, string action) {
            List<Control> controlList = new List<Control>();
            switch (button) {
                case "Generate Regular Script":
                    controlList.Add(lblProcedureName);
                    controlList.Add(txtProcedureName);
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

        private void ScriptWriter_Load(object sender, EventArgs e) {
            folderPickerWriter.IsFolderPicker = true;
        }

        private void BtnPathFolderSQLBrowser_Click(object sender, EventArgs e) {
            if (folderPickerWriter.ShowDialog() == CommonFileDialogResult.Ok) {
                txtFolderSQL.Text = Path.GetFullPath(folderPickerWriter.FileName);
            }
        }
        private void BtnPathScriptBrowser_Click(object sender, EventArgs e) {
            if (folderPickerWriter.ShowDialog() == CommonFileDialogResult.Ok) {
                txtScriptFolder.Text = Path.GetFullPath(folderPickerWriter.FileName);
            }
        }

        private async void BtnScriptUnified_Click(object sender, EventArgs e) {
            if (task == null || task.IsCompleted) {
                task = TaskGenerateSQL("Unified");
                await task;
                return;
            }
        }
        private async void BtnScriptRegular_Click(object sender, EventArgs e) {
            if (task == null || task.IsCompleted) {
                task = TaskGenerateSQL("Regular");
                await task;
            }
        }

        private void BtnScriptRegular_MouseHover(object sender, EventArgs e) {
            MouseHoverDynamicFields("Generate Regular Script", "Hide");
        }
        private void BtnScriptRegular_MouseLeave(object sender, EventArgs e) {
            MouseHoverDynamicFields("Generate Regular Script", "Show");
        }
    }
}
