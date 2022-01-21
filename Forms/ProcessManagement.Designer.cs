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
            this.btnEndSelectedProcess = new System.Windows.Forms.Button();
            this.lblNameRemotePC = new System.Windows.Forms.Label();
            this.txtNameRemotePC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRemoteUser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRemotePassword = new System.Windows.Forms.TextBox();
            this.grpRemotePC = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblListProgress = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcess)).BeginInit();
            this.grpRemotePC.SuspendLayout();
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
            this.dgvProcess.Location = new System.Drawing.Point(24, 180);
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
            this.dgvProcess.Size = new System.Drawing.Size(576, 369);
            this.dgvProcess.TabIndex = 1;
            // 
            // btnListProcesses
            // 
            this.btnListProcesses.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnListProcesses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnListProcesses.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnListProcesses.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnListProcesses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListProcesses.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnListProcesses.ForeColor = System.Drawing.SystemColors.Control;
            this.btnListProcesses.Image = global::Utilities.Properties.Resources.icons8_list_view_32;
            this.btnListProcesses.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListProcesses.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnListProcesses.Location = new System.Drawing.Point(606, 176);
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
            this.lblFromMoveFiles.Location = new System.Drawing.Point(24, 35);
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
            this.txtLockedFilePath.Location = new System.Drawing.Point(108, 32);
            this.txtLockedFilePath.Name = "txtLockedFilePath";
            this.txtLockedFilePath.Size = new System.Drawing.Size(456, 22);
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
            this.btnLockedFileBrowser.Location = new System.Drawing.Point(570, 31);
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
            this.BtnCheckLockedFile.Location = new System.Drawing.Point(606, 21);
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
            this.chkShowUnknownUsers.Location = new System.Drawing.Point(108, 60);
            this.chkShowUnknownUsers.Name = "chkShowUnknownUsers";
            this.chkShowUnknownUsers.Size = new System.Drawing.Size(250, 20);
            this.chkShowUnknownUsers.TabIndex = 18;
            this.chkShowUnknownUsers.Text = "Show Processes With Unknown Users";
            this.chkShowUnknownUsers.UseVisualStyleBackColor = true;
            // 
            // btnEndSelectedProcess
            // 
            this.btnEndSelectedProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEndSelectedProcess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnEndSelectedProcess.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEndSelectedProcess.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnEndSelectedProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEndSelectedProcess.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEndSelectedProcess.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEndSelectedProcess.Image = global::Utilities.Properties.Resources.icons8_delete_process_32;
            this.btnEndSelectedProcess.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEndSelectedProcess.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnEndSelectedProcess.Location = new System.Drawing.Point(606, 505);
            this.btnEndSelectedProcess.Name = "btnEndSelectedProcess";
            this.btnEndSelectedProcess.Size = new System.Drawing.Size(155, 44);
            this.btnEndSelectedProcess.TabIndex = 19;
            this.btnEndSelectedProcess.Text = "End Selected Process";
            this.btnEndSelectedProcess.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEndSelectedProcess.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEndSelectedProcess.UseVisualStyleBackColor = false;
            this.btnEndSelectedProcess.Click += new System.EventHandler(this.btnEndSelectedProcess_Click);
            // 
            // lblNameRemotePC
            // 
            this.lblNameRemotePC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNameRemotePC.AutoSize = true;
            this.lblNameRemotePC.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNameRemotePC.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNameRemotePC.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblNameRemotePC.Location = new System.Drawing.Point(6, 22);
            this.lblNameRemotePC.Name = "lblNameRemotePC";
            this.lblNameRemotePC.Size = new System.Drawing.Size(45, 16);
            this.lblNameRemotePC.TabIndex = 20;
            this.lblNameRemotePC.Text = "Name:";
            // 
            // txtNameRemotePC
            // 
            this.txtNameRemotePC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNameRemotePC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtNameRemotePC.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtNameRemotePC.ForeColor = System.Drawing.Color.White;
            this.txtNameRemotePC.Location = new System.Drawing.Point(57, 21);
            this.txtNameRemotePC.Name = "txtNameRemotePC";
            this.txtNameRemotePC.Size = new System.Drawing.Size(218, 22);
            this.txtNameRemotePC.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(13, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "User:";
            // 
            // txtRemoteUser
            // 
            this.txtRemoteUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRemoteUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtRemoteUser.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtRemoteUser.ForeColor = System.Drawing.Color.White;
            this.txtRemoteUser.Location = new System.Drawing.Point(57, 50);
            this.txtRemoteUser.Name = "txtRemoteUser";
            this.txtRemoteUser.Size = new System.Drawing.Size(218, 22);
            this.txtRemoteUser.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(283, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 24;
            this.label2.Text = "Password:";
            // 
            // txtRemotePassword
            // 
            this.txtRemotePassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRemotePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtRemotePassword.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtRemotePassword.ForeColor = System.Drawing.Color.White;
            this.txtRemotePassword.Location = new System.Drawing.Point(357, 50);
            this.txtRemotePassword.Name = "txtRemotePassword";
            this.txtRemotePassword.Size = new System.Drawing.Size(202, 22);
            this.txtRemotePassword.TabIndex = 25;
            // 
            // grpRemotePC
            // 
            this.grpRemotePC.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpRemotePC.Controls.Add(this.label3);
            this.grpRemotePC.Controls.Add(this.lblNameRemotePC);
            this.grpRemotePC.Controls.Add(this.label2);
            this.grpRemotePC.Controls.Add(this.txtRemotePassword);
            this.grpRemotePC.Controls.Add(this.txtNameRemotePC);
            this.grpRemotePC.Controls.Add(this.label1);
            this.grpRemotePC.Controls.Add(this.txtRemoteUser);
            this.grpRemotePC.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpRemotePC.ForeColor = System.Drawing.Color.White;
            this.grpRemotePC.Location = new System.Drawing.Point(24, 86);
            this.grpRemotePC.Name = "grpRemotePC";
            this.grpRemotePC.Size = new System.Drawing.Size(576, 84);
            this.grpRemotePC.TabIndex = 26;
            this.grpRemotePC.TabStop = false;
            this.grpRemotePC.Text = "Remote Computer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(283, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(252, 16);
            this.label3.TabIndex = 26;
            this.label3.Text = "* Can be the ip address or computer name";
            // 
            // lblListProgress
            // 
            this.lblListProgress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblListProgress.AutoSize = true;
            this.lblListProgress.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblListProgress.ForeColor = System.Drawing.Color.Chartreuse;
            this.lblListProgress.Location = new System.Drawing.Point(621, 154);
            this.lblListProgress.Name = "lblListProgress";
            this.lblListProgress.Size = new System.Drawing.Size(123, 16);
            this.lblListProgress.TabIndex = 27;
            this.lblListProgress.Text = "Listing Processes...";
            // 
            // ProcessManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(790, 570);
            this.Controls.Add(this.lblListProgress);
            this.Controls.Add(this.grpRemotePC);
            this.Controls.Add(this.btnEndSelectedProcess);
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
            this.grpRemotePC.ResumeLayout(false);
            this.grpRemotePC.PerformLayout();
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
        private System.Windows.Forms.Button btnEndSelectedProcess;
        private System.Windows.Forms.Label lblNameRemotePC;
        private System.Windows.Forms.TextBox txtNameRemotePC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRemoteUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRemotePassword;
        private System.Windows.Forms.GroupBox grpRemotePC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblListProgress;
    }
}