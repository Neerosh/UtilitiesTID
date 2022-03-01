﻿namespace Utilities.Forms
{
    partial class FileChecksum
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.lblChecksumFile = new System.Windows.Forms.Label();
            this.txtChecksumFile = new System.Windows.Forms.TextBox();
            this.btnChecksumFileBrowser = new System.Windows.Forms.Button();
            this.BtnChecksum = new System.Windows.Forms.Button();
            this.lblChecksumAlgorithm = new System.Windows.Forms.Label();
            this.cboChecksumAlgorithm = new System.Windows.Forms.ComboBox();
            this.lblChecksumFileHash = new System.Windows.Forms.Label();
            this.txtChecksumFileHash = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtChecksumExpectedHash = new System.Windows.Forms.RichTextBox();
            this.lblFileHashProgress = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblChecksumFile
            // 
            this.lblChecksumFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblChecksumFile.AutoSize = true;
            this.lblChecksumFile.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblChecksumFile.ForeColor = System.Drawing.SystemColors.Control;
            this.lblChecksumFile.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblChecksumFile.Location = new System.Drawing.Point(80, 25);
            this.lblChecksumFile.Name = "lblChecksumFile";
            this.lblChecksumFile.Size = new System.Drawing.Size(32, 16);
            this.lblChecksumFile.TabIndex = 14;
            this.lblChecksumFile.Text = "File:";
            // 
            // txtChecksumFile
            // 
            this.txtChecksumFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtChecksumFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtChecksumFile.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtChecksumFile.ForeColor = System.Drawing.Color.White;
            this.txtChecksumFile.Location = new System.Drawing.Point(118, 22);
            this.txtChecksumFile.Name = "txtChecksumFile";
            this.txtChecksumFile.Size = new System.Drawing.Size(451, 22);
            this.txtChecksumFile.TabIndex = 15;
            // 
            // btnChecksumFileBrowser
            // 
            this.btnChecksumFileBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChecksumFileBrowser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnChecksumFileBrowser.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnChecksumFileBrowser.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnChecksumFileBrowser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChecksumFileBrowser.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnChecksumFileBrowser.ForeColor = System.Drawing.Color.White;
            this.btnChecksumFileBrowser.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnChecksumFileBrowser.Location = new System.Drawing.Point(575, 21);
            this.btnChecksumFileBrowser.Name = "btnChecksumFileBrowser";
            this.btnChecksumFileBrowser.Size = new System.Drawing.Size(30, 25);
            this.btnChecksumFileBrowser.TabIndex = 16;
            this.btnChecksumFileBrowser.Text = "...";
            this.btnChecksumFileBrowser.UseVisualStyleBackColor = false;
            this.btnChecksumFileBrowser.Click += new System.EventHandler(this.btnChecksumFileBrowser_Click);
            // 
            // BtnChecksum
            // 
            this.BtnChecksum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnChecksum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.BtnChecksum.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnChecksum.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.BtnChecksum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnChecksum.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnChecksum.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnChecksum.Image = global::Utilities.Properties.Resources.icons8_move_file_32;
            this.BtnChecksum.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnChecksum.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnChecksum.Location = new System.Drawing.Point(625, 21);
            this.BtnChecksum.Name = "BtnChecksum";
            this.BtnChecksum.Size = new System.Drawing.Size(142, 44);
            this.BtnChecksum.TabIndex = 19;
            this.BtnChecksum.Text = "Generate File Hash";
            this.BtnChecksum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnChecksum.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnChecksum.UseVisualStyleBackColor = false;
            this.BtnChecksum.Click += new System.EventHandler(this.BtnChecksum_Click);
            // 
            // lblChecksumAlgorithm
            // 
            this.lblChecksumAlgorithm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblChecksumAlgorithm.AutoSize = true;
            this.lblChecksumAlgorithm.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblChecksumAlgorithm.ForeColor = System.Drawing.SystemColors.Control;
            this.lblChecksumAlgorithm.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblChecksumAlgorithm.Location = new System.Drawing.Point(46, 55);
            this.lblChecksumAlgorithm.Name = "lblChecksumAlgorithm";
            this.lblChecksumAlgorithm.Size = new System.Drawing.Size(66, 16);
            this.lblChecksumAlgorithm.TabIndex = 17;
            this.lblChecksumAlgorithm.Text = "Algorithm:";
            // 
            // cboChecksumAlgorithm
            // 
            this.cboChecksumAlgorithm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.cboChecksumAlgorithm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboChecksumAlgorithm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboChecksumAlgorithm.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cboChecksumAlgorithm.ForeColor = System.Drawing.Color.White;
            this.cboChecksumAlgorithm.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cboChecksumAlgorithm.Items.AddRange(new object[] {
            "MD5",
            "SHA-1",
            "SHA-256",
            "SHA-384",
            "SHA-512"});
            this.cboChecksumAlgorithm.Location = new System.Drawing.Point(118, 52);
            this.cboChecksumAlgorithm.Name = "cboChecksumAlgorithm";
            this.cboChecksumAlgorithm.Size = new System.Drawing.Size(113, 24);
            this.cboChecksumAlgorithm.TabIndex = 18;
            // 
            // lblChecksumFileHash
            // 
            this.lblChecksumFileHash.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblChecksumFileHash.AutoSize = true;
            this.lblChecksumFileHash.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblChecksumFileHash.ForeColor = System.Drawing.SystemColors.Control;
            this.lblChecksumFileHash.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblChecksumFileHash.Location = new System.Drawing.Point(46, 90);
            this.lblChecksumFileHash.Name = "lblChecksumFileHash";
            this.lblChecksumFileHash.Size = new System.Drawing.Size(66, 16);
            this.lblChecksumFileHash.TabIndex = 20;
            this.lblChecksumFileHash.Text = "File Hash:";
            // 
            // txtChecksumFileHash
            // 
            this.txtChecksumFileHash.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtChecksumFileHash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtChecksumFileHash.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtChecksumFileHash.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtChecksumFileHash.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.txtChecksumFileHash.HideSelection = false;
            this.txtChecksumFileHash.Location = new System.Drawing.Point(118, 88);
            this.txtChecksumFileHash.Name = "txtChecksumFileHash";
            this.txtChecksumFileHash.ReadOnly = true;
            this.txtChecksumFileHash.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtChecksumFileHash.Size = new System.Drawing.Size(487, 50);
            this.txtChecksumFileHash.TabIndex = 21;
            this.txtChecksumFileHash.Text = "";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(12, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "Expected Hash:";
            // 
            // txtChecksumExpectedHash
            // 
            this.txtChecksumExpectedHash.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtChecksumExpectedHash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtChecksumExpectedHash.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtChecksumExpectedHash.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtChecksumExpectedHash.ForeColor = System.Drawing.Color.White;
            this.txtChecksumExpectedHash.HideSelection = false;
            this.txtChecksumExpectedHash.Location = new System.Drawing.Point(118, 150);
            this.txtChecksumExpectedHash.Name = "txtChecksumExpectedHash";
            this.txtChecksumExpectedHash.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtChecksumExpectedHash.Size = new System.Drawing.Size(487, 50);
            this.txtChecksumExpectedHash.TabIndex = 23;
            this.txtChecksumExpectedHash.Text = "";
            // 
            // lblFileHashProgress
            // 
            this.lblFileHashProgress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFileHashProgress.AutoSize = true;
            this.lblFileHashProgress.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFileHashProgress.ForeColor = System.Drawing.Color.Chartreuse;
            this.lblFileHashProgress.Location = new System.Drawing.Point(464, 60);
            this.lblFileHashProgress.Name = "lblFileHashProgress";
            this.lblFileHashProgress.Size = new System.Drawing.Size(141, 16);
            this.lblFileHashProgress.TabIndex = 28;
            this.lblFileHashProgress.Text = "Generating File Hash...";
            this.lblFileHashProgress.Visible = false;
            // 
            // FileEncryption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(790, 570);
            this.Controls.Add(this.lblFileHashProgress);
            this.Controls.Add(this.txtChecksumExpectedHash);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtChecksumFileHash);
            this.Controls.Add(this.lblChecksumFileHash);
            this.Controls.Add(this.lblChecksumFile);
            this.Controls.Add(this.txtChecksumFile);
            this.Controls.Add(this.btnChecksumFileBrowser);
            this.Controls.Add(this.BtnChecksum);
            this.Controls.Add(this.lblChecksumAlgorithm);
            this.Controls.Add(this.cboChecksumAlgorithm);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FileEncryption";
            this.Text = "FileChecksum";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChecksumFile;
        private System.Windows.Forms.TextBox txtChecksumFile;
        private System.Windows.Forms.Button btnChecksumFileBrowser;
        private System.Windows.Forms.Button BtnChecksum;
        private System.Windows.Forms.Label lblChecksumAlgorithm;
        private System.Windows.Forms.ComboBox cboChecksumAlgorithm;
        private System.Windows.Forms.Label lblChecksumFileHash;
        private System.Windows.Forms.RichTextBox txtChecksumFileHash;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtChecksumExpectedHash;
        private System.Windows.Forms.Label lblFileHashProgress;
    }
}