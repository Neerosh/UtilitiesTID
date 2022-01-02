namespace Utilities.Forms
{
    partial class FileManagement
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
            this.lblFromMoveFiles = new System.Windows.Forms.Label();
            this.txtFromFolder = new System.Windows.Forms.TextBox();
            this.btnFromBrowser = new System.Windows.Forms.Button();
            this.lblToMoveFiles = new System.Windows.Forms.Label();
            this.txtToFolder = new System.Windows.Forms.TextBox();
            this.btnToBrowser = new System.Windows.Forms.Button();
            this.lblOrderBy = new System.Windows.Forms.Label();
            this.cboOrderBy = new System.Windows.Forms.ComboBox();
            this.cboOrderField = new System.Windows.Forms.ComboBox();
            this.lblFileExtension = new System.Windows.Forms.Label();
            this.cboFileExtension = new System.Windows.Forms.ComboBox();
            this.chkSubFolders = new System.Windows.Forms.CheckBox();
            this.btnCopyFiles = new System.Windows.Forms.Button();
            this.btnDeleteDuplicate = new System.Windows.Forms.Button();
            this.BtnMoveFiles = new System.Windows.Forms.Button();
            this.pgsFileManagement = new System.Windows.Forms.ProgressBar();
            this.lblProgressPercent = new System.Windows.Forms.Label();
            this.txtLogProcess = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lblFromMoveFiles
            // 
            this.lblFromMoveFiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFromMoveFiles.AutoSize = true;
            this.lblFromMoveFiles.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFromMoveFiles.ForeColor = System.Drawing.SystemColors.Control;
            this.lblFromMoveFiles.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblFromMoveFiles.Location = new System.Drawing.Point(20, 25);
            this.lblFromMoveFiles.Name = "lblFromMoveFiles";
            this.lblFromMoveFiles.Size = new System.Drawing.Size(81, 16);
            this.lblFromMoveFiles.TabIndex = 0;
            this.lblFromMoveFiles.Text = "From Folder:";
            // 
            // txtFromFolder
            // 
            this.txtFromFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFromFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtFromFolder.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtFromFolder.ForeColor = System.Drawing.Color.White;
            this.txtFromFolder.Location = new System.Drawing.Point(105, 22);
            this.txtFromFolder.Name = "txtFromFolder";
            this.txtFromFolder.Size = new System.Drawing.Size(472, 22);
            this.txtFromFolder.TabIndex = 1;
            // 
            // btnFromBrowser
            // 
            this.btnFromBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFromBrowser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnFromBrowser.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnFromBrowser.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnFromBrowser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFromBrowser.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFromBrowser.ForeColor = System.Drawing.Color.White;
            this.btnFromBrowser.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnFromBrowser.Location = new System.Drawing.Point(583, 21);
            this.btnFromBrowser.Name = "btnFromBrowser";
            this.btnFromBrowser.Size = new System.Drawing.Size(30, 25);
            this.btnFromBrowser.TabIndex = 2;
            this.btnFromBrowser.Text = "...";
            this.btnFromBrowser.UseVisualStyleBackColor = false;
            this.btnFromBrowser.Click += new System.EventHandler(this.BtnFromBrowser_Click);
            // 
            // lblToMoveFiles
            // 
            this.lblToMoveFiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblToMoveFiles.AutoSize = true;
            this.lblToMoveFiles.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblToMoveFiles.ForeColor = System.Drawing.SystemColors.Control;
            this.lblToMoveFiles.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblToMoveFiles.Location = new System.Drawing.Point(37, 56);
            this.lblToMoveFiles.Name = "lblToMoveFiles";
            this.lblToMoveFiles.Size = new System.Drawing.Size(64, 16);
            this.lblToMoveFiles.TabIndex = 3;
            this.lblToMoveFiles.Text = "To Folder:";
            // 
            // txtToFolder
            // 
            this.txtToFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtToFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtToFolder.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtToFolder.ForeColor = System.Drawing.Color.White;
            this.txtToFolder.Location = new System.Drawing.Point(105, 53);
            this.txtToFolder.Name = "txtToFolder";
            this.txtToFolder.Size = new System.Drawing.Size(472, 22);
            this.txtToFolder.TabIndex = 4;
            // 
            // btnToBrowser
            // 
            this.btnToBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnToBrowser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnToBrowser.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnToBrowser.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnToBrowser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToBrowser.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnToBrowser.ForeColor = System.Drawing.Color.White;
            this.btnToBrowser.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnToBrowser.Location = new System.Drawing.Point(583, 51);
            this.btnToBrowser.Name = "btnToBrowser";
            this.btnToBrowser.Size = new System.Drawing.Size(30, 25);
            this.btnToBrowser.TabIndex = 5;
            this.btnToBrowser.Text = "...";
            this.btnToBrowser.UseVisualStyleBackColor = false;
            this.btnToBrowser.Click += new System.EventHandler(this.BtnToBrowser_Click);
            // 
            // lblOrderBy
            // 
            this.lblOrderBy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOrderBy.AutoSize = true;
            this.lblOrderBy.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOrderBy.ForeColor = System.Drawing.SystemColors.Control;
            this.lblOrderBy.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblOrderBy.Location = new System.Drawing.Point(38, 89);
            this.lblOrderBy.Name = "lblOrderBy";
            this.lblOrderBy.Size = new System.Drawing.Size(63, 16);
            this.lblOrderBy.TabIndex = 6;
            this.lblOrderBy.Text = "Order By:";
            // 
            // cboOrderBy
            // 
            this.cboOrderBy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.cboOrderBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOrderBy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboOrderBy.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cboOrderBy.ForeColor = System.Drawing.Color.White;
            this.cboOrderBy.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cboOrderBy.Items.AddRange(new object[] {
            "Ascending",
            "Descending"});
            this.cboOrderBy.Location = new System.Drawing.Point(242, 86);
            this.cboOrderBy.Name = "cboOrderBy";
            this.cboOrderBy.Size = new System.Drawing.Size(124, 24);
            this.cboOrderBy.TabIndex = 8;
            // 
            // cboOrderField
            // 
            this.cboOrderField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.cboOrderField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOrderField.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboOrderField.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cboOrderField.ForeColor = System.Drawing.Color.White;
            this.cboOrderField.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cboOrderField.Items.AddRange(new object[] {
            "Creation Time",
            "Filename"});
            this.cboOrderField.Location = new System.Drawing.Point(105, 87);
            this.cboOrderField.Name = "cboOrderField";
            this.cboOrderField.Size = new System.Drawing.Size(123, 24);
            this.cboOrderField.TabIndex = 7;
            // 
            // lblFileExtension
            // 
            this.lblFileExtension.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFileExtension.AutoSize = true;
            this.lblFileExtension.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFileExtension.ForeColor = System.Drawing.SystemColors.Control;
            this.lblFileExtension.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblFileExtension.Location = new System.Drawing.Point(27, 126);
            this.lblFileExtension.Name = "lblFileExtension";
            this.lblFileExtension.Size = new System.Drawing.Size(74, 16);
            this.lblFileExtension.TabIndex = 9;
            this.lblFileExtension.Text = "Filtered By:\r\n";
            // 
            // cboFileExtension
            // 
            this.cboFileExtension.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.cboFileExtension.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFileExtension.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboFileExtension.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cboFileExtension.ForeColor = System.Drawing.Color.White;
            this.cboFileExtension.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cboFileExtension.Items.AddRange(new object[] {
            "All Extensions",
            "TID",
            "*.dll or *.exe",
            "*.dll",
            "*.exe ",
            "*.tps"});
            this.cboFileExtension.Location = new System.Drawing.Point(105, 121);
            this.cboFileExtension.Name = "cboFileExtension";
            this.cboFileExtension.Size = new System.Drawing.Size(123, 24);
            this.cboFileExtension.TabIndex = 10;
            // 
            // chkSubFolders
            // 
            this.chkSubFolders.AutoSize = true;
            this.chkSubFolders.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkSubFolders.ForeColor = System.Drawing.Color.White;
            this.chkSubFolders.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chkSubFolders.Location = new System.Drawing.Point(242, 125);
            this.chkSubFolders.Name = "chkSubFolders";
            this.chkSubFolders.Size = new System.Drawing.Size(128, 20);
            this.chkSubFolders.TabIndex = 11;
            this.chkSubFolders.Text = "Check Subfolders";
            this.chkSubFolders.UseVisualStyleBackColor = true;
            // 
            // btnCopyFiles
            // 
            this.btnCopyFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopyFiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnCopyFiles.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCopyFiles.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btnCopyFiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopyFiles.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCopyFiles.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCopyFiles.Image = global::Utilities.Properties.Resources.icons8_copy_32;
            this.btnCopyFiles.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCopyFiles.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCopyFiles.Location = new System.Drawing.Point(628, 71);
            this.btnCopyFiles.Name = "btnCopyFiles";
            this.btnCopyFiles.Size = new System.Drawing.Size(142, 44);
            this.btnCopyFiles.TabIndex = 14;
            this.btnCopyFiles.Text = "Copy Files";
            this.btnCopyFiles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCopyFiles.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCopyFiles.UseVisualStyleBackColor = false;
            this.btnCopyFiles.Click += new System.EventHandler(this.BtnCopyFiles_Click);
            this.btnCopyFiles.MouseLeave += new System.EventHandler(this.BtnCopyFiles_MouseLeave);
            this.btnCopyFiles.MouseHover += new System.EventHandler(this.BtnCopyFiles_MouseHover);
            // 
            // btnDeleteDuplicate
            // 
            this.btnDeleteDuplicate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteDuplicate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnDeleteDuplicate.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDeleteDuplicate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btnDeleteDuplicate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteDuplicate.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteDuplicate.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDeleteDuplicate.Image = global::Utilities.Properties.Resources.icons8_delete_file2_32;
            this.btnDeleteDuplicate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteDuplicate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnDeleteDuplicate.Location = new System.Drawing.Point(628, 121);
            this.btnDeleteDuplicate.Name = "btnDeleteDuplicate";
            this.btnDeleteDuplicate.Size = new System.Drawing.Size(142, 44);
            this.btnDeleteDuplicate.TabIndex = 12;
            this.btnDeleteDuplicate.Text = "Delete Duplicated Files";
            this.btnDeleteDuplicate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteDuplicate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeleteDuplicate.UseVisualStyleBackColor = false;
            this.btnDeleteDuplicate.Click += new System.EventHandler(this.BtnDeleteDuplicate_Click);
            this.btnDeleteDuplicate.MouseLeave += new System.EventHandler(this.BtnDeleteDuplicate_MouseLeave);
            this.btnDeleteDuplicate.MouseHover += new System.EventHandler(this.BtnDeleteDuplicate_MouseHover);
            // 
            // BtnMoveFiles
            // 
            this.BtnMoveFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMoveFiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.BtnMoveFiles.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnMoveFiles.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.BtnMoveFiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMoveFiles.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnMoveFiles.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnMoveFiles.Image = global::Utilities.Properties.Resources.icons8_send_file_32;
            this.BtnMoveFiles.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnMoveFiles.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnMoveFiles.Location = new System.Drawing.Point(628, 21);
            this.BtnMoveFiles.Name = "BtnMoveFiles";
            this.BtnMoveFiles.Size = new System.Drawing.Size(142, 44);
            this.BtnMoveFiles.TabIndex = 13;
            this.BtnMoveFiles.Text = "Move Files";
            this.BtnMoveFiles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnMoveFiles.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnMoveFiles.UseVisualStyleBackColor = false;
            this.BtnMoveFiles.Click += new System.EventHandler(this.BtnMoveFiles_Click);
            this.BtnMoveFiles.MouseLeave += new System.EventHandler(this.BtnMoveFiles_MouseLeave);
            this.BtnMoveFiles.MouseHover += new System.EventHandler(this.BtnMoveFiles_MouseHover);
            // 
            // pgsFileManagement
            // 
            this.pgsFileManagement.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pgsFileManagement.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pgsFileManagement.Location = new System.Drawing.Point(20, 180);
            this.pgsFileManagement.Name = "pgsFileManagement";
            this.pgsFileManagement.Size = new System.Drawing.Size(704, 29);
            this.pgsFileManagement.TabIndex = 7;
            // 
            // lblProgressPercent
            // 
            this.lblProgressPercent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProgressPercent.AutoSize = true;
            this.lblProgressPercent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblProgressPercent.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblProgressPercent.ForeColor = System.Drawing.SystemColors.Control;
            this.lblProgressPercent.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblProgressPercent.Location = new System.Drawing.Point(730, 185);
            this.lblProgressPercent.Name = "lblProgressPercent";
            this.lblProgressPercent.Size = new System.Drawing.Size(40, 16);
            this.lblProgressPercent.TabIndex = 8;
            this.lblProgressPercent.Text = "100%";
            // 
            // txtLogProcess
            // 
            this.txtLogProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLogProcess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtLogProcess.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLogProcess.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtLogProcess.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.txtLogProcess.HideSelection = false;
            this.txtLogProcess.Location = new System.Drawing.Point(20, 215);
            this.txtLogProcess.Name = "txtLogProcess";
            this.txtLogProcess.ReadOnly = true;
            this.txtLogProcess.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtLogProcess.Size = new System.Drawing.Size(750, 334);
            this.txtLogProcess.TabIndex = 16;
            this.txtLogProcess.Text = "";
            // 
            // FileManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(790, 570);
            this.Controls.Add(this.txtLogProcess);
            this.Controls.Add(this.lblFromMoveFiles);
            this.Controls.Add(this.txtFromFolder);
            this.Controls.Add(this.btnFromBrowser);
            this.Controls.Add(this.lblToMoveFiles);
            this.Controls.Add(this.pgsFileManagement);
            this.Controls.Add(this.txtToFolder);
            this.Controls.Add(this.lblProgressPercent);
            this.Controls.Add(this.btnToBrowser);
            this.Controls.Add(this.BtnMoveFiles);
            this.Controls.Add(this.lblOrderBy);
            this.Controls.Add(this.btnDeleteDuplicate);
            this.Controls.Add(this.cboOrderBy);
            this.Controls.Add(this.btnCopyFiles);
            this.Controls.Add(this.cboOrderField);
            this.Controls.Add(this.chkSubFolders);
            this.Controls.Add(this.lblFileExtension);
            this.Controls.Add(this.cboFileExtension);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FileManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Management";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblFromMoveFiles;
        private System.Windows.Forms.TextBox txtFromFolder;
        private System.Windows.Forms.Button btnFromBrowser;
        private System.Windows.Forms.Label lblToMoveFiles;
        private System.Windows.Forms.TextBox txtToFolder;
        private System.Windows.Forms.Button btnToBrowser;
        private System.Windows.Forms.Label lblOrderBy;
        private System.Windows.Forms.ComboBox cboOrderBy;
        private System.Windows.Forms.ComboBox cboOrderField;
        private System.Windows.Forms.Label lblFileExtension;
        private System.Windows.Forms.ComboBox cboFileExtension;
        private System.Windows.Forms.CheckBox chkSubFolders;
        private System.Windows.Forms.Button btnCopyFiles;
        private System.Windows.Forms.Button btnDeleteDuplicate;
        private System.Windows.Forms.Button BtnMoveFiles;
        private System.Windows.Forms.ProgressBar pgsFileManagement;
        private System.Windows.Forms.Label lblProgressPercent;
        private System.Windows.Forms.RichTextBox txtLogProcess;
    }
}