namespace Utilities.Forms
{
    partial class ProcessManagement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProcessManagement));
            this.dgvProcess = new System.Windows.Forms.DataGridView();
            this.btnListProcesses = new System.Windows.Forms.Button();
            this.lblFromMoveFiles = new System.Windows.Forms.Label();
            this.txtLockedFilePath = new System.Windows.Forms.TextBox();
            this.btnLockedFileBrowser = new System.Windows.Forms.Button();
            this.BtnCheckLockedFile = new System.Windows.Forms.Button();
            this.chkShowUnknownUsers = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcess)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProcess
            // 
            this.dgvProcess.AllowUserToAddRows = false;
            this.dgvProcess.AllowUserToDeleteRows = false;
            this.dgvProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProcess.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.dgvProcess.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgvProcess.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.dgvProcess.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProcess.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvProcess.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProcess.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProcess.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProcess.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvProcess.GridColor = System.Drawing.Color.White;
            this.dgvProcess.Location = new System.Drawing.Point(24, 78);
            this.dgvProcess.MultiSelect = false;
            this.dgvProcess.Name = "dgvProcess";
            this.dgvProcess.ReadOnly = true;
            this.dgvProcess.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvProcess.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProcess.RowHeadersVisible = false;
            this.dgvProcess.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvProcess.RowTemplate.Height = 25;
            this.dgvProcess.RowTemplate.ReadOnly = true;
            this.dgvProcess.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvProcess.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProcess.Size = new System.Drawing.Size(576, 471);
            this.dgvProcess.TabIndex = 1;
            // 
            // btnListProcesses
            // 
            this.btnListProcesses.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnListProcesses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnListProcesses.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnListProcesses.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnListProcesses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListProcesses.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnListProcesses.ForeColor = System.Drawing.SystemColors.Control;
            this.btnListProcesses.Image = global::Utilities.Properties.Resources.icons8_list_view_32;
            this.btnListProcesses.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListProcesses.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnListProcesses.Location = new System.Drawing.Point(606, 505);
            this.btnListProcesses.Name = "btnListProcesses";
            this.btnListProcesses.Size = new System.Drawing.Size(155, 44);
            this.btnListProcesses.TabIndex = 9;
            this.btnListProcesses.Text = "List All Processes";
            this.btnListProcesses.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListProcesses.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnListProcesses.UseVisualStyleBackColor = false;
            this.btnListProcesses.Click += new System.EventHandler(this.btnListProcesses_Click);
            // 
            // lblFromMoveFiles
            // 
            this.lblFromMoveFiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFromMoveFiles.AutoSize = true;
            this.lblFromMoveFiles.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFromMoveFiles.ForeColor = System.Drawing.SystemColors.Control;
            this.lblFromMoveFiles.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblFromMoveFiles.Location = new System.Drawing.Point(24, 20);
            this.lblFromMoveFiles.Name = "lblFromMoveFiles";
            this.lblFromMoveFiles.Size = new System.Drawing.Size(78, 16);
            this.lblFromMoveFiles.TabIndex = 14;
            this.lblFromMoveFiles.Text = "Locked File:";
            // 
            // txtLockedFilePath
            // 
            this.txtLockedFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLockedFilePath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtLockedFilePath.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtLockedFilePath.ForeColor = System.Drawing.Color.White;
            this.txtLockedFilePath.Location = new System.Drawing.Point(108, 17);
            this.txtLockedFilePath.Name = "txtLockedFilePath";
            this.txtLockedFilePath.Size = new System.Drawing.Size(616, 22);
            this.txtLockedFilePath.TabIndex = 15;
            // 
            // btnLockedFileBrowser
            // 
            this.btnLockedFileBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLockedFileBrowser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnLockedFileBrowser.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLockedFileBrowser.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnLockedFileBrowser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLockedFileBrowser.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLockedFileBrowser.ForeColor = System.Drawing.Color.White;
            this.btnLockedFileBrowser.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnLockedFileBrowser.Location = new System.Drawing.Point(731, 16);
            this.btnLockedFileBrowser.Name = "btnLockedFileBrowser";
            this.btnLockedFileBrowser.Size = new System.Drawing.Size(30, 25);
            this.btnLockedFileBrowser.TabIndex = 16;
            this.btnLockedFileBrowser.Text = "...";
            this.btnLockedFileBrowser.UseVisualStyleBackColor = false;
            this.btnLockedFileBrowser.Click += new System.EventHandler(this.btnLockedFileBrowser_Click);
            // 
            // BtnCheckLockedFile
            // 
            this.BtnCheckLockedFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCheckLockedFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.BtnCheckLockedFile.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnCheckLockedFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.BtnCheckLockedFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCheckLockedFile.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCheckLockedFile.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnCheckLockedFile.Image = global::Utilities.Properties.Resources.icons8_lock_file_32;
            this.BtnCheckLockedFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCheckLockedFile.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnCheckLockedFile.Location = new System.Drawing.Point(606, 78);
            this.BtnCheckLockedFile.Name = "BtnCheckLockedFile";
            this.BtnCheckLockedFile.Size = new System.Drawing.Size(155, 44);
            this.BtnCheckLockedFile.TabIndex = 17;
            this.BtnCheckLockedFile.Text = "Check Locked File";
            this.BtnCheckLockedFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCheckLockedFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCheckLockedFile.UseVisualStyleBackColor = false;
            this.BtnCheckLockedFile.Click += new System.EventHandler(this.BtnCheckLockedFile_Click);
            // 
            // chkShowUnknownUsers
            // 
            this.chkShowUnknownUsers.AutoSize = true;
            this.chkShowUnknownUsers.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkShowUnknownUsers.ForeColor = System.Drawing.Color.White;
            this.chkShowUnknownUsers.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chkShowUnknownUsers.Location = new System.Drawing.Point(108, 45);
            this.chkShowUnknownUsers.Name = "chkShowUnknownUsers";
            this.chkShowUnknownUsers.Size = new System.Drawing.Size(250, 20);
            this.chkShowUnknownUsers.TabIndex = 18;
            this.chkShowUnknownUsers.Text = "Show Processes With Unknown Users";
            this.chkShowUnknownUsers.UseVisualStyleBackColor = true;
            // 
            // ProcessManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(790, 570);
            this.Controls.Add(this.chkShowUnknownUsers);
            this.Controls.Add(this.lblFromMoveFiles);
            this.Controls.Add(this.txtLockedFilePath);
            this.Controls.Add(this.btnLockedFileBrowser);
            this.Controls.Add(this.BtnCheckLockedFile);
            this.Controls.Add(this.btnListProcesses);
            this.Controls.Add(this.dgvProcess);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProcessManagement";
            this.Text = "ProcessManagement";
            this.Load += new System.EventHandler(this.ProcessManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcess)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProcess;
        private System.Windows.Forms.Button btnListProcesses;
        private System.Windows.Forms.Label lblFromMoveFiles;
        private System.Windows.Forms.TextBox txtLockedFilePath;
        private System.Windows.Forms.Button btnLockedFileBrowser;
        private System.Windows.Forms.Button BtnCheckLockedFile;
        private System.Windows.Forms.CheckBox chkShowUnknownUsers;
    }
}