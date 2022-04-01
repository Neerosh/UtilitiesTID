using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilities.Classes;

namespace Utilities.Forms
{
    public partial class ScriptWriter : Form {

        private readonly FolderPicker folderPicker = new FolderPicker();
        private Task taskRegularScript,taskUnifiedScript;

        public ScriptWriter() {
            InitializeComponent();
        }

        private void ScriptWriter_Load(object sender, EventArgs e) {
        }

        #region Mouse Hover
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
        private void BtnScriptRegular_MouseHover(object sender, EventArgs e) {
            MouseHoverDynamicFields("Generate Regular Script", "Hide");
        }
        private void BtnScriptRegular_MouseLeave(object sender, EventArgs e) {
            MouseHoverDynamicFields("Generate Regular Script", "Show");
        }
        #endregion

        #region Script Writer
        private bool AreFoldersValid() {
            CustomMessage customMessage = new CustomMessage();
            if (txtScriptFolder.Text.Equals("")) {
                customMessage = new CustomMessage("Script folder not selected", "Error Checking folders", "error");
                CustomDialog.ShowCustomDialog(customMessage, this);
                return false;
            }
            if (txtFolderSQL.Text.Equals("")) {
                customMessage = new CustomMessage("SQL folder not selected", "Error Checking folders", "error");
                CustomDialog.ShowCustomDialog(customMessage, this);
                return false;
            }
            return true;
        }

        private async Task GenerateUnifiedScript() {
            CustomMessage customMessage = new CustomMessage();

            if (!AreFoldersValid()) { return; }

            string procedureName, folderScript, folderSQL, directoryScript;

            procedureName = txtProcedureName.Text;
            folderScript = txtScriptFolder.Text + "\\" + txtScriptName.Text + ".sql";
            folderSQL = txtFolderSQL.Text;
            directoryScript = folderScript.Substring(0, folderScript.LastIndexOf('\\'));

            if (txtProcedureName.Text.Equals("")) { 
                procedureName = "UnifiedScript"; 
            }
            if (txtScriptName.Text.Equals("")) { 
                folderScript = txtScriptFolder.Text + "\\UnifiedScript.sql";
            }

            lblGeneratingUnifiedScript.Visible = true;
            await Task.Run(() => {
                Thread.Sleep(1000);
                if (Directory.Exists(directoryScript) == false) { Directory.CreateDirectory(directoryScript); }
                if (File.Exists(folderScript)) { File.Delete(folderScript); }

                WriteUnifiedScript(folderSQL, folderScript, procedureName);
            });
            lblGeneratingUnifiedScript.Visible = false;
        }
        private async Task GenerateRegularScript() {
            CustomMessage customMessage = new CustomMessage();

            if (!AreFoldersValid()) { return; }

            string folderScript, folderSQL, directoryScript;

            folderScript = txtScriptFolder.Text + "\\" + txtScriptName.Text + ".sql";
            folderSQL = txtFolderSQL.Text;
            directoryScript = folderScript.Substring(0, folderScript.LastIndexOf('\\'));

            if (txtScriptName.Text.Equals("")) {
                folderScript = txtScriptFolder.Text + "\\RegularScript.sql";
            }

            lblGeneratingRegularScript.Visible = true;

            await Task.Run(() => {
                Thread.Sleep(1000);
                if (Directory.Exists(directoryScript) == false) { Directory.CreateDirectory(directoryScript); }
                if (File.Exists(folderScript)) { File.Delete(folderScript); }

                WriteRegularScript(folderSQL, folderScript);
            });

            lblGeneratingRegularScript.Visible = false;
        }

        private void WriteUnifiedScript(string folderSQL, string folderScript, string procedureName) {
            Byte[] line;
            string scriptText;
            CustomMessage customMessage;

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
                            "\r\n @create int ," +
                            "\r\n @mdfExist int ," +
                            "\r\n @ldfExist int ," +
                            "\r\n @bakExist int ;";

                line = new UTF8Encoding(true).GetBytes(scriptText);
                fileStream.Write(line, 0, line.Length);


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
                            "\r\n @create int ," +
                            "\r\n @mdfExist int ," +
                            "\r\n @ldfExist int ," +
                            "\r\n @bakExist int ;";

                line = new UTF8Encoding(true).GetBytes(scriptText);
                fileStream.Write(line, 0, line.Length);

                for (int c = 1; c <= 30; c++) {
                    if (c < 10) {
                        WriteUnifiedScriptDatabase("TID_EMP0" + c, fileStream, folderSQL);
                        continue;
                    }
                    WriteUnifiedScriptDatabase("TID_EMP" + c, fileStream, folderSQL);
                }

                WriteUnifiedScriptDatabase("PORTALVENDAS", fileStream, folderSQL);
                WriteUnifiedScriptDatabase("TID_AUDITORIA", fileStream, folderSQL);
                WriteUnifiedScriptDatabase("TID_ATUALIZACAO", fileStream, folderSQL);
                WriteUnifiedScriptDatabase("TID_ECOMMERCE", fileStream, folderSQL);
                WriteUnifiedScriptDatabase("TID_EXETPS", fileStream, folderSQL);
                WriteUnifiedScriptDatabase("TID_NUVEMSHOP", fileStream, folderSQL);
                WriteUnifiedScriptDatabase("TID_WEB", fileStream, folderSQL);
                WriteUnifiedScriptDatabase("TID_TEMP", fileStream, folderSQL);
                WriteUnifiedScriptDatabase("TIDDF", fileStream, folderSQL);
                WriteUnifiedScriptDatabase("TIDMOBILE", fileStream, folderSQL);
                WriteUnifiedScriptDatabase("TIDMOBILE_DEACO", fileStream, folderSQL);
                WriteUnifiedScriptDatabase("TIDVENDAS", fileStream, folderSQL);
                WriteUnifiedScriptDatabase("TIDWEB", fileStream, folderSQL);
                WriteUnifiedScriptDatabase("WEBCENTER", fileStream, folderSQL);
                WriteUnifiedScriptDatabase("WEBCENTER_BRUTAL", fileStream, folderSQL);

                scriptText = "\r\n SET NOCOUNT OFF" +
                            "\r\n END" +
                            "\r\n GO";
                line = new UTF8Encoding(true).GetBytes(scriptText);
                fileStream.Write(line, 0, line.Length);

            }
            customMessage = new CustomMessage("Unified Script generated successfully: \n" + folderScript, "Success", "success");
            CustomDialog.ShowCustomDialog(customMessage, null);

        }
        private void WriteUnifiedScriptDatabase(string database, FileStream fileStream, string folderSQL) {
            string fileText;
            Byte[] line;
            fileText = "\r\n SET @detach = 0;" +
                        "\r\n SET @mdfExist = 0;" +
                        "\r\n SET @ldfExist = 0;" +
                        "\r\n SET @bakExist = 0;" +
                        "\r\n SET @create = 0;" +
                        "\r\n IF EXISTS (SELECT name FROM master.sys.databases WHERE name = N'" + database + "')" +
                        "\r\n BEGIN" +
                        "\r\n    ALTER DATABASE [" + database + "] SET OFFLINE" +
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
                        "\r\n             ALTER DATABASE [" + database + "] SET ONLINE" +
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
                        "\r\n             ALTER DATABASE [" + database + "] SET ONLINE" +
                        "\r\n          END" +
                        "\r\n       END" +
                        "\r\n    END" +
                        "\r\n END" +
                        //RESULTS
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

            if (database.Equals("TID_TEMP") || database.Equals("TIDDF") || database.Equals("TID_ATUALIZACAO")) {
                //CREATE
                fileText = "\r\n IF @detach = 0 AND (@mdfExist = 0 AND @ldfExist = 0) AND @bakExist = 0" +
                            "\r\n BEGIN" +
                            "\r\n    IF NOT EXISTS (SELECT name FROM master.sys.databases WHERE name = N'" + database + "')" +
                            "\r\n    BEGIN" +
                            "\r\n       SET @create = 1;" +
                            "\r\n       CREATE DATABASE  [" + database + "] ON  PRIMARY " +
                            "\r\n       (NAME = N'" + database + "', FILENAME = N'" + folderSQL + "\\" + database + ".mdf')" +
                            "\r\n       LOG ON" +
                            "\r\n       (NAME = N'" + database + "_log', FILENAME = N'" + folderSQL + "\\" + database + ".ldf')" +
                            "\r\n       ALTER DATABASE [" + database + "] SET ONLINE" +
                            "\r\n    END" +
                            "\r\n END" +
                            "\r\n IF @create = 1" +
                            "\r\n BEGIN" +
                            "\r\n     PRINT 'Database " + database + " created'" +
                            "\r\n END";
                line = new UTF8Encoding(true).GetBytes(fileText);
                fileStream.Write(line, 0, line.Length);
            }
        }

        private void WriteRegularScript(string folderSQL, string folderScript) {
            Byte[] line;
            String[] procedures = { "AttachTID", "DetachTID", "RestoreTID" };
            CustomMessage customMessage;
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
                                    "\r\n @create int ," +
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

                    WriteRegularScriptDatabase("PORTALVENDAS", folderSQL, fileStream, procedures[i]);
                    WriteRegularScriptDatabase("TID_ATUALIZACAO", folderSQL, fileStream, procedures[i]);
                    WriteRegularScriptDatabase("TID_AUDITORIA", folderSQL, fileStream, procedures[i]);
                    WriteRegularScriptDatabase("TID_ECOMMERCE", folderSQL, fileStream, procedures[i]);
                    WriteRegularScriptDatabase("TID_EXETPS", folderSQL, fileStream, procedures[i]);
                    WriteRegularScriptDatabase("TID_NUVEMSHOP", folderSQL, fileStream, procedures[i]);
                    WriteRegularScriptDatabase("TID_WEB", folderSQL, fileStream, procedures[i]);
                    WriteRegularScriptDatabase("TID_TEMP", folderSQL, fileStream, procedures[i]);
                    WriteRegularScriptDatabase("TIDDF", folderSQL, fileStream, procedures[i]);
                    WriteRegularScriptDatabase("TIDMOBILE", folderSQL, fileStream, procedures[i]);
                    WriteRegularScriptDatabase("TIDMOBILE_DEACO", folderSQL, fileStream, procedures[i]);
                    WriteRegularScriptDatabase("TIDVENDAS", folderSQL, fileStream, procedures[i]);
                    WriteRegularScriptDatabase("TIDWEB", folderSQL, fileStream, procedures[i]);
                    WriteRegularScriptDatabase("WEBCENTER", folderSQL, fileStream, procedures[i]);
                    WriteRegularScriptDatabase("WEBCENTER_BRUTAL", folderSQL, fileStream, procedures[i]);

                    for (int c = 1; c <= 30; c++) {
                        if (c < 10) {
                            WriteRegularScriptDatabase("TID_EMP0" + c, folderSQL, fileStream, procedures[i]);
                        } else {
                            WriteRegularScriptDatabase("TID_EMP" + c, folderSQL, fileStream, procedures[i]);
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
            customMessage = new CustomMessage("Regular Script generated successfully: \n" + folderScript, "Success", "success");
            CustomDialog.ShowCustomDialog(customMessage, null);
        }
        private void WriteRegularScriptDatabase(string database, string folderSQL, FileStream fileStream, string action) {
            string fileText = "";
            Byte[] line;
            switch (action) {
                case "Detach":
                    fileText = "\r\n   SET @detach = 0;" +
                                "\r\n   IF EXISTS (SELECT name FROM master.sys.databases WHERE name = N'" + database + "')" +
                                "\r\n   BEGIN" +
                                "\r\n       ALTER DATABASE [" + database + "] SET OFFLINE" +
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
                                "\r\n           ALTER DATABASE [" + database + "] SET ONLINE" +
                                "\r\n       END" +
                                "\r\n   END" +
                                "\r\n   IF @mdfExist = 1 AND @ldfExist = 1" +
                                "\r\n   BEGIN" +
                                "\r\n       PRINT 'Database " + database + " attached'" +
                                "\r\n   END";
                    if (database.Equals("TID_TEMP") || database.Equals("TIDDF") || database.Equals("TID_ATUALIZACAO")) {
                        fileText += "\r\n   SET @create = 0;" +
                                    "\r\n   IF @mdfExist = 0 AND @ldfExist = 0" +
                                    "\r\n   BEGIN" +
                                    "\r\n      IF NOT EXISTS (SELECT name FROM master.sys.databases WHERE name = N'" + database + "')" +
                                    "\r\n      BEGIN" +
                                    "\r\n         SET @create = 1;" +
                                    "\r\n         CREATE DATABASE  [" + database + "] ON  PRIMARY " +
                                    "\r\n         (NAME = N'" + database + "', FILENAME = N'" + folderSQL + "\\" + database + ".mdf')" +
                                    "\r\n         LOG ON" +
                                    "\r\n         (NAME = N'" + database + "_log', FILENAME = N'" + folderSQL + "\\" + database + ".ldf')" +
                                    "\r\n         ALTER DATABASE [" + database + "] SET ONLINE" +
                                    "\r\n      END" +
                                    "\r\n      IF @create = 1" +
                                    "\r\n      BEGIN" +
                                    "\r\n         PRINT 'Database " + database + " created'" +
                                    "\r\n      END" +
                                    "\r\n   END";

                    }
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
                                "\r\n       ALTER DATABASE [" + database + "] SET ONLINE" +
                                "\r\n   END" +
                                "\r\n   IF @bakExist = 1" +
                                "\r\n   BEGIN" +
                                "\r\n       PRINT 'Database " + database + " restored'" +
                                "\r\n   END";
                    if (database.Equals("TID_TEMP") || database.Equals("TIDDF") || database.Equals("TID_ATUALIZACAO")) {
                        fileText += "\r\n   SET @create = 0;" +
                                    "\r\n   IF @bakExist = 0" +
                                    "\r\n   BEGIN" +
                                    "\r\n      IF NOT EXISTS (SELECT name FROM master.sys.databases WHERE name = N'" + database + "')" +
                                    "\r\n      BEGIN" +
                                    "\r\n         SET @create = 1;" +
                                    "\r\n         CREATE DATABASE  [" + database + "] ON  PRIMARY " +
                                    "\r\n         (NAME = N'" + database + "', FILENAME = N'" + folderSQL + "\\" + database + ".mdf')" +
                                    "\r\n         LOG ON" +
                                    "\r\n         (NAME = N'" + database + "_log', FILENAME = N'" + folderSQL + "\\" + database + ".ldf')" +
                                    "\r\n         ALTER DATABASE [" + database + "] SET ONLINE" +
                                    "\r\n      END" +
                                    "\r\n      IF @create = 1" +
                                    "\r\n      BEGIN" +
                                    "\r\n         PRINT 'Database " + database + " created'" +
                                    "\r\n      END" +
                                    "\r\n   END";
                    }

                    break;
            }
            line = new UTF8Encoding(true).GetBytes(fileText);
            fileStream.Write(line, 0, line.Length);

        }
        #endregion Script Generator

        private void BtnPathFolderSQLBrowser_Click(object sender, EventArgs e) {
            if (folderPicker.ShowDialog(this.Handle, false) == true) {
                txtFolderSQL.Text = folderPicker.ResultPath;
            }
        }
        private void BtnPathScriptBrowser_Click(object sender, EventArgs e) {
            if (folderPicker.ShowDialog(this.Handle, false) == true) {
                txtScriptFolder.Text = folderPicker.ResultPath;
            }
        }

        private void BtnScriptUnified_Click(object sender, EventArgs e) {
            if (taskUnifiedScript == null || taskUnifiedScript.IsCompleted) {
                taskUnifiedScript = GenerateUnifiedScript();
            }
        }
        private void BtnScriptRegular_Click(object sender, EventArgs e) {
            if (taskRegularScript == null || taskRegularScript.IsCompleted) {
                taskRegularScript = GenerateRegularScript();
            }
        }

    }
}
