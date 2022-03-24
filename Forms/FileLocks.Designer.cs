namespace Utilities.Forms
{
    partial class FileLocks
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileLocks));
            this.dgvProcess = new System.Windows.Forms.DataGridView();
            this.lblLockedFile = new System.Windows.Forms.Label();
            this.txtLockedFilePath = new System.Windows.Forms.TextBox();
            this.btnLockedFileBrowser = new System.Windows.Forms.Button();
            this.btnCheckLockedFile = new System.Windows.Forms.Button();
            this.chkShowUnknownUsers = new System.Windows.Forms.CheckBox();
            this.btnEndSelectedProcess = new System.Windows.Forms.Button();
            this.dgvSharedFiles = new System.Windows.Forms.DataGridView();
            this.btnListAllSharedFiles = new System.Windows.Forms.Button();
            this.lblProcesses = new System.Windows.Forms.Label();
            this.lblSharedFieles = new System.Windows.Forms.Label();
            this.btnDisconnectSelectedFile = new System.Windows.Forms.Button();
            this.lblListProcesses = new System.Windows.Forms.Label();
            this.btnListProcesses = new System.Windows.Forms.Button();
            this.lblListSharedFiles = new System.Windows.Forms.Label();
            this.lblCheckLockedFile = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcess)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSharedFiles)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProcess
            // 
            this.dgvProcess.AllowUserToAddRows = false;
            this.dgvProcess.AllowUserToDeleteRows = false;
            this.dgvProcess.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
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
            this.dgvProcess.Location = new System.Drawing.Point(24, 111);
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
            this.dgvProcess.Size = new System.Drawing.Size(566, 200);
            this.dgvProcess.TabIndex = 9;
            // 
            // lblLockedFile
            // 
            this.lblLockedFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLockedFile.AutoSize = true;
            this.lblLockedFile.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLockedFile.ForeColor = System.Drawing.SystemColors.Control;
            this.lblLockedFile.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblLockedFile.Location = new System.Drawing.Point(24, 35);
            this.lblLockedFile.Name = "lblLockedFile";
            this.lblLockedFile.Size = new System.Drawing.Size(78, 16);
            this.lblLockedFile.TabIndex = 0;
            this.lblLockedFile.Text = "Locked File:";
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
            this.txtLockedFilePath.Size = new System.Drawing.Size(446, 22);
            this.txtLockedFilePath.TabIndex = 1;
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
            this.btnLockedFileBrowser.Location = new System.Drawing.Point(560, 31);
            this.btnLockedFileBrowser.Name = "btnLockedFileBrowser";
            this.btnLockedFileBrowser.Size = new System.Drawing.Size(30, 25);
            this.btnLockedFileBrowser.TabIndex = 2;
            this.btnLockedFileBrowser.Text = "...";
            this.btnLockedFileBrowser.UseVisualStyleBackColor = false;
            this.btnLockedFileBrowser.Click += new System.EventHandler(this.BtnLockedFileBrowser_Click);
            // 
            // btnCheckLockedFile
            // 
            this.btnCheckLockedFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCheckLockedFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnCheckLockedFile.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCheckLockedFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btnCheckLockedFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckLockedFile.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCheckLockedFile.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCheckLockedFile.Image = global::Utilities.Properties.Resources.icons8_lock_file_32;
            this.btnCheckLockedFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCheckLockedFile.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCheckLockedFile.Location = new System.Drawing.Point(606, 21);
            this.btnCheckLockedFile.Name = "btnCheckLockedFile";
            this.btnCheckLockedFile.Size = new System.Drawing.Size(155, 44);
            this.btnCheckLockedFile.TabIndex = 4;
            this.btnCheckLockedFile.Text = "Check Locked File";
            this.btnCheckLockedFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCheckLockedFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCheckLockedFile.UseVisualStyleBackColor = false;
            this.btnCheckLockedFile.Click += new System.EventHandler(this.BtnCheckLockedFile_Click);
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
            this.chkShowUnknownUsers.TabIndex = 3;
            this.chkShowUnknownUsers.Text = "Show Processes With Unknown Users";
            this.chkShowUnknownUsers.UseVisualStyleBackColor = true;
            // 
            // btnEndSelectedProcess
            // 
            this.btnEndSelectedProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEndSelectedProcess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnEndSelectedProcess.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEndSelectedProcess.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnEndSelectedProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEndSelectedProcess.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEndSelectedProcess.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEndSelectedProcess.Image = global::Utilities.Properties.Resources.icons8_delete_process_32;
            this.btnEndSelectedProcess.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEndSelectedProcess.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnEndSelectedProcess.Location = new System.Drawing.Point(606, 267);
            this.btnEndSelectedProcess.Name = "btnEndSelectedProcess";
            this.btnEndSelectedProcess.Size = new System.Drawing.Size(155, 44);
            this.btnEndSelectedProcess.TabIndex = 6;
            this.btnEndSelectedProcess.Text = "End Selected Process";
            this.btnEndSelectedProcess.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEndSelectedProcess.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEndSelectedProcess.UseVisualStyleBackColor = false;
            this.btnEndSelectedProcess.Click += new System.EventHandler(this.BtnEndSelectedProcess_Click);
            // 
            // dgvSharedFiles
            // 
            this.dgvSharedFiles.AllowUserToAddRows = false;
            this.dgvSharedFiles.AllowUserToDeleteRows = false;
            this.dgvSharedFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSharedFiles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.dgvSharedFiles.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgvSharedFiles.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.dgvSharedFiles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSharedFiles.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvSharedFiles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvSharedFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSharedFiles.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvSharedFiles.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvSharedFiles.GridColor = System.Drawing.Color.White;
            this.dgvSharedFiles.Location = new System.Drawing.Point(24, 342);
            this.dgvSharedFiles.MultiSelect = false;
            this.dgvSharedFiles.Name = "dgvSharedFiles";
            this.dgvSharedFiles.ReadOnly = true;
            this.dgvSharedFiles.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvSharedFiles.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvSharedFiles.RowHeadersVisible = false;
            this.dgvSharedFiles.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvSharedFiles.RowTemplate.Height = 25;
            this.dgvSharedFiles.RowTemplate.ReadOnly = true;
            this.dgvSharedFiles.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvSharedFiles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSharedFiles.Size = new System.Drawing.Size(566, 200);
            this.dgvSharedFiles.TabIndex = 10;
            // 
            // btnListAllSharedFiles
            // 
            this.btnListAllSharedFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnListAllSharedFiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnListAllSharedFiles.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnListAllSharedFiles.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnListAllSharedFiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListAllSharedFiles.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnListAllSharedFiles.ForeColor = System.Drawing.SystemColors.Control;
            this.btnListAllSharedFiles.Image = global::Utilities.Properties.Resources.icons8_share_file_32;
            this.btnListAllSharedFiles.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListAllSharedFiles.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnListAllSharedFiles.Location = new System.Drawing.Point(606, 342);
            this.btnListAllSharedFiles.Name = "btnListAllSharedFiles";
            this.btnListAllSharedFiles.Size = new System.Drawing.Size(155, 44);
            this.btnListAllSharedFiles.TabIndex = 7;
            this.btnListAllSharedFiles.Text = "List Shared Files";
            this.btnListAllSharedFiles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListAllSharedFiles.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnListAllSharedFiles.UseVisualStyleBackColor = false;
            this.btnListAllSharedFiles.Click += new System.EventHandler(this.BtnListAllSharedFiles_Click);
            // 
            // lblProcesses
            // 
            this.lblProcesses.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProcesses.AutoSize = true;
            this.lblProcesses.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblProcesses.ForeColor = System.Drawing.SystemColors.Control;
            this.lblProcesses.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblProcesses.Location = new System.Drawing.Point(24, 92);
            this.lblProcesses.Name = "lblProcesses";
            this.lblProcesses.Size = new System.Drawing.Size(73, 16);
            this.lblProcesses.TabIndex = 10;
            this.lblProcesses.Text = "Processes:";
            // 
            // lblSharedFieles
            // 
            this.lblSharedFieles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSharedFieles.AutoSize = true;
            this.lblSharedFieles.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSharedFieles.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSharedFieles.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblSharedFieles.Location = new System.Drawing.Point(24, 323);
            this.lblSharedFieles.Name = "lblSharedFieles";
            this.lblSharedFieles.Size = new System.Drawing.Size(84, 16);
            this.lblSharedFieles.TabIndex = 11;
            this.lblSharedFieles.Text = "Shared Files:";
            // 
            // btnDisconnectSelectedFile
            // 
            this.btnDisconnectSelectedFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDisconnectSelectedFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnDisconnectSelectedFile.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDisconnectSelectedFile.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnDisconnectSelectedFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisconnectSelectedFile.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDisconnectSelectedFile.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDisconnectSelectedFile.Image = global::Utilities.Properties.Resources.icons8_disconnect_32;
            this.btnDisconnectSelectedFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDisconnectSelectedFile.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnDisconnectSelectedFile.Location = new System.Drawing.Point(606, 498);
            this.btnDisconnectSelectedFile.Name = "btnDisconnectSelectedFile";
            this.btnDisconnectSelectedFile.Size = new System.Drawing.Size(155, 44);
            this.btnDisconnectSelectedFile.TabIndex = 8;
            this.btnDisconnectSelectedFile.Text = "Close Selected Connection";
            this.btnDisconnectSelectedFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDisconnectSelectedFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDisconnectSelectedFile.UseVisualStyleBackColor = false;
            this.btnDisconnectSelectedFile.Click += new System.EventHandler(this.BtnDisconnectSelectedFile_Click);
            // 
            // lblListProcesses
            // 
            this.lblListProcesses.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblListProcesses.AutoSize = true;
            this.lblListProcesses.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblListProcesses.ForeColor = System.Drawing.Color.Chartreuse;
            this.lblListProcesses.Location = new System.Drawing.Point(467, 92);
            this.lblListProcesses.Name = "lblListProcesses";
            this.lblListProcesses.Size = new System.Drawing.Size(123, 16);
            this.lblListProcesses.TabIndex = 4;
            this.lblListProcesses.Text = "Listing Processes...";
            this.lblListProcesses.Visible = false;
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
            this.btnListProcesses.Image = global::Utilities.Properties.Resources.icons8_process_32;
            this.btnListProcesses.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListProcesses.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnListProcesses.Location = new System.Drawing.Point(606, 111);
            this.btnListProcesses.Name = "btnListProcesses";
            this.btnListProcesses.Size = new System.Drawing.Size(155, 44);
            this.btnListProcesses.TabIndex = 5;
            this.btnListProcesses.Text = "List Running Processes";
            this.btnListProcesses.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListProcesses.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnListProcesses.UseVisualStyleBackColor = false;
            this.btnListProcesses.Click += new System.EventHandler(this.BtnListAllProcesses_Click);
            // 
            // lblListSharedFiles
            // 
            this.lblListSharedFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblListSharedFiles.AutoSize = true;
            this.lblListSharedFiles.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblListSharedFiles.ForeColor = System.Drawing.Color.Chartreuse;
            this.lblListSharedFiles.Location = new System.Drawing.Point(419, 323);
            this.lblListSharedFiles.Name = "lblListSharedFiles";
            this.lblListSharedFiles.Size = new System.Drawing.Size(171, 16);
            this.lblListSharedFiles.TabIndex = 13;
            this.lblListSharedFiles.Text = "Listing Open Files/Folders...\r\n";
            this.lblListSharedFiles.Visible = false;
            // 
            // lblCheckLockedFile
            // 
            this.lblCheckLockedFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCheckLockedFile.AutoSize = true;
            this.lblCheckLockedFile.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCheckLockedFile.ForeColor = System.Drawing.Color.Chartreuse;
            this.lblCheckLockedFile.Location = new System.Drawing.Point(442, 61);
            this.lblCheckLockedFile.Name = "lblCheckLockedFile";
            this.lblCheckLockedFile.Size = new System.Drawing.Size(112, 16);
            this.lblCheckLockedFile.TabIndex = 14;
            this.lblCheckLockedFile.Text = "Checking Locks...";
            this.lblCheckLockedFile.Visible = false;
            // 
            // FileLocks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(790, 570);
            this.Controls.Add(this.lblCheckLockedFile);
            this.Controls.Add(this.lblListSharedFiles);
            this.Controls.Add(this.lblListProcesses);
            this.Controls.Add(this.btnListProcesses);
            this.Controls.Add(this.btnDisconnectSelectedFile);
            this.Controls.Add(this.lblSharedFieles);
            this.Controls.Add(this.lblProcesses);
            this.Controls.Add(this.btnListAllSharedFiles);
            this.Controls.Add(this.dgvSharedFiles);
            this.Controls.Add(this.btnEndSelectedProcess);
            this.Controls.Add(this.chkShowUnknownUsers);
            this.Controls.Add(this.lblLockedFile);
            this.Controls.Add(this.txtLockedFilePath);
            this.Controls.Add(this.btnLockedFileBrowser);
            this.Controls.Add(this.btnCheckLockedFile);
            this.Controls.Add(this.dgvProcess);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FileLocks";
            this.Text = "ProcessManagement";
            this.Load += new System.EventHandler(this.FileLocks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcess)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSharedFiles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProcess;
        private System.Windows.Forms.Label lblLockedFile;
        private System.Windows.Forms.TextBox txtLockedFilePath;
        private System.Windows.Forms.Button btnLockedFileBrowser;
        private System.Windows.Forms.Button btnCheckLockedFile;
        private System.Windows.Forms.CheckBox chkShowUnknownUsers;
        private System.Windows.Forms.Button btnEndSelectedProcess;
        private System.Windows.Forms.DataGridView dgvSharedFiles;
        private System.Windows.Forms.Button btnListAllSharedFiles;
        private System.Windows.Forms.Label lblProcesses;
        private System.Windows.Forms.Label lblSharedFieles;
        private System.Windows.Forms.Button btnDisconnectSelectedFile;
        private System.Windows.Forms.Label lblListProcesses;
        private System.Windows.Forms.Button btnListProcesses;
        private System.Windows.Forms.Label lblListSharedFiles;
        private System.Windows.Forms.Label lblCheckLockedFile;
    }
}