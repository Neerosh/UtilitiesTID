using System;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilities.Classes;

namespace Utilities.Forms
{
    public partial class FileChecksum : Form
    {
        public FileChecksum() {
            InitializeComponent();
            cboChecksumAlgorithm.SelectedItem = "MD5";
        }
        private Task task;

        private void btnChecksumFileBrowser_Click(object sender, EventArgs e) {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog(this);
            txtChecksumFile.Text = openFileDialog.FileName;
        }

        private async Task GenerateFileHash() { 
            string checksumFile = txtChecksumFile.Text;
            string checksumAlgorithm = cboChecksumAlgorithm.SelectedItem.ToString();
            string fileHash = "";

            txtChecksumFileHash.Text = "";

            if (checksumFile == null || checksumFile.Length == 0) {
                CustomDialog.ShowCustomDialog(new CustomMessage("Select a file", "Error", "error"), this);
                return;
            }

            lblFileHashProgress.Visible = true;

            await Task.Run(() => {
                switch (checksumAlgorithm) {
                    case "MD5":
                        using (MD5 md5 = MD5.Create()) {
                            using (FileStream stream = File.OpenRead(checksumFile)) {
                                Byte[] hash = md5.ComputeHash(stream);
                                fileHash = BitConverter.ToString(hash).Replace("-", "").ToUpper();
                            }
                        }
                        break;
                    case "SHA-1":
                        using (SHA1 sha1 = SHA1.Create()) {
                            using (FileStream stream = File.OpenRead(checksumFile)) {
                                Byte[] hash = sha1.ComputeHash(stream);
                                fileHash = BitConverter.ToString(hash).Replace("-", "").ToUpper();
                            }
                        }
                        break;
                    case "SHA-256":
                        using (SHA256 sha256 = SHA256.Create()) {
                            using (FileStream stream = File.OpenRead(checksumFile)) {
                                Byte[] hash = sha256.ComputeHash(stream);
                                fileHash = BitConverter.ToString(hash).Replace("-", "").ToUpper();
                            }
                        }
                        break;
                    case "SHA-384":
                        using (SHA384 sha384 = SHA384.Create()) {
                            using (FileStream stream = File.OpenRead(checksumFile)) {
                                Byte[] hash = sha384.ComputeHash(stream);
                                fileHash = BitConverter.ToString(hash).Replace("-", "").ToUpper();
                            }
                        }
                        break;
                    case "SHA-512":
                        using (SHA512 sha512 = SHA512.Create()) {
                            using (FileStream stream = File.OpenRead(checksumFile)) {
                                Byte[] hash = sha512.ComputeHash(stream);
                                fileHash = BitConverter.ToString(hash).Replace("-", "").ToUpper();
                            }
                        }
                        break;
                }
            });

            if (fileHash != null && !fileHash.Equals("")) { 
                txtChecksumFileHash.Text = fileHash;
            }
            
            lblFileHashProgress.Visible = false;
        }

        private async void BtnChecksum_Click(object sender, EventArgs e) {
            if (task == null || task.IsCompleted) {
                task = GenerateFileHash();
                await task;
                if (!txtChecksumExpectedHash.Text.Equals("") && !txtChecksumFileHash.Text.Equals("")) {
                    string formatedExpectedHash = txtChecksumExpectedHash.Text.Replace("-", "").ToUpper();
                    if (formatedExpectedHash.Equals(txtChecksumFileHash.Text)) {
                        txtChecksumExpectedHash.ForeColor = Color.FromArgb(68, 204, 0);
                    } else {
                        txtChecksumExpectedHash.ForeColor = Color.Yellow;
                    }
                }
                return;
            }

        }
    }
}
