﻿using System;
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
                Byte[] hash = null;
                switch (checksumAlgorithm) {
                    case "MD5":
                        using (MD5 md5 = MD5.Create()) {
                            using (FileStream stream = File.OpenRead(checksumFile)) {
                                hash = md5.ComputeHash(stream);
                            }
                        }
                        break;
                    case "SHA-1":
                        using (SHA1 sha1 = SHA1.Create()) {
                            using (FileStream stream = File.OpenRead(checksumFile)) {
                                hash = sha1.ComputeHash(stream);
                            }
                        }
                        break;
                    case "SHA-256":
                        using (SHA256 sha256 = SHA256.Create()) {
                            using (FileStream stream = File.OpenRead(checksumFile)) {
                                hash = sha256.ComputeHash(stream);
                            }
                        }
                        break;
                    case "SHA-384":
                        using (SHA384 sha384 = SHA384.Create()) {
                            using (FileStream stream = File.OpenRead(checksumFile)) {
                                hash = sha384.ComputeHash(stream);
                            }
                        }
                        break;
                    case "SHA-512":
                        using (SHA512 sha512 = SHA512.Create()) {
                            using (FileStream stream = File.OpenRead(checksumFile)) {
                                hash = sha512.ComputeHash(stream);
                            }
                        }
                        break;
                }
                if (hash != null) {
                    fileHash = BitConverter.ToString(hash).Replace("-", "").ToUpper();
                }
            });

            if (fileHash != null && !fileHash.Equals("")) { 
                txtChecksumFileHash.Text = fileHash;
            }
            lblFileHashProgress.Visible = false;
        }

        private async void BtnGenerateFileHash_Click(object sender, EventArgs e) {
            if (task == null || task.IsCompleted) {
                lblValidateStatus.Visible = false;
                task = GenerateFileHash();
                await task;
                return;
            }

        }

        private void btnValidateFileHash_Click(object sender, EventArgs e) {
            CustomMessage customMessage;
            if (txtChecksumFileHash.Text.Equals("")) { 
                customMessage = new CustomMessage("Type or generate a file hash first.","Information","information");
                CustomDialog.ShowCustomDialog(customMessage, this);
                return;
            }
            if (txtChecksumExpectedHash.Text.Equals("")) {
                customMessage = new CustomMessage("Type the expected hash first.", "Information", "information");
                CustomDialog.ShowCustomDialog(customMessage, this);
                return;
            }

            string formatedExpectedHash = txtChecksumExpectedHash.Text.Replace("-", "").ToUpper();
            if (formatedExpectedHash.Equals(txtChecksumFileHash.Text)) {
                lblValidateStatus.Text = "Validation Result: Success";
                lblValidateStatus.ForeColor = Color.FromArgb(68, 204, 0);
                txtChecksumExpectedHash.ForeColor = Color.FromArgb(68, 204, 0);
            } else {
                lblValidateStatus.Text = "Validation Result: Failed";
                lblValidateStatus.ForeColor = Color.Yellow;
                txtChecksumExpectedHash.ForeColor = Color.Yellow;
            }
            lblValidateStatus.Visible = true;
        }
    }
}
