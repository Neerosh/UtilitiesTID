
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
            this.mnuClarionDateTime = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCodeToClipoard = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuScriptWriter = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNotes = new System.Windows.Forms.ToolStripMenuItem();
            this.grpDeleteDuplicate.SuspendLayout();
            this.mnsMenuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pgsFileManagement
            // 
            resources.ApplyResources(this.pgsFileManagement, "pgsFileManagement");
            this.pgsFileManagement.Name = "pgsFileManagement";
            // 
            // txtLogProcess
            // 
            this.txtLogProcess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtLogProcess.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLogProcess.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.txtLogProcess, "txtLogProcess");
            this.txtLogProcess.ForeColor = System.Drawing.Color.Lime;
            this.txtLogProcess.Name = "txtLogProcess";
            this.txtLogProcess.ReadOnly = true;
            this.txtLogProcess.TabStop = false;
            // 
            // lblProgressPercent
            // 
            resources.ApplyResources(this.lblProgressPercent, "lblProgressPercent");
            this.lblProgressPercent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblProgressPercent.ForeColor = System.Drawing.SystemColors.Control;
            this.lblProgressPercent.Name = "lblProgressPercent";
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
            resources.ApplyResources(this.grpDeleteDuplicate, "grpDeleteDuplicate");
            this.grpDeleteDuplicate.ForeColor = System.Drawing.SystemColors.Control;
            this.grpDeleteDuplicate.Name = "grpDeleteDuplicate";
            this.grpDeleteDuplicate.TabStop = false;
            // 
            // lblFromMoveFiles
            // 
            resources.ApplyResources(this.lblFromMoveFiles, "lblFromMoveFiles");
            this.lblFromMoveFiles.ForeColor = System.Drawing.SystemColors.Control;
            this.lblFromMoveFiles.Name = "lblFromMoveFiles";
            // 
            // txtFromFolder
            // 
            this.txtFromFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            resources.ApplyResources(this.txtFromFolder, "txtFromFolder");
            this.txtFromFolder.ForeColor = System.Drawing.Color.White;
            this.txtFromFolder.Name = "txtFromFolder";
            // 
            // btnFromBrowser
            // 
            this.btnFromBrowser.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnFromBrowser.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            resources.ApplyResources(this.btnFromBrowser, "btnFromBrowser");
            this.btnFromBrowser.ForeColor = System.Drawing.Color.White;
            this.btnFromBrowser.Name = "btnFromBrowser";
            this.btnFromBrowser.UseVisualStyleBackColor = true;
            this.btnFromBrowser.Click += new System.EventHandler(this.BtnFromBrowser_Click);
            // 
            // lblToMoveFiles
            // 
            resources.ApplyResources(this.lblToMoveFiles, "lblToMoveFiles");
            this.lblToMoveFiles.ForeColor = System.Drawing.SystemColors.Control;
            this.lblToMoveFiles.Name = "lblToMoveFiles";
            // 
            // txtToFolder
            // 
            this.txtToFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            resources.ApplyResources(this.txtToFolder, "txtToFolder");
            this.txtToFolder.ForeColor = System.Drawing.Color.White;
            this.txtToFolder.Name = "txtToFolder";
            // 
            // btnToBrowser
            // 
            this.btnToBrowser.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnToBrowser.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            resources.ApplyResources(this.btnToBrowser, "btnToBrowser");
            this.btnToBrowser.ForeColor = System.Drawing.Color.White;
            this.btnToBrowser.Name = "btnToBrowser";
            this.btnToBrowser.UseVisualStyleBackColor = true;
            this.btnToBrowser.Click += new System.EventHandler(this.BtnToBrowser_Click);
            // 
            // lblOrderBy
            // 
            resources.ApplyResources(this.lblOrderBy, "lblOrderBy");
            this.lblOrderBy.ForeColor = System.Drawing.SystemColors.Control;
            this.lblOrderBy.Name = "lblOrderBy";
            // 
            // cboOrderBy
            // 
            this.cboOrderBy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cboOrderBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.cboOrderBy, "cboOrderBy");
            this.cboOrderBy.ForeColor = System.Drawing.Color.White;
            this.cboOrderBy.Items.AddRange(new object[] {
            resources.GetString("cboOrderBy.Items"),
            resources.GetString("cboOrderBy.Items1")});
            this.cboOrderBy.Name = "cboOrderBy";
            // 
            // cboOrderField
            // 
            this.cboOrderField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cboOrderField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.cboOrderField, "cboOrderField");
            this.cboOrderField.ForeColor = System.Drawing.Color.White;
            this.cboOrderField.Items.AddRange(new object[] {
            resources.GetString("cboOrderField.Items"),
            resources.GetString("cboOrderField.Items1")});
            this.cboOrderField.Name = "cboOrderField";
            // 
            // lblFileExtension
            // 
            resources.ApplyResources(this.lblFileExtension, "lblFileExtension");
            this.lblFileExtension.ForeColor = System.Drawing.SystemColors.Control;
            this.lblFileExtension.Name = "lblFileExtension";
            // 
            // cboFileExtension
            // 
            this.cboFileExtension.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cboFileExtension.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.cboFileExtension, "cboFileExtension");
            this.cboFileExtension.ForeColor = System.Drawing.Color.White;
            this.cboFileExtension.Items.AddRange(new object[] {
            resources.GetString("cboFileExtension.Items"),
            resources.GetString("cboFileExtension.Items1"),
            resources.GetString("cboFileExtension.Items2"),
            resources.GetString("cboFileExtension.Items3"),
            resources.GetString("cboFileExtension.Items4"),
            resources.GetString("cboFileExtension.Items5")});
            this.cboFileExtension.Name = "cboFileExtension";
            // 
            // chkSubFolders
            // 
            resources.ApplyResources(this.chkSubFolders, "chkSubFolders");
            this.chkSubFolders.Name = "chkSubFolders";
            this.chkSubFolders.UseVisualStyleBackColor = true;
            // 
            // btnCopyFiles
            // 
            this.btnCopyFiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCopyFiles.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCopyFiles.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            resources.ApplyResources(this.btnCopyFiles, "btnCopyFiles");
            this.btnCopyFiles.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCopyFiles.Image = global::Utilities.Properties.Resources.icons8_copy_32;
            this.btnCopyFiles.Name = "btnCopyFiles";
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
            resources.ApplyResources(this.btnDeleteDuplicate, "btnDeleteDuplicate");
            this.btnDeleteDuplicate.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDeleteDuplicate.Image = global::Utilities.Properties.Resources.icons8_delete_file2_32;
            this.btnDeleteDuplicate.Name = "btnDeleteDuplicate";
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
            resources.ApplyResources(this.BtnMoveFiles, "BtnMoveFiles");
            this.BtnMoveFiles.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnMoveFiles.Image = global::Utilities.Properties.Resources.icons8_send_file_32;
            this.BtnMoveFiles.Name = "BtnMoveFiles";
            this.BtnMoveFiles.UseVisualStyleBackColor = false;
            this.BtnMoveFiles.Click += new System.EventHandler(this.BtnMoveFiles_Click);
            this.BtnMoveFiles.MouseLeave += new System.EventHandler(this.BtnMoveFiles_MouseLeave);
            this.BtnMoveFiles.MouseHover += new System.EventHandler(this.BtnMoveFiles_MouseHover);
            // 
            // mnsMenuBar
            // 
            this.mnsMenuBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            resources.ApplyResources(this.mnsMenuBar, "mnsMenuBar");
            this.mnsMenuBar.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.mnsMenuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuClarionDateTime,
            this.mnuCodeToClipoard,
            this.mnuScriptWriter,
            this.mnuNotes});
            this.mnsMenuBar.Name = "mnsMenuBar";
            this.mnsMenuBar.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            // 
            // mnuClarionDateTime
            // 
            this.mnuClarionDateTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            resources.ApplyResources(this.mnuClarionDateTime, "mnuClarionDateTime");
            this.mnuClarionDateTime.ForeColor = System.Drawing.Color.White;
            this.mnuClarionDateTime.Image = global::Utilities.Properties.Resources.icons8_clock_32;
            this.mnuClarionDateTime.MergeIndex = 0;
            this.mnuClarionDateTime.Name = "mnuClarionDateTime";
            this.mnuClarionDateTime.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.mnuClarionDateTime.Click += new System.EventHandler(this.MenuClarionDateTime_Click);
            // 
            // mnuCodeToClipoard
            // 
            resources.ApplyResources(this.mnuCodeToClipoard, "mnuCodeToClipoard");
            this.mnuCodeToClipoard.ForeColor = System.Drawing.Color.White;
            this.mnuCodeToClipoard.Image = global::Utilities.Properties.Resources.icons8_data_32;
            this.mnuCodeToClipoard.Name = "mnuCodeToClipoard";
            this.mnuCodeToClipoard.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.mnuCodeToClipoard.Click += new System.EventHandler(this.MenuCodeToclipoard_Click);
            // 
            // mnuScriptWriter
            // 
            resources.ApplyResources(this.mnuScriptWriter, "mnuScriptWriter");
            this.mnuScriptWriter.ForeColor = System.Drawing.Color.White;
            this.mnuScriptWriter.Image = global::Utilities.Properties.Resources.icons8_scroll_32;
            this.mnuScriptWriter.Name = "mnuScriptWriter";
            this.mnuScriptWriter.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.mnuScriptWriter.Click += new System.EventHandler(this.MenuScriptWriter_Click);
            // 
            // mnuNotes
            // 
            this.mnuNotes.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            resources.ApplyResources(this.mnuNotes, "mnuNotes");
            this.mnuNotes.ForeColor = System.Drawing.Color.White;
            this.mnuNotes.Image = global::Utilities.Properties.Resources.icons8_info_squared_32;
            this.mnuNotes.Name = "mnuNotes";
            this.mnuNotes.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.mnuNotes.Click += new System.EventHandler(this.MenuNotes_Click);
            // 
            // Main
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.mnsMenuBar);
            this.Controls.Add(this.grpDeleteDuplicate);
            this.Controls.Add(this.pgsFileManagement);
            this.Controls.Add(this.lblProgressPercent);
            this.Controls.Add(this.txtLogProcess);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.grpDeleteDuplicate.ResumeLayout(false);
            this.grpDeleteDuplicate.PerformLayout();
            this.mnsMenuBar.ResumeLayout(false);
            this.mnsMenuBar.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem mnuClarionDateTime;
        private System.Windows.Forms.ToolStripMenuItem mnuCodeToClipoard;
        private System.Windows.Forms.ToolStripMenuItem mnuNotes;
        private System.Windows.Forms.TextBox txtFromFolder;
        private System.Windows.Forms.ToolStripMenuItem mnuScriptWriter;
    }
}

