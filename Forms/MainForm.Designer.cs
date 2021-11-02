
namespace Teste
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.pgsFileManagement = new System.Windows.Forms.ProgressBar();
            this.txtLogProcess = new System.Windows.Forms.TextBox();
            this.lblProgressPercent = new System.Windows.Forms.Label();
            this.grpDeleteDuplicate = new System.Windows.Forms.GroupBox();
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
            this.mnsMenuBar = new System.Windows.Forms.MenuStrip();
            this.mnuCodeToClipoard = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCodeToClipboard = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmManageCode = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuScriptWriter = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNotes = new System.Windows.Forms.ToolStripMenuItem();
            this.grpClarionDateTime = new System.Windows.Forms.GroupBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.MaskedTextBox();
            this.lblClarionTime = new System.Windows.Forms.Label();
            this.txtClarionTime = new System.Windows.Forms.MaskedTextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.MaskedTextBox();
            this.lblClarionDate = new System.Windows.Forms.Label();
            this.txtClarionDate = new System.Windows.Forms.MaskedTextBox();
            this.grpDeleteDuplicate.SuspendLayout();
            this.mnsMenuBar.SuspendLayout();
            this.grpClarionDateTime.SuspendLayout();
            this.SuspendLayout();
            // 
            // pgsFileManagement
            // 
            this.pgsFileManagement.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pgsFileManagement.Location = new System.Drawing.Point(12, 264);
            this.pgsFileManagement.Name = "pgsFileManagement";
            this.pgsFileManagement.Size = new System.Drawing.Size(745, 29);
            this.pgsFileManagement.TabIndex = 2;
            // 
            // txtLogProcess
            // 
            this.txtLogProcess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtLogProcess.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLogProcess.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtLogProcess.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtLogProcess.ForeColor = System.Drawing.Color.Lime;
            this.txtLogProcess.Location = new System.Drawing.Point(12, 299);
            this.txtLogProcess.Multiline = true;
            this.txtLogProcess.Name = "txtLogProcess";
            this.txtLogProcess.ReadOnly = true;
            this.txtLogProcess.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtLogProcess.Size = new System.Drawing.Size(794, 207);
            this.txtLogProcess.TabIndex = 3;
            this.txtLogProcess.TabStop = false;
            // 
            // lblProgressPercent
            // 
            this.lblProgressPercent.AutoSize = true;
            this.lblProgressPercent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblProgressPercent.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProgressPercent.ForeColor = System.Drawing.SystemColors.Control;
            this.lblProgressPercent.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblProgressPercent.Location = new System.Drawing.Point(767, 271);
            this.lblProgressPercent.Name = "lblProgressPercent";
            this.lblProgressPercent.Size = new System.Drawing.Size(38, 16);
            this.lblProgressPercent.TabIndex = 4;
            this.lblProgressPercent.Text = "100%";
            // 
            // grpDeleteDuplicate
            // 
            this.grpDeleteDuplicate.Controls.Add(this.lblFromMoveFiles);
            this.grpDeleteDuplicate.Controls.Add(this.txtFromFolder);
            this.grpDeleteDuplicate.Controls.Add(this.btnFromBrowser);
            this.grpDeleteDuplicate.Controls.Add(this.lblToMoveFiles);
            this.grpDeleteDuplicate.Controls.Add(this.txtToFolder);
            this.grpDeleteDuplicate.Controls.Add(this.btnToBrowser);
            this.grpDeleteDuplicate.Controls.Add(this.lblOrderBy);
            this.grpDeleteDuplicate.Controls.Add(this.cboOrderBy);
            this.grpDeleteDuplicate.Controls.Add(this.cboOrderField);
            this.grpDeleteDuplicate.Controls.Add(this.lblFileExtension);
            this.grpDeleteDuplicate.Controls.Add(this.cboFileExtension);
            this.grpDeleteDuplicate.Controls.Add(this.chkSubFolders);
            this.grpDeleteDuplicate.Controls.Add(this.btnCopyFiles);
            this.grpDeleteDuplicate.Controls.Add(this.btnDeleteDuplicate);
            this.grpDeleteDuplicate.Controls.Add(this.BtnMoveFiles);
            this.grpDeleteDuplicate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpDeleteDuplicate.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpDeleteDuplicate.ForeColor = System.Drawing.SystemColors.Control;
            this.grpDeleteDuplicate.Location = new System.Drawing.Point(12, 98);
            this.grpDeleteDuplicate.Name = "grpDeleteDuplicate";
            this.grpDeleteDuplicate.Size = new System.Drawing.Size(794, 160);
            this.grpDeleteDuplicate.TabIndex = 1;
            this.grpDeleteDuplicate.TabStop = false;
            this.grpDeleteDuplicate.Text = "File Management";
            // 
            // lblFromMoveFiles
            // 
            this.lblFromMoveFiles.AutoSize = true;
            this.lblFromMoveFiles.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFromMoveFiles.ForeColor = System.Drawing.SystemColors.Control;
            this.lblFromMoveFiles.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblFromMoveFiles.Location = new System.Drawing.Point(6, 29);
            this.lblFromMoveFiles.Name = "lblFromMoveFiles";
            this.lblFromMoveFiles.Size = new System.Drawing.Size(81, 16);
            this.lblFromMoveFiles.TabIndex = 0;
            this.lblFromMoveFiles.Text = "From Folder:";
            // 
            // txtFromFolder
            // 
            this.txtFromFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtFromFolder.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFromFolder.ForeColor = System.Drawing.Color.White;
            this.txtFromFolder.Location = new System.Drawing.Point(92, 27);
            this.txtFromFolder.Name = "txtFromFolder";
            this.txtFromFolder.Size = new System.Drawing.Size(649, 22);
            this.txtFromFolder.TabIndex = 1;
            // 
            // btnFromBrowser
            // 
            this.btnFromBrowser.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnFromBrowser.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnFromBrowser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFromBrowser.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFromBrowser.ForeColor = System.Drawing.Color.White;
            this.btnFromBrowser.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnFromBrowser.Location = new System.Drawing.Point(747, 24);
            this.btnFromBrowser.Name = "btnFromBrowser";
            this.btnFromBrowser.Size = new System.Drawing.Size(31, 27);
            this.btnFromBrowser.TabIndex = 2;
            this.btnFromBrowser.Text = "...";
            this.btnFromBrowser.UseVisualStyleBackColor = true;
            this.btnFromBrowser.Click += new System.EventHandler(this.BtnFromBrowser_Click);
            // 
            // lblToMoveFiles
            // 
            this.lblToMoveFiles.AutoSize = true;
            this.lblToMoveFiles.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblToMoveFiles.ForeColor = System.Drawing.SystemColors.Control;
            this.lblToMoveFiles.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblToMoveFiles.Location = new System.Drawing.Point(23, 61);
            this.lblToMoveFiles.Name = "lblToMoveFiles";
            this.lblToMoveFiles.Size = new System.Drawing.Size(64, 16);
            this.lblToMoveFiles.TabIndex = 3;
            this.lblToMoveFiles.Text = "To Folder:";
            // 
            // txtToFolder
            // 
            this.txtToFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtToFolder.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtToFolder.ForeColor = System.Drawing.Color.White;
            this.txtToFolder.Location = new System.Drawing.Point(92, 59);
            this.txtToFolder.Name = "txtToFolder";
            this.txtToFolder.Size = new System.Drawing.Size(649, 22);
            this.txtToFolder.TabIndex = 4;
            // 
            // btnToBrowser
            // 
            this.btnToBrowser.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnToBrowser.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnToBrowser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToBrowser.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnToBrowser.ForeColor = System.Drawing.Color.White;
            this.btnToBrowser.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnToBrowser.Location = new System.Drawing.Point(747, 56);
            this.btnToBrowser.Name = "btnToBrowser";
            this.btnToBrowser.Size = new System.Drawing.Size(31, 27);
            this.btnToBrowser.TabIndex = 5;
            this.btnToBrowser.Text = "...";
            this.btnToBrowser.UseVisualStyleBackColor = true;
            this.btnToBrowser.Click += new System.EventHandler(this.BtnToBrowser_Click);
            // 
            // lblOrderBy
            // 
            this.lblOrderBy.AutoSize = true;
            this.lblOrderBy.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOrderBy.ForeColor = System.Drawing.SystemColors.Control;
            this.lblOrderBy.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblOrderBy.Location = new System.Drawing.Point(24, 93);
            this.lblOrderBy.Name = "lblOrderBy";
            this.lblOrderBy.Size = new System.Drawing.Size(63, 16);
            this.lblOrderBy.TabIndex = 6;
            this.lblOrderBy.Text = "Order By:";
            // 
            // cboOrderBy
            // 
            this.cboOrderBy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cboOrderBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOrderBy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboOrderBy.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboOrderBy.ForeColor = System.Drawing.Color.White;
            this.cboOrderBy.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cboOrderBy.Items.AddRange(new object[] {
            "Ascending",
            "Descending"});
            this.cboOrderBy.Location = new System.Drawing.Point(220, 91);
            this.cboOrderBy.Name = "cboOrderBy";
            this.cboOrderBy.Size = new System.Drawing.Size(131, 24);
            this.cboOrderBy.TabIndex = 8;
            // 
            // cboOrderField
            // 
            this.cboOrderField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cboOrderField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOrderField.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboOrderField.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboOrderField.ForeColor = System.Drawing.Color.White;
            this.cboOrderField.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cboOrderField.Items.AddRange(new object[] {
            "Creation Time",
            "Filename"});
            this.cboOrderField.Location = new System.Drawing.Point(92, 91);
            this.cboOrderField.Name = "cboOrderField";
            this.cboOrderField.Size = new System.Drawing.Size(113, 24);
            this.cboOrderField.TabIndex = 7;
            // 
            // lblFileExtension
            // 
            this.lblFileExtension.AutoSize = true;
            this.lblFileExtension.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFileExtension.ForeColor = System.Drawing.SystemColors.Control;
            this.lblFileExtension.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblFileExtension.Location = new System.Drawing.Point(13, 125);
            this.lblFileExtension.Name = "lblFileExtension";
            this.lblFileExtension.Size = new System.Drawing.Size(74, 16);
            this.lblFileExtension.TabIndex = 9;
            this.lblFileExtension.Text = "Filtered By:\r\n";
            // 
            // cboFileExtension
            // 
            this.cboFileExtension.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cboFileExtension.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFileExtension.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboFileExtension.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboFileExtension.ForeColor = System.Drawing.Color.White;
            this.cboFileExtension.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cboFileExtension.Items.AddRange(new object[] {
            "All Extensions",
            "TID",
            "*.dll or *.exe",
            "*.dll",
            "*.exe ",
            "*.tps"});
            this.cboFileExtension.Location = new System.Drawing.Point(92, 123);
            this.cboFileExtension.Name = "cboFileExtension";
            this.cboFileExtension.Size = new System.Drawing.Size(113, 24);
            this.cboFileExtension.TabIndex = 10;
            // 
            // chkSubFolders
            // 
            this.chkSubFolders.AutoSize = true;
            this.chkSubFolders.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkSubFolders.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chkSubFolders.Location = new System.Drawing.Point(223, 124);
            this.chkSubFolders.Name = "chkSubFolders";
            this.chkSubFolders.Size = new System.Drawing.Size(128, 20);
            this.chkSubFolders.TabIndex = 11;
            this.chkSubFolders.Text = "Check Subfolders";
            this.chkSubFolders.UseVisualStyleBackColor = true;
            // 
            // btnCopyFiles
            // 
            this.btnCopyFiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCopyFiles.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCopyFiles.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnCopyFiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopyFiles.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCopyFiles.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCopyFiles.Image = global::Utilities.Properties.Resources.icons8_copy_32;
            this.btnCopyFiles.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCopyFiles.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCopyFiles.Location = new System.Drawing.Point(645, 91);
            this.btnCopyFiles.Name = "btnCopyFiles";
            this.btnCopyFiles.Size = new System.Drawing.Size(133, 51);
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
            this.btnDeleteDuplicate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDeleteDuplicate.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDeleteDuplicate.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnDeleteDuplicate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteDuplicate.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteDuplicate.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDeleteDuplicate.Image = global::Utilities.Properties.Resources.icons8_delete_file2_32;
            this.btnDeleteDuplicate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteDuplicate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnDeleteDuplicate.Location = new System.Drawing.Point(360, 91);
            this.btnDeleteDuplicate.Name = "btnDeleteDuplicate";
            this.btnDeleteDuplicate.Size = new System.Drawing.Size(140, 51);
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
            this.BtnMoveFiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnMoveFiles.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnMoveFiles.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnMoveFiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMoveFiles.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnMoveFiles.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnMoveFiles.Image = global::Utilities.Properties.Resources.icons8_send_file_32;
            this.BtnMoveFiles.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnMoveFiles.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnMoveFiles.Location = new System.Drawing.Point(506, 91);
            this.BtnMoveFiles.Name = "BtnMoveFiles";
            this.BtnMoveFiles.Size = new System.Drawing.Size(133, 51);
            this.BtnMoveFiles.TabIndex = 13;
            this.BtnMoveFiles.Text = "Move Files";
            this.BtnMoveFiles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnMoveFiles.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnMoveFiles.UseVisualStyleBackColor = false;
            this.BtnMoveFiles.Click += new System.EventHandler(this.BtnMoveFiles_Click);
            this.BtnMoveFiles.MouseLeave += new System.EventHandler(this.BtnMoveFiles_MouseLeave);
            this.BtnMoveFiles.MouseHover += new System.EventHandler(this.BtnMoveFiles_MouseHover);
            // 
            // mnsMenuBar
            // 
            this.mnsMenuBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.mnsMenuBar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mnsMenuBar.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.mnsMenuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCodeToClipoard,
            this.mnuScriptWriter,
            this.mnuNotes});
            this.mnsMenuBar.Location = new System.Drawing.Point(0, 0);
            this.mnsMenuBar.Name = "mnsMenuBar";
            this.mnsMenuBar.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.mnsMenuBar.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.mnsMenuBar.Size = new System.Drawing.Size(818, 28);
            this.mnsMenuBar.TabIndex = 1;
            this.mnsMenuBar.Text = "Menu";
            // 
            // mnuCodeToClipoard
            // 
            this.mnuCodeToClipoard.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmCodeToClipboard,
            this.tsmManageCode});
            this.mnuCodeToClipoard.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mnuCodeToClipoard.ForeColor = System.Drawing.Color.White;
            this.mnuCodeToClipoard.Image = global::Utilities.Properties.Resources.icons8_data_32;
            this.mnuCodeToClipoard.Name = "mnuCodeToClipoard";
            this.mnuCodeToClipoard.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.mnuCodeToClipoard.Size = new System.Drawing.Size(128, 22);
            this.mnuCodeToClipoard.Text = "Clipboard Codes";
            this.mnuCodeToClipoard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tsmCodeToClipboard
            // 
            this.tsmCodeToClipboard.ForeColor = System.Drawing.Color.White;
            this.tsmCodeToClipboard.Image = global::Utilities.Properties.Resources.icons8_copy_to_clipboard_32;
            this.tsmCodeToClipboard.Name = "tsmCodeToClipboard";
            this.tsmCodeToClipboard.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.tsmCodeToClipboard.Size = new System.Drawing.Size(124, 22);
            this.tsmCodeToClipboard.Text = "Copy";
            this.tsmCodeToClipboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsmCodeToClipboard.Click += new System.EventHandler(this.MenuItemCodeToClipboard_Click);
            // 
            // tsmManageCode
            // 
            this.tsmManageCode.ForeColor = System.Drawing.Color.White;
            this.tsmManageCode.Image = global::Utilities.Properties.Resources.icons8_manage_clipboard_32;
            this.tsmManageCode.Name = "tsmManageCode";
            this.tsmManageCode.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.tsmManageCode.Size = new System.Drawing.Size(124, 22);
            this.tsmManageCode.Text = "Manage";
            this.tsmManageCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsmManageCode.Click += new System.EventHandler(this.MenuItemManageCode_Click);
            // 
            // mnuScriptWriter
            // 
            this.mnuScriptWriter.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mnuScriptWriter.ForeColor = System.Drawing.Color.White;
            this.mnuScriptWriter.Image = global::Utilities.Properties.Resources.icons8_scroll_32;
            this.mnuScriptWriter.Name = "mnuScriptWriter";
            this.mnuScriptWriter.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.mnuScriptWriter.Size = new System.Drawing.Size(106, 22);
            this.mnuScriptWriter.Text = "Script Writer";
            this.mnuScriptWriter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnuScriptWriter.Click += new System.EventHandler(this.MenuScriptWriter_Click);
            // 
            // mnuNotes
            // 
            this.mnuNotes.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuNotes.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mnuNotes.ForeColor = System.Drawing.Color.White;
            this.mnuNotes.Image = global::Utilities.Properties.Resources.icons8_info_squared_32;
            this.mnuNotes.Name = "mnuNotes";
            this.mnuNotes.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.mnuNotes.Size = new System.Drawing.Size(67, 22);
            this.mnuNotes.Text = "Notes";
            this.mnuNotes.Click += new System.EventHandler(this.MenuNotes_Click);
            // 
            // grpClarionDateTime
            // 
            this.grpClarionDateTime.Controls.Add(this.lblTime);
            this.grpClarionDateTime.Controls.Add(this.txtTime);
            this.grpClarionDateTime.Controls.Add(this.lblClarionTime);
            this.grpClarionDateTime.Controls.Add(this.txtClarionTime);
            this.grpClarionDateTime.Controls.Add(this.lblDate);
            this.grpClarionDateTime.Controls.Add(this.txtDate);
            this.grpClarionDateTime.Controls.Add(this.lblClarionDate);
            this.grpClarionDateTime.Controls.Add(this.txtClarionDate);
            this.grpClarionDateTime.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpClarionDateTime.ForeColor = System.Drawing.Color.White;
            this.grpClarionDateTime.Location = new System.Drawing.Point(12, 34);
            this.grpClarionDateTime.Name = "grpClarionDateTime";
            this.grpClarionDateTime.Size = new System.Drawing.Size(794, 58);
            this.grpClarionDateTime.TabIndex = 0;
            this.grpClarionDateTime.TabStop = false;
            this.grpClarionDateTime.Text = "Clarion Date / Time Conversion";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTime.Location = new System.Drawing.Point(21, 26);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(39, 16);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "Time:";
            // 
            // txtTime
            // 
            this.txtTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTime.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtTime.ForeColor = System.Drawing.Color.White;
            this.txtTime.Location = new System.Drawing.Point(66, 23);
            this.txtTime.Mask = "00:00";
            this.txtTime.Name = "txtTime";
            this.txtTime.PromptChar = ' ';
            this.txtTime.Size = new System.Drawing.Size(80, 23);
            this.txtTime.TabIndex = 1;
            this.txtTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTime.ValidatingType = typeof(System.DateTime);
            this.txtTime.Validated += new System.EventHandler(this.TxtTime_Validated);
            // 
            // lblClarionTime
            // 
            this.lblClarionTime.AutoSize = true;
            this.lblClarionTime.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblClarionTime.Location = new System.Drawing.Point(158, 26);
            this.lblClarionTime.Name = "lblClarionTime";
            this.lblClarionTime.Size = new System.Drawing.Size(83, 16);
            this.lblClarionTime.TabIndex = 2;
            this.lblClarionTime.Text = "Clarion Time:";
            // 
            // txtClarionTime
            // 
            this.txtClarionTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtClarionTime.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtClarionTime.ForeColor = System.Drawing.Color.White;
            this.txtClarionTime.Location = new System.Drawing.Point(247, 23);
            this.txtClarionTime.Mask = "0000000";
            this.txtClarionTime.Name = "txtClarionTime";
            this.txtClarionTime.PromptChar = ' ';
            this.txtClarionTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtClarionTime.Size = new System.Drawing.Size(80, 23);
            this.txtClarionTime.TabIndex = 3;
            this.txtClarionTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtClarionTime.ValidatingType = typeof(int);
            this.txtClarionTime.Validated += new System.EventHandler(this.TxtClarionTime_Validated);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDate.Location = new System.Drawing.Point(474, 26);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(38, 16);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "Date:";
            // 
            // txtDate
            // 
            this.txtDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDate.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtDate.ForeColor = System.Drawing.Color.White;
            this.txtDate.Location = new System.Drawing.Point(518, 23);
            this.txtDate.Mask = "00/00/0000";
            this.txtDate.Name = "txtDate";
            this.txtDate.PromptChar = ' ';
            this.txtDate.Size = new System.Drawing.Size(80, 23);
            this.txtDate.TabIndex = 5;
            this.txtDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDate.ValidatingType = typeof(System.DateTime);
            this.txtDate.Validated += new System.EventHandler(this.TxtDate_Validated);
            // 
            // lblClarionDate
            // 
            this.lblClarionDate.AutoSize = true;
            this.lblClarionDate.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblClarionDate.Location = new System.Drawing.Point(610, 26);
            this.lblClarionDate.Name = "lblClarionDate";
            this.lblClarionDate.Size = new System.Drawing.Size(82, 16);
            this.lblClarionDate.TabIndex = 6;
            this.lblClarionDate.Text = "Clarion Date:";
            // 
            // txtClarionDate
            // 
            this.txtClarionDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtClarionDate.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtClarionDate.ForeColor = System.Drawing.Color.White;
            this.txtClarionDate.Location = new System.Drawing.Point(698, 23);
            this.txtClarionDate.Mask = "0000000";
            this.txtClarionDate.Name = "txtClarionDate";
            this.txtClarionDate.PromptChar = ' ';
            this.txtClarionDate.Size = new System.Drawing.Size(80, 23);
            this.txtClarionDate.TabIndex = 7;
            this.txtClarionDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtClarionDate.ValidatingType = typeof(int);
            this.txtClarionDate.Validated += new System.EventHandler(this.TxtClarionDate_Validated);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(818, 523);
            this.Controls.Add(this.grpClarionDateTime);
            this.Controls.Add(this.mnsMenuBar);
            this.Controls.Add(this.grpDeleteDuplicate);
            this.Controls.Add(this.pgsFileManagement);
            this.Controls.Add(this.lblProgressPercent);
            this.Controls.Add(this.txtLogProcess);
            this.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Utilities TID";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.grpDeleteDuplicate.ResumeLayout(false);
            this.grpDeleteDuplicate.PerformLayout();
            this.mnsMenuBar.ResumeLayout(false);
            this.mnsMenuBar.PerformLayout();
            this.grpClarionDateTime.ResumeLayout(false);
            this.grpClarionDateTime.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteDuplicate;
        private System.Windows.Forms.ProgressBar pgsFileManagement;
        private System.Windows.Forms.TextBox txtLogProcess;
        private System.Windows.Forms.Label lblProgressPercent;
        private System.Windows.Forms.GroupBox grpDeleteDuplicate;
        private System.Windows.Forms.ComboBox cboOrderBy;
        private System.Windows.Forms.Label lblOrderBy;
        private System.Windows.Forms.ComboBox cboOrderField;
        private System.Windows.Forms.Button btnToBrowser;
        private System.Windows.Forms.Button btnFromBrowser;
        private System.Windows.Forms.Label lblToMoveFiles;
        private System.Windows.Forms.TextBox txtToFolder;
        private System.Windows.Forms.Label lblFromMoveFiles;
        private System.Windows.Forms.Button BtnMoveFiles;
        private System.Windows.Forms.ComboBox cboFileExtension;
        private System.Windows.Forms.Label lblFileExtension;
        private System.Windows.Forms.Button btnCopyFiles;
        private System.Windows.Forms.CheckBox chkSubFolders;
        private System.Windows.Forms.MenuStrip mnsMenuBar;
        private System.Windows.Forms.ToolStripMenuItem mnuCodeToClipoard;
        private System.Windows.Forms.ToolStripMenuItem mnuNotes;
        private System.Windows.Forms.TextBox txtFromFolder;
        private System.Windows.Forms.ToolStripMenuItem mnuScriptWriter;
        private System.Windows.Forms.ToolStripMenuItem tsmCodeToClipboard;
        private System.Windows.Forms.ToolStripMenuItem tsmManageCode;
        private System.Windows.Forms.GroupBox grpClarionDateTime;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.MaskedTextBox txtTime;
        private System.Windows.Forms.Label lblClarionTime;
        private System.Windows.Forms.MaskedTextBox txtClarionTime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.MaskedTextBox txtDate;
        private System.Windows.Forms.Label lblClarionDate;
        private System.Windows.Forms.MaskedTextBox txtClarionDate;
    }
}

