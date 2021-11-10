
namespace Utilities
{
    partial class CodeToClipboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CodeToClipboard));
            this.grpClipboardCode = new System.Windows.Forms.GroupBox();
            this.txtCodePreview = new System.Windows.Forms.TextBox();
            this.cboCodeType = new System.Windows.Forms.ComboBox();
            this.lblCodeType = new System.Windows.Forms.Label();
            this.lblCodeName = new System.Windows.Forms.Label();
            this.cboCodeName = new System.Windows.Forms.ComboBox();
            this.btnCopyClipboard = new System.Windows.Forms.Button();
            this.grpClipboardCode.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpClipboardCode
            // 
            this.grpClipboardCode.Controls.Add(this.txtCodePreview);
            this.grpClipboardCode.Controls.Add(this.cboCodeType);
            this.grpClipboardCode.Controls.Add(this.lblCodeType);
            this.grpClipboardCode.Controls.Add(this.lblCodeName);
            this.grpClipboardCode.Controls.Add(this.cboCodeName);
            this.grpClipboardCode.Controls.Add(this.btnCopyClipboard);
            resources.ApplyResources(this.grpClipboardCode, "grpClipboardCode");
            this.grpClipboardCode.ForeColor = System.Drawing.Color.White;
            this.grpClipboardCode.Name = "grpClipboardCode";
            this.grpClipboardCode.TabStop = false;
            // 
            // txtCodePreview
            // 
            this.txtCodePreview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCodePreview.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.txtCodePreview, "txtCodePreview");
            this.txtCodePreview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(102)))), ((int)(((byte)(255)))));
            this.txtCodePreview.Name = "txtCodePreview";
            this.txtCodePreview.ReadOnly = true;
            this.txtCodePreview.TabStop = false;
            // 
            // cboCodeType
            // 
            this.cboCodeType.AutoCompleteCustomSource.AddRange(new string[] {
            resources.GetString("cboCodeType.AutoCompleteCustomSource")});
            this.cboCodeType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cboCodeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.cboCodeType, "cboCodeType");
            this.cboCodeType.ForeColor = System.Drawing.Color.White;
            this.cboCodeType.Items.AddRange(new object[] {
            resources.GetString("cboCodeType.Items")});
            this.cboCodeType.Name = "cboCodeType";
            this.cboCodeType.Sorted = true;
            this.cboCodeType.SelectedValueChanged += new System.EventHandler(this.cboCodeType_SelectedValueChanged);
            // 
            // lblCodeType
            // 
            resources.ApplyResources(this.lblCodeType, "lblCodeType");
            this.lblCodeType.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCodeType.Name = "lblCodeType";
            // 
            // lblCodeName
            // 
            resources.ApplyResources(this.lblCodeName, "lblCodeName");
            this.lblCodeName.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCodeName.Name = "lblCodeName";
            // 
            // cboCodeName
            // 
            this.cboCodeName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cboCodeName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.cboCodeName, "cboCodeName");
            this.cboCodeName.ForeColor = System.Drawing.Color.White;
            this.cboCodeName.Name = "cboCodeName";
            this.cboCodeName.Sorted = true;
            this.cboCodeName.SelectedValueChanged += new System.EventHandler(this.CboCodeName_SelectedValueChanged);
            // 
            // btnCopyClipboard
            // 
            this.btnCopyClipboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCopyClipboard.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCopyClipboard.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            resources.ApplyResources(this.btnCopyClipboard, "btnCopyClipboard");
            this.btnCopyClipboard.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCopyClipboard.Image = global::Utilities.Properties.Resources.icons8_copy_32;
            this.btnCopyClipboard.Name = "btnCopyClipboard";
            this.btnCopyClipboard.UseVisualStyleBackColor = false;
            this.btnCopyClipboard.Click += new System.EventHandler(this.BtnCopyClipboard_Click);
            // 
            // CodeToClipboard
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.grpClipboardCode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CodeToClipboard";
            this.Load += new System.EventHandler(this.CodeToClipboard_Load);
            this.grpClipboardCode.ResumeLayout(false);
            this.grpClipboardCode.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpClipboardCode;
        private System.Windows.Forms.Label lblCodeName;
        private System.Windows.Forms.ComboBox cboCodeName;
        private System.Windows.Forms.Button btnCopyClipboard;
        private System.Windows.Forms.TextBox txtCodePreview;
        private System.Windows.Forms.Label lblCodeType;
        private System.Windows.Forms.ComboBox cboCodeType;
    }
}