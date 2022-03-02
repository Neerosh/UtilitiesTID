
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
            this.cboCodeType = new System.Windows.Forms.ComboBox();
            this.lblCodeType = new System.Windows.Forms.Label();
            this.lblCodeName = new System.Windows.Forms.Label();
            this.cboCodeName = new System.Windows.Forms.ComboBox();
            this.btnCopyClipboard = new System.Windows.Forms.Button();
            this.txtCodePreview = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // cboCodeType
            // 
            this.cboCodeType.AutoCompleteCustomSource.AddRange(new string[] {
            resources.GetString("cboCodeType.AutoCompleteCustomSource")});
            this.cboCodeType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
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
            this.cboCodeName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.cboCodeName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.cboCodeName, "cboCodeName");
            this.cboCodeName.ForeColor = System.Drawing.Color.White;
            this.cboCodeName.Name = "cboCodeName";
            this.cboCodeName.Sorted = true;
            this.cboCodeName.SelectedValueChanged += new System.EventHandler(this.CboCodeName_SelectedValueChanged);
            // 
            // btnCopyClipboard
            // 
            resources.ApplyResources(this.btnCopyClipboard, "btnCopyClipboard");
            this.btnCopyClipboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnCopyClipboard.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCopyClipboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btnCopyClipboard.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCopyClipboard.Image = global::Utilities.Properties.Resources.icons8_copy_to_clipboard_32;
            this.btnCopyClipboard.Name = "btnCopyClipboard";
            this.btnCopyClipboard.UseVisualStyleBackColor = false;
            this.btnCopyClipboard.Click += new System.EventHandler(this.BtnCopyClipboard_Click);
            // 
            // txtCodePreview
            // 
            resources.ApplyResources(this.txtCodePreview, "txtCodePreview");
            this.txtCodePreview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtCodePreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodePreview.ForeColor = System.Drawing.Color.White;
            this.txtCodePreview.Name = "txtCodePreview";
            this.txtCodePreview.ReadOnly = true;
            // 
            // CodeToClipboard
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Controls.Add(this.txtCodePreview);
            this.Controls.Add(this.cboCodeType);
            this.Controls.Add(this.lblCodeName);
            this.Controls.Add(this.lblCodeType);
            this.Controls.Add(this.btnCopyClipboard);
            this.Controls.Add(this.cboCodeName);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "CodeToClipboard";
            this.Load += new System.EventHandler(this.CodeToClipboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCodeName;
        private System.Windows.Forms.ComboBox cboCodeName;
        private System.Windows.Forms.Button btnCopyClipboard;
        private System.Windows.Forms.Label lblCodeType;
        private System.Windows.Forms.ComboBox cboCodeType;
        private System.Windows.Forms.RichTextBox txtCodePreview;
    }
}