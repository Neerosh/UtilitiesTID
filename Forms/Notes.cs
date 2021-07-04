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
            string initials, functionality;
            initials = "TID = includes files with the extensions *.dll, *.exe and the file conexao.tps.";
            functionality = "Common:" + 
                            "\r\n   Mouse Hover = When the mouse stops over a button it will hide options that the button won't use." +
                            "\r\n"+
                            "\r\nSQL Scripts:" +
                            "\r\n   Unified Script:" +
                            "\r\n       Generate an sql script that check and execute the suitable operation. Operation order detach>attach>restore. " +
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

            txtFunctionality.Text = functionality;
            txtInitials.Text = initials;
        }
    }
}
