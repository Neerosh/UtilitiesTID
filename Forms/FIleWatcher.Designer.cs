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
            this.BtnWatcher.TabIndex = 6;
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
            this.dgvWatchHistory.Location = new System.Drawing.Point(20, 145);
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
            this.dgvWatchHistory.Size = new System.Drawing.Size(749, 399);
            this.dgvWatchHistory.TabIndex = 8;
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
            this.lblFileWatcherStatus.Location = new System.Drawing.Point(631, 78);
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
            this.lblHistory.Location = new System.Drawing.Point(20, 126);
            this.lblHistory.Name = "lblHistory";
            this.lblHistory.Size = new System.Drawing.Size(105, 16);
            this.lblHistory.TabIndex = 7;
            this.lblHistory.Text = "Watcher History:";
            // 
            // FileWatcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(790, 570);
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
    }
}