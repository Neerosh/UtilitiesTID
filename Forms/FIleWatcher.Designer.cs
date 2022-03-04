namespace Utilities.Forms
{
    partial class FileWatcher
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
            this.lblWatcherFolder = new System.Windows.Forms.Label();
            this.txtWatcherFolder = new System.Windows.Forms.TextBox();
            this.btnFolderBrowser = new System.Windows.Forms.Button();
            this.BtnWatcher = new System.Windows.Forms.Button();
            this.dgvWatchHistory = new System.Windows.Forms.DataGridView();
            this.chkSubdirectories = new System.Windows.Forms.CheckBox();
            this.lblFileFilter = new System.Windows.Forms.Label();
            this.cboFileFilter = new System.Windows.Forms.ComboBox();
            this.lblFileWatcherStatus = new System.Windows.Forms.Label();
            this.lblHistory = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chkFilterCreationTime = new System.Windows.Forms.CheckBox();
            this.chkFilterDirectoryName = new System.Windows.Forms.CheckBox();
            this.chkFilterFileName = new System.Windows.Forms.CheckBox();
            this.chkFilterLastAccess = new System.Windows.Forms.CheckBox();
            this.chkFilterLastWrite = new System.Windows.Forms.CheckBox();
            this.chkFilterSecurity = new System.Windows.Forms.CheckBox();
            this.chkFilterSize = new System.Windows.Forms.CheckBox();
            this.chkFilterAttributes = new System.Windows.Forms.CheckBox();
            this.btnClearHistory = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWatchHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWatcherFolder
            // 
            this.lblWatcherFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWatcherFolder.AutoSize = true;
            this.lblWatcherFolder.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblWatcherFolder.ForeColor = System.Drawing.SystemColors.Control;
            this.lblWatcherFolder.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblWatcherFolder.Location = new System.Drawing.Point(38, 25);
            this.lblWatcherFolder.Name = "lblWatcherFolder";
            this.lblWatcherFolder.Size = new System.Drawing.Size(47, 16);
            this.lblWatcherFolder.TabIndex = 0;
            this.lblWatcherFolder.Text = "Folder:";
            // 
            // txtWatcherFolder
            // 
            this.txtWatcherFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtWatcherFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtWatcherFolder.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtWatcherFolder.ForeColor = System.Drawing.Color.White;
            this.txtWatcherFolder.Location = new System.Drawing.Point(91, 22);
            this.txtWatcherFolder.Name = "txtWatcherFolder";
            this.txtWatcherFolder.Size = new System.Drawing.Size(468, 22);
            this.txtWatcherFolder.TabIndex = 1;
            // 
            // btnFolderBrowser
            // 
            this.btnFolderBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFolderBrowser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnFolderBrowser.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnFolderBrowser.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnFolderBrowser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFolderBrowser.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFolderBrowser.ForeColor = System.Drawing.Color.White;
            this.btnFolderBrowser.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnFolderBrowser.Location = new System.Drawing.Point(565, 21);
            this.btnFolderBrowser.Name = "btnFolderBrowser";
            this.btnFolderBrowser.Size = new System.Drawing.Size(30, 25);
            this.btnFolderBrowser.TabIndex = 2;
            this.btnFolderBrowser.Text = "...";
            this.btnFolderBrowser.UseVisualStyleBackColor = false;
            this.btnFolderBrowser.Click += new System.EventHandler(this.BtnFolderBrowser_Click);
            // 
            // BtnWatcher
            // 
            this.BtnWatcher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnWatcher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.BtnWatcher.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnWatcher.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.BtnWatcher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnWatcher.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnWatcher.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnWatcher.Image = global::Utilities.Properties.Resources.icons8_watch_file_32;
            this.BtnWatcher.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnWatcher.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnWatcher.Location = new System.Drawing.Point(611, 21);
            this.BtnWatcher.Name = "BtnWatcher";
            this.BtnWatcher.Size = new System.Drawing.Size(158, 44);
            this.BtnWatcher.TabIndex = 15;
            this.BtnWatcher.Text = "Start File Watcher";
            this.BtnWatcher.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnWatcher.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnWatcher.UseVisualStyleBackColor = false;
            this.BtnWatcher.Click += new System.EventHandler(this.BtnWatcher_Click);
            // 
            // dgvWatchHistory
            // 
            this.dgvWatchHistory.AllowUserToAddRows = false;
            this.dgvWatchHistory.AllowUserToDeleteRows = false;
            this.dgvWatchHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvWatchHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.dgvWatchHistory.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgvWatchHistory.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.dgvWatchHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvWatchHistory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvWatchHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvWatchHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvWatchHistory.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvWatchHistory.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvWatchHistory.GridColor = System.Drawing.Color.White;
            this.dgvWatchHistory.Location = new System.Drawing.Point(20, 165);
            this.dgvWatchHistory.MultiSelect = false;
            this.dgvWatchHistory.Name = "dgvWatchHistory";
            this.dgvWatchHistory.ReadOnly = true;
            this.dgvWatchHistory.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvWatchHistory.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvWatchHistory.RowHeadersVisible = false;
            this.dgvWatchHistory.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvWatchHistory.RowTemplate.Height = 25;
            this.dgvWatchHistory.RowTemplate.ReadOnly = true;
            this.dgvWatchHistory.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvWatchHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvWatchHistory.Size = new System.Drawing.Size(749, 380);
            this.dgvWatchHistory.TabIndex = 18;
            // 
            // chkSubdirectories
            // 
            this.chkSubdirectories.AutoSize = true;
            this.chkSubdirectories.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkSubdirectories.ForeColor = System.Drawing.Color.White;
            this.chkSubdirectories.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chkSubdirectories.Location = new System.Drawing.Point(367, 58);
            this.chkSubdirectories.Name = "chkSubdirectories";
            this.chkSubdirectories.Size = new System.Drawing.Size(154, 20);
            this.chkSubdirectories.TabIndex = 5;
            this.chkSubdirectories.Text = "Include Subdirectories";
            this.chkSubdirectories.UseVisualStyleBackColor = true;
            // 
            // lblFileFilter
            // 
            this.lblFileFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFileFilter.AutoSize = true;
            this.lblFileFilter.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFileFilter.ForeColor = System.Drawing.SystemColors.Control;
            this.lblFileFilter.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblFileFilter.Location = new System.Drawing.Point(20, 59);
            this.lblFileFilter.Name = "lblFileFilter";
            this.lblFileFilter.Size = new System.Drawing.Size(65, 16);
            this.lblFileFilter.TabIndex = 3;
            this.lblFileFilter.Text = "File Filter:\r\n";
            // 
            // cboFileFilter
            // 
            this.cboFileFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.cboFileFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFileFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboFileFilter.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cboFileFilter.ForeColor = System.Drawing.Color.White;
            this.cboFileFilter.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cboFileFilter.Items.AddRange(new object[] {
            "*.dll",
            "*.dll or *.exe",
            "*.exe ",
            "*.tps",
            "All Extensions",
            "TID"});
            this.cboFileFilter.Location = new System.Drawing.Point(91, 56);
            this.cboFileFilter.Name = "cboFileFilter";
            this.cboFileFilter.Size = new System.Drawing.Size(261, 24);
            this.cboFileFilter.TabIndex = 4;
            // 
            // lblFileWatcherStatus
            // 
            this.lblFileWatcherStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFileWatcherStatus.AutoSize = true;
            this.lblFileWatcherStatus.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFileWatcherStatus.ForeColor = System.Drawing.Color.Chartreuse;
            this.lblFileWatcherStatus.Location = new System.Drawing.Point(631, 72);
            this.lblFileWatcherStatus.Name = "lblFileWatcherStatus";
            this.lblFileWatcherStatus.Size = new System.Drawing.Size(119, 16);
            this.lblFileWatcherStatus.TabIndex = 100;
            this.lblFileWatcherStatus.Text = "Watcher Running...";
            this.lblFileWatcherStatus.Visible = false;
            // 
            // lblHistory
            // 
            this.lblHistory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHistory.AutoSize = true;
            this.lblHistory.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHistory.ForeColor = System.Drawing.SystemColors.Control;
            this.lblHistory.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblHistory.Location = new System.Drawing.Point(20, 146);
            this.lblHistory.Name = "lblHistory";
            this.lblHistory.Size = new System.Drawing.Size(105, 16);
            this.lblHistory.TabIndex = 17;
            this.lblHistory.Text = "Watcher History:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(20, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Notify Changes On:\r\n";
            // 
            // chkFilterCreationTime
            // 
            this.chkFilterCreationTime.AutoSize = true;
            this.chkFilterCreationTime.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkFilterCreationTime.ForeColor = System.Drawing.Color.White;
            this.chkFilterCreationTime.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chkFilterCreationTime.Location = new System.Drawing.Point(250, 93);
            this.chkFilterCreationTime.Name = "chkFilterCreationTime";
            this.chkFilterCreationTime.Size = new System.Drawing.Size(106, 20);
            this.chkFilterCreationTime.TabIndex = 8;
            this.chkFilterCreationTime.Text = "Creation Time";
            this.chkFilterCreationTime.UseVisualStyleBackColor = true;
            this.chkFilterCreationTime.CheckStateChanged += new System.EventHandler(this.ChkFilter_CheckStateChanged);
            // 
            // chkFilterDirectoryName
            // 
            this.chkFilterDirectoryName.AutoSize = true;
            this.chkFilterDirectoryName.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkFilterDirectoryName.ForeColor = System.Drawing.Color.White;
            this.chkFilterDirectoryName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chkFilterDirectoryName.Location = new System.Drawing.Point(367, 93);
            this.chkFilterDirectoryName.Name = "chkFilterDirectoryName";
            this.chkFilterDirectoryName.Size = new System.Drawing.Size(116, 20);
            this.chkFilterDirectoryName.TabIndex = 9;
            this.chkFilterDirectoryName.Text = "Directory Name";
            this.chkFilterDirectoryName.UseVisualStyleBackColor = true;
            this.chkFilterDirectoryName.CheckStateChanged += new System.EventHandler(this.ChkFilter_CheckStateChanged);
            // 
            // chkFilterFileName
            // 
            this.chkFilterFileName.AutoSize = true;
            this.chkFilterFileName.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkFilterFileName.ForeColor = System.Drawing.Color.White;
            this.chkFilterFileName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chkFilterFileName.Location = new System.Drawing.Point(510, 93);
            this.chkFilterFileName.Name = "chkFilterFileName";
            this.chkFilterFileName.Size = new System.Drawing.Size(85, 20);
            this.chkFilterFileName.TabIndex = 10;
            this.chkFilterFileName.Text = "File Name";
            this.chkFilterFileName.UseVisualStyleBackColor = true;
            this.chkFilterFileName.CheckStateChanged += new System.EventHandler(this.ChkFilter_CheckStateChanged);
            // 
            // chkFilterLastAccess
            // 
            this.chkFilterLastAccess.AutoSize = true;
            this.chkFilterLastAccess.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkFilterLastAccess.ForeColor = System.Drawing.Color.White;
            this.chkFilterLastAccess.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chkFilterLastAccess.Location = new System.Drawing.Point(146, 119);
            this.chkFilterLastAccess.Name = "chkFilterLastAccess";
            this.chkFilterLastAccess.Size = new System.Drawing.Size(102, 20);
            this.chkFilterLastAccess.TabIndex = 11;
            this.chkFilterLastAccess.Text = "Last Access ";
            this.chkFilterLastAccess.UseVisualStyleBackColor = true;
            this.chkFilterLastAccess.CheckStateChanged += new System.EventHandler(this.ChkFilter_CheckStateChanged);
            // 
            // chkFilterLastWrite
            // 
            this.chkFilterLastWrite.AutoSize = true;
            this.chkFilterLastWrite.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkFilterLastWrite.ForeColor = System.Drawing.Color.White;
            this.chkFilterLastWrite.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chkFilterLastWrite.Location = new System.Drawing.Point(250, 119);
            this.chkFilterLastWrite.Name = "chkFilterLastWrite";
            this.chkFilterLastWrite.Size = new System.Drawing.Size(86, 20);
            this.chkFilterLastWrite.TabIndex = 12;
            this.chkFilterLastWrite.Text = "Last Write";
            this.chkFilterLastWrite.UseVisualStyleBackColor = true;
            this.chkFilterLastWrite.CheckStateChanged += new System.EventHandler(this.ChkFilter_CheckStateChanged);
            // 
            // chkFilterSecurity
            // 
            this.chkFilterSecurity.AutoSize = true;
            this.chkFilterSecurity.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkFilterSecurity.ForeColor = System.Drawing.Color.White;
            this.chkFilterSecurity.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chkFilterSecurity.Location = new System.Drawing.Point(367, 119);
            this.chkFilterSecurity.Name = "chkFilterSecurity";
            this.chkFilterSecurity.Size = new System.Drawing.Size(137, 20);
            this.chkFilterSecurity.TabIndex = 13;
            this.chkFilterSecurity.Text = "Security Properties";
            this.chkFilterSecurity.UseVisualStyleBackColor = true;
            this.chkFilterSecurity.CheckStateChanged += new System.EventHandler(this.ChkFilter_CheckStateChanged);
            // 
            // chkFilterSize
            // 
            this.chkFilterSize.AutoSize = true;
            this.chkFilterSize.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkFilterSize.ForeColor = System.Drawing.Color.White;
            this.chkFilterSize.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chkFilterSize.Location = new System.Drawing.Point(510, 119);
            this.chkFilterSize.Name = "chkFilterSize";
            this.chkFilterSize.Size = new System.Drawing.Size(52, 20);
            this.chkFilterSize.TabIndex = 14;
            this.chkFilterSize.Text = "Size";
            this.chkFilterSize.UseVisualStyleBackColor = true;
            this.chkFilterSize.CheckStateChanged += new System.EventHandler(this.ChkFilter_CheckStateChanged);
            // 
            // chkFilterAttributes
            // 
            this.chkFilterAttributes.AutoSize = true;
            this.chkFilterAttributes.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkFilterAttributes.ForeColor = System.Drawing.Color.White;
            this.chkFilterAttributes.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chkFilterAttributes.Location = new System.Drawing.Point(146, 93);
            this.chkFilterAttributes.Name = "chkFilterAttributes";
            this.chkFilterAttributes.Size = new System.Drawing.Size(82, 20);
            this.chkFilterAttributes.TabIndex = 7;
            this.chkFilterAttributes.Text = "Attributes";
            this.chkFilterAttributes.UseVisualStyleBackColor = true;
            this.chkFilterAttributes.CheckStateChanged += new System.EventHandler(this.ChkFilter_CheckStateChanged);
            // 
            // btnClearHistory
            // 
            this.btnClearHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnClearHistory.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnClearHistory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btnClearHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearHistory.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClearHistory.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClearHistory.Image = global::Utilities.Properties.Resources.icons8_broom_32;
            this.btnClearHistory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClearHistory.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnClearHistory.Location = new System.Drawing.Point(611, 106);
            this.btnClearHistory.Name = "btnClearHistory";
            this.btnClearHistory.Size = new System.Drawing.Size(158, 44);
            this.btnClearHistory.TabIndex = 16;
            this.btnClearHistory.Text = "Clear History";
            this.btnClearHistory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClearHistory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClearHistory.UseVisualStyleBackColor = false;
            this.btnClearHistory.Click += new System.EventHandler(this.btnClearHistory_Click);
            // 
            // FileWatcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(790, 570);
            this.Controls.Add(this.btnClearHistory);
            this.Controls.Add(this.chkFilterAttributes);
            this.Controls.Add(this.chkFilterSize);
            this.Controls.Add(this.chkFilterSecurity);
            this.Controls.Add(this.chkFilterLastWrite);
            this.Controls.Add(this.chkFilterLastAccess);
            this.Controls.Add(this.chkFilterFileName);
            this.Controls.Add(this.chkFilterDirectoryName);
            this.Controls.Add(this.chkFilterCreationTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblHistory);
            this.Controls.Add(this.lblFileWatcherStatus);
            this.Controls.Add(this.lblFileFilter);
            this.Controls.Add(this.cboFileFilter);
            this.Controls.Add(this.chkSubdirectories);
            this.Controls.Add(this.dgvWatchHistory);
            this.Controls.Add(this.lblWatcherFolder);
            this.Controls.Add(this.txtWatcherFolder);
            this.Controls.Add(this.btnFolderBrowser);
            this.Controls.Add(this.BtnWatcher);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FileWatcher";
            this.Text = "FIleWatcher";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FileWatcher_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWatchHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWatcherFolder;
        private System.Windows.Forms.TextBox txtWatcherFolder;
        private System.Windows.Forms.Button btnFolderBrowser;
        private System.Windows.Forms.Button BtnWatcher;
        private System.Windows.Forms.DataGridView dgvWatchHistory;
        private System.Windows.Forms.CheckBox chkSubdirectories;
        private System.Windows.Forms.Label lblFileFilter;
        private System.Windows.Forms.ComboBox cboFileFilter;
        private System.Windows.Forms.Label lblFileWatcherStatus;
        private System.Windows.Forms.Label lblHistory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkFilterCreationTime;
        private System.Windows.Forms.CheckBox chkFilterDirectoryName;
        private System.Windows.Forms.CheckBox chkFilterFileName;
        private System.Windows.Forms.CheckBox chkFilterLastAccess;
        private System.Windows.Forms.CheckBox chkFilterLastWrite;
        private System.Windows.Forms.CheckBox chkFilterSecurity;
        private System.Windows.Forms.CheckBox chkFilterSize;
        private System.Windows.Forms.CheckBox chkFilterAttributes;
        private System.Windows.Forms.Button btnClearHistory;
    }
}