using System;
using System.Windows.Forms;

namespace Utilities {
    public partial class Notes : Form {
        private readonly string[] arrayDeleteDuplicates;

        public Notes() {
            InitializeComponent();
        }
        public Notes(string[] arrayDeleteDuplicates) {
            InitializeComponent();
            this.arrayDeleteDuplicates = arrayDeleteDuplicates;
        }

        private void Notes_Load(object sender, EventArgs e) {
            string initials, functionality,sqlInstallGuide;

            initials = "TID = includes files with the extensions *.dll, *.exe and the file conexao.tps.";
            functionality = "Common:" + 
                            "\r\n   Mouse Hover = When the mouse stops over a button it will hide options that the button won't use." +
                            "\r\n"+
                            "\r\nSQL Scripts:" +
                            "\r\n   Unified Script:" +
                            "\r\n       Generate an sql script that check and execute the suitable operation. Operation order detach>attach>restore. Also includes a create for these databases TID_TEMP,TIDDF,TID_ATUALIZACAO " +
                            "\r\n   Regular Script:" +
                            "\r\n       Generate an sql script it contains 3 procedures (DetachTID, AttachTID and RestoreTID) that check and execute the determined operation. " +
                            "\r\n" +
                            "\r\nFile Management:" +
                            "\r\n   Delete Duplicates:" +
                            "\r\n       Group files by hash, then delete the files with repeated hashs. Leave the first file found in each hash group. " +
                            "\r\n       Check Subfolders: adds subfolders files to the same group of the main folder. So if a copy of a main folder file appears on a subfolder it will be deleted. " +
                            "\r\n       EXCEPTION: if a file name has one of these characters combinations it will be deleted in the process:\r\n     ";
            foreach (string str in arrayDeleteDuplicates) {
                functionality += "\"" + str + "\"  ";
            }
            //functionality = functionality.Substring(0,functionality.LastIndexOf(","));

            sqlInstallGuide = "1) Go to Microsoft website and download the developer edition: SQLServer2019-SSEI-Dev.exe" + 
                            "\r\n2) Run, select Custom then Install" +
                            "\r\n3) Once the download is complete. A new window with the SQL Server Installation Center will open"+
                            "\r\n4) Select Installation then New SQL Server stand-alone installation or add features to existing installation" +
                "\r\n5) Just follow the intallation process using free edition: Developter, until the section Feature Selection" +
                "\r\n6) In Feature Selection check Database Engine Services then click next" +
                "\r\n7) In Instance Configuration check Named Instance then specify the instance name" +
                "\r\n8) You can skip the Server configuration" +
                "\r\n9) In database engine configuration, select Mixed Mode as the authentication mode, specify the password and click on add current user" +
                "\r\n10) Click Install" +
                "\r\n\r\nReference: https://www.datacamp.com/community/tutorials/how-to-install-sql-server ";

            txtFunctionality.Text = functionality;
            txtInitials.Text = initials;
            txtSqlServerInstall.Text = sqlInstallGuide;
        }
    }
}
