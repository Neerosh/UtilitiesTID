using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilities.Classes;

namespace Utilities.Forms
{
    public partial class ScriptWriter : Form {

        private readonly FolderPicker folderPicker = new FolderPicker();
        private Task task;

        public ScriptWriter() {
            InitializeComponent();
        }

        private void ScriptWriter_Load(object sender, EventArgs e) {
            folderPicker.InputPath = @"C:\";
            txtFunctionality.Text = "Unified Script:" +
                                    "\r\n   Generate an sql script that check and execute the suitable operation. Operation order detach>attach>restore." +
                                    "\r\nRegular Script:" +
                                    "\r\n   Generate an sql script it contains 3 procedures (DetachTID, AttachTID and RestoreTID) that check and execute the determined operation. ";
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
        private async Task TaskGenerateSQL(string scriptType) {
            CustomMessage customMessage = new CustomMessage();

            if (!scriptType.Equals("Unified") && !scriptType.Equals("Regular")) { return; }
            if (txtScriptFolder.Text.Equals("")) {
                customMessage = new CustomMessage("Script folder not selected", "Error Checking folders", "error");
                CustomDialog.ShowCustomDialog(customMessage, Handle);
                return; 
            }
            if (txtFolderSQL.Text.Equals("")) {
                customMessage = new CustomMessage("SQL folder not selected", "Error Checking folders", "error");
                CustomDialog.ShowCustomDialog(customMessage, Handle);
                return;
            }

            string procedureName, folderScript, folderSQL;

            procedureName = txtProcedureName.Text;
            folderScript = txtScriptFolder.Text + "\\" + txtScriptName.Text + ".sql";
            folderSQL = txtFolderSQL.Text;

            string directoryScript = folderScript.Substring(0, folderScript.LastIndexOf('\\'));
            IntPtr handle = this.Handle;

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
                        GenerateRegularScript(folderSQL, folderScript,handle);
                        return;
                    }

                    if (txtProcedureName.Text.Equals("")) {
                        procedureName = "UnifiedScript";
                    }
                    if (txtScriptName.Text.Equals("")) {
                        folderScript = txtScriptFolder.Text + "\\UnifiedScript.sql";
                    }
                    GenerateUnifiedScript(folderSQL, folderScript, procedureName,handle);
                } catch (Exception ex) {
                    customMessage = new CustomMessage(ex.Message, "Error","error");
                    CustomDialog.ShowCustomDialog(customMessage, handle);
                }
            });
        }
        private void GenerateUnifiedScript(string folderSQL, string folderScript, string procedureName, IntPtr handle) {
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
                        WriteUnifiedCode("TID_EMP0" + c, fileStream, folderSQL);
                        continue;
                    }
                    WriteUnifiedCode("TID_EMP" + c, fileStream, folderSQL);
                }

                WriteUnifiedCode("PORTALVENDAS", fileStream, folderSQL);
                WriteUnifiedCode("TID_AUDITORIA", fileStream, folderSQL);
                WriteUnifiedCode("TID_ATUALIZACAO", fileStream, folderSQL);
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
            customMessage = new CustomMessage("Unified Script generated successfully: \n" + folderScript, "Success", "success");
            CustomDialog.ShowCustomDialog(customMessage, Handle);

        }
        private void WriteUnifiedCode(string database, FileStream fileStream, string folderSQL) {
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

        private void GenerateUnifiedScript_test(string folderSQL, string folderScript, string procedureName, IntPtr handle) {
            Byte[] line;
            string scriptText;
            CustomMessage customMessage;

            using (FileStream fileStream = File.Create(folderScript)) {

                WriteUnifiedSubProcedure(fileStream, folderSQL, procedureName);

                scriptText = "\r\n IF EXISTS (SELECT 1 FROM sys.procedures WHERE name = '" + procedureName + "')" +
                            "\r\n BEGIN" +
                            "\r\n    DROP PROCEDURE [" + procedureName + "]" +
                            "\r\n END" +
                            "\r\n" +
                            "\r\n USE [master]" +
                            "\r\n GO" +
                            "\r\n CREATE PROCEDURE [dbo].[" + procedureName + "]" +
                            "\r\n AS BEGIN "+
                            "\r\n DECLARE @out int;";

                line = new UTF8Encoding(true).GetBytes(scriptText);
                fileStream.Write(line, 0, line.Length);

                for (int c = 1; c <= 30; c++) {
                    if (c < 10) {
                        WriteUnifiedScript_test(fileStream, procedureName,"TID_EMP0" + c);
                        continue;
                    }
                    WriteUnifiedScript_test(fileStream, procedureName, "TID_EMP" + c);
                }

                WriteUnifiedScript_test(fileStream, procedureName, "PORTALVENDAS");
                WriteUnifiedScript_test(fileStream, procedureName, "TID_AUDITORIA");
                WriteUnifiedScript_test(fileStream, procedureName, "TID_ATUALIZACAO");
                WriteUnifiedScript_test(fileStream, procedureName, "TID_ECOMMERCE");
                WriteUnifiedScript_test(fileStream, procedureName, "TID_EXETPS");
                WriteUnifiedScript_test(fileStream, procedureName, "TID_NUVEMSHOP");
                WriteUnifiedScript_test(fileStream, procedureName, "TID_WEB");
                WriteUnifiedScript_test(fileStream, procedureName, "TID_TEMP");
                WriteUnifiedScript_test(fileStream, procedureName, "TIDDF");
                WriteUnifiedScript_test(fileStream, procedureName, "TIDMOBILE");
                WriteUnifiedScript_test(fileStream, procedureName, "TIDMOBILE_DEACO");
                WriteUnifiedScript_test(fileStream, procedureName, "TIDVENDAS");
                WriteUnifiedScript_test(fileStream, procedureName, "TIDWEB");
                WriteUnifiedScript_test(fileStream, procedureName, "WEBCENTER");
                WriteUnifiedScript_test(fileStream, procedureName, "WEBCENTER_BRUTAL");

                scriptText = "\r\n SET NOCOUNT OFF" +
                            "\r\n END" +
                            "\r\n GO";
                line = new UTF8Encoding(true).GetBytes(scriptText);
                fileStream.Write(line, 0, line.Length);

            }
            customMessage = new CustomMessage("Unified Script generated successfully: " + folderScript, "Success", "success");
            CustomDialog.ShowCustomDialog(customMessage, Handle);
        }
        private void WriteUnifiedScript_test(FileStream fileStream, string procedureName, string database) {
            Byte[] line;
            string scriptText;

                scriptText = "\r\n EXEC " + procedureName + "Sub @database ='"+database+ "', @output = @out OUTPUT" +
                             "\r\n";

                line = new UTF8Encoding(true).GetBytes(scriptText);
                fileStream.Write(line, 0, line.Length);
            }
        private void WriteUnifiedSubProcedure(FileStream fileStream, string folderSQL, string procedureName) {
            Byte[] line;
            string scriptText;
            procedureName = procedureName+"Sub";

            scriptText = "\r\n IF EXISTS (SELECT 1 FROM sys.procedures WHERE name = '" + procedureName +"')" +
                        "\r\n BEGIN" +
                        "\r\n    DROP PROCEDURE [" + procedureName + "]" +
                        "\r\n END" +
                        "\r\n" +
                        "\r\n USE [master]" +
                        "\r\n GO" +
                        "\r\n CREATE PROCEDURE [dbo].[" + procedureName + "]  @dbname nvarchar(100), @output int OUTPUT" +
                        "\r\n AS BEGIN " +
                        "\r\n SET NOCOUNT ON" +
                        "\r\n" +
                        "\r\n DECLARE @detach int ," +
                        "\r\n @mdfExist int ," +
                        "\r\n @ldfExist int ," +
                        "\r\n @bakExist int ;" +
                        "\r\n" +
                        "\r\n DECLARE @sql nvarchar(1000)," +
                        "\r\n @fileMDF nvarchar(1000)," +
                        "\r\n @fileLDF nvarchar(1000)," +
                        "\r\n @fileBAK nvarchar(1000);" +
                        "\r\n" +
                        "\r\n SET @fileMDF = N'" + folderSQL + "\\'+@dbname+'_log.mdf' ;" +
                        "\r\n SET @fileLDF = N'" + folderSQL + "\\'+@dbname+'_log.ldf' ;" +
                        "\r\n SET @fileBAK = N'" + folderSQL + "\\'+@dbname+'.bak';" +
                        "\r\n" +
                        "\r\n IF EXISTS(SELECT name FROM master.sys.databases WHERE name = @dbname)" +
                        "\r\n BEGIN" +
                        "\r\n    SET @sql = 'ALTER DATABASE [' + @dbname + '] SET OFFLINE'" +
                        "\r\n    EXEC(@sql)" +
                        "\r\n    SET @sql = 'EXEC master.dbo.sp_detach_db @dbname = ' + @dbname" +
                        "\r\n    EXEC(@sql)" +
                        "\r\n    SET @detach = 1;" +
                        "\r\n END" +
                        "\r\n ELSE" +
                        "\r\n BEGIN" +
                        "\r\n    Exec master..xp_fileexist @fileMDF,@mdfExist OUT" +
                        "\r\n    IF @mdfExist = 1" +
                        "\r\n    BEGIN" +
                        "\r\n       PRINT 'Rename the file: ' + @fileMDF" +
                        "\r\n       PRINT 'and execute the procedure again'" +
                        "\r\n       SET @mdfExist = 0;" +
                        "\r\n    END" +
                        "\r\n    Exec master..xp_fileexist @fileLDF,@ldfExist OUT" +
                        "\r\n    IF @ldfExist = 1" +
                        "\r\n    BEGIN" +
                        "\r\n       PRINT 'Rename the file: ' + @fileLDF" +
                        "\r\n       PRINT 'and execute the procedure again'" +
                        "\r\n       SET @ldfExist = 0;" +
                        "\r\n    END" +
                        "\r\n    ELSE" +
                        "\r\n    BEGIN" +
                        "\r\n       SET @fileMDF = N'" + folderSQL + "\\'+@dbname+'.mdf' ;" +
                        "\r\n       SET @fileLDF = N'" + folderSQL + "\\'+@dbname+'.ldf' ;" +
                        "\r\n" +
                        "\r\n       Exec master..xp_fileexist @fileMDF,@mdfExist OUT" +
                        "\r\n       IF @mdfExist = 1" +
                        "\r\n       BEGIN" +
                        "\r\n          Exec master..xp_fileexist @fileLDF,@ldfExist OUT" +
                        "\r\n          IF @ldfExist = 1" +
                        "\r\n          BEGIN" +
                        "\r\n          SET @sql = N'CREATE DATABASE [' + @dbname + '] ON' +" +
                        "\r\n            '  ( FILENAME = N''' + @fileMDF + '''),' +" +
                        "\r\n            '  ( FILENAME = N''' + @fileLDF + ''')' +" +
                        "\r\n            '  FOR ATTACH';" +
                        "\r\n          EXEC(@sql)" +
                        "\r\n          SET @sql = 'ALTER DATABASE [' + @dbname + '] SET ONLINE';" +
                        "\r\n          EXEC(@sql)" +
                        "\r\n          END" +
                        "\r\n       END" +
                        "\r\n       ELSE" +
                        "\r\n       BEGIN" +
                        "\r\n          Exec master..xp_fileexist @fileBAK,@bakExist OUT" +
                        "\r\n          IF @bakExist = 1" +
                        "\r\n          BEGIN" +
                        "\r\n             SET @sql = 'RESTORE DATABASE [' + @dbname + '] FROM ' +" +
                        "\r\n               '  DISK = N''' + @fileBAK + ''' WITH FILE = 1,' +" +
                        "\r\n               '  MOVE ' + @dbname + '' +" +
                        "\r\n               '  TO N''' + @fileMDF + ''',' +" +
                        "\r\n               '  MOVE N''' + @dbname + '_log'' ' +" +
                        "\r\n               '  TO N''' + @fileLDF + ''',' +" +
                        "\r\n               '  NOUNLOAD, REPLACE, STATS = 100';" +
                        "\r\n             EXEC(@sql)" +
                        "\r\n             SET @sql = 'ALTER DATABASE [' + @dbname + '] SET ONLINE';" +
                        "\r\n             EXEC(@sql)" +
                        "\r\n          END" +
                        "\r\n       END" +
                        "\r\n    END" +
                        "\r\n END" +
                        "\r\n SET NOCOUNT OFF" +
                        "\r\n IF @detach = 1" +
                        "\r\n BEGIN" +
                        "\r\n     PRINT 'Database ' + @dbname + ' detached'" +
                        "\r\n END" +
                        "\r\n IF @bakExist = 1" +
                        "\r\n BEGIN" +
                        "\r\n     PRINT 'Database ' + @dbname + ' restored'" +
                        "\r\n END" +
                        "\r\n IF @mdfExist = 1 AND @ldfExist = 1" +
                        "\r\n BEGIN" +
                        "\r\n     PRINT 'Database ' + @dbname + ' attached'" +
                        "\r\n END";

            line = new UTF8Encoding(true).GetBytes(scriptText);
            fileStream.Write(line, 0, line.Length);

        }

        private void GenerateRegularScript(string folderSQL, string folderScript, IntPtr handle) {
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

                    WriteRegularCode("PORTALVENDAS", folderSQL, fileStream, procedures[i]);
                    WriteRegularCode("TID_ATUALIZACAO", folderSQL, fileStream, procedures[i]);
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
            customMessage = new CustomMessage("Regular Script generated successfully: \n" + folderScript, "Success", "success");
            CustomDialog.ShowCustomDialog(customMessage, Handle);
        }
        private void WriteRegularCode(string database, string folderSQL, FileStream fileStream, string action) {
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
                    fileText =  "\r\n   SET @bakExist = 0;" +
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
                                    "\r\n      END"+
                                    "\r\n   END";
                    }

                    break;
            }
            line = new UTF8Encoding(true).GetBytes(fileText);
            fileStream.Write(line, 0, line.Length);

        }

        private void BtnPathFolderSQLBrowser_Click(object sender, EventArgs e) {
            if (folderPicker.ShowDialog(Handle, false) == true) {
                txtFolderSQL.Text = folderPicker.ResultPath;
            }
        }
        private void BtnPathScriptBrowser_Click(object sender, EventArgs e) {
            if (folderPicker.ShowDialog(Handle, false) == true) {
                txtScriptFolder.Text = folderPicker.ResultPath;
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
        #endregion Script Generator

        private void button1_Click(object sender, EventArgs e) {
            string procedureName, folderScript, folderSQL;

            procedureName = txtProcedureName.Text;
            folderScript = txtScriptFolder.Text + "\\" + txtScriptName.Text + ".sql";
            folderSQL = txtFolderSQL.Text;

            string directoryScript = folderScript.Substring(0, folderScript.LastIndexOf('\\'));

            if (Directory.Exists(directoryScript) == false && !directoryScript.Equals("")) {
                Directory.CreateDirectory(directoryScript);
            }
            if (File.Exists(folderScript)) {
                File.Delete(folderScript);
            }
            if (procedureName.Equals("")) {
                procedureName = "test";
            }
            GenerateUnifiedScript_test(folderSQL, folderScript, procedureName,Handle);
        }
    }
}
