
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
            this.cboCmdCode = new System.Windows.Forms.ComboBox();
            this.lblCmd = new System.Windows.Forms.Label();
            this.txtCodePreview = new System.Windows.Forms.TextBox();
            this.lblClarion = new System.Windows.Forms.Label();
            this.cboClarionCode = new System.Windows.Forms.ComboBox();
            this.btnCopyClipboard = new System.Windows.Forms.Button();
            this.grpClipboardCode.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpClipboardCode
            // 
            this.grpClipboardCode.Controls.Add(this.cboCmdCode);
            this.grpClipboardCode.Controls.Add(this.lblCmd);
            this.grpClipboardCode.Controls.Add(this.txtCodePreview);
            this.grpClipboardCode.Controls.Add(this.lblClarion);
            this.grpClipboardCode.Controls.Add(this.cboClarionCode);
            this.grpClipboardCode.Controls.Add(this.btnCopyClipboard);
            resources.ApplyResources(this.grpClipboardCode, "grpClipboardCode");
            this.grpClipboardCode.ForeColor = System.Drawing.Color.White;
            this.grpClipboardCode.Name = "grpClipboardCode";
            this.grpClipboardCode.TabStop = false;
            // 
            // cboCmdCode
            // 
            this.cboCmdCode.AutoCompleteCustomSource.AddRange(new string[] {
            resources.GetString("cboCmdCode.AutoCompleteCustomSource")});
            this.cboCmdCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cboCmdCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.cboCmdCode, "cboCmdCode");
            this.cboCmdCode.ForeColor = System.Drawing.Color.White;
            this.cboCmdCode.Items.AddRange(new object[] {
            resources.GetString("cboCmdCode.Items")});
            this.cboCmdCode.Name = "cboCmdCode";
            this.cboCmdCode.Sorted = true;
            this.cboCmdCode.SelectedValueChanged += new System.EventHandler(this.cboCmdCode_SelectedValueChanged);
            // 
            // lblCmd
            // 
            resources.ApplyResources(this.lblCmd, "lblCmd");
            this.lblCmd.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCmd.Name = "lblCmd";
            // 
            // txtCodePreview
            // 
            this.txtCodePreview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCodePreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodePreview.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.txtCodePreview, "txtCodePreview");
            this.txtCodePreview.ForeColor = System.Drawing.Color.Lime;
            this.txtCodePreview.Name = "txtCodePreview";
            this.txtCodePreview.ReadOnly = true;
            this.txtCodePreview.TabStop = false;
            // 
            // lblClarion
            // 
            resources.ApplyResources(this.lblClarion, "lblClarion");
            this.lblClarion.ForeColor = System.Drawing.SystemColors.Control;
            this.lblClarion.Name = "lblClarion";
            // 
            // cboClarionCode
            // 
            this.cboClarionCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cboClarionCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.cboClarionCode, "cboClarionCode");
            this.cboClarionCode.ForeColor = System.Drawing.Color.White;
            this.cboClarionCode.Items.AddRange(new object[] {
            resources.GetString("cboClarionCode.Items"),
            resources.GetString("cboClarionCode.Items1"),
            resources.GetString("cboClarionCode.Items2"),
            resources.GetString("cboClarionCode.Items3"),
            resources.GetString("cboClarionCode.Items4"),
            resources.GetString("cboClarionCode.Items5"),
            resources.GetString("cboClarionCode.Items6"),
            resources.GetString("cboClarionCode.Items7"),
            resources.GetString("cboClarionCode.Items8"),
            resources.GetString("cboClarionCode.Items9"),
            resources.GetString("cboClarionCode.Items10"),
            resources.GetString("cboClarionCode.Items11"),
            resources.GetString("cboClarionCode.Items12"),
            resources.GetString("cboClarionCode.Items13"),
            resources.GetString("cboClarionCode.Items14"),
            resources.GetString("cboClarionCode.Items15"),
            resources.GetString("cboClarionCode.Items16"),
            resources.GetString("cboClarionCode.Items17"),
            resources.GetString("cboClarionCode.Items18"),
            resources.GetString("cboClarionCode.Items19"),
            resources.GetString("cboClarionCode.Items20")});
            this.cboClarionCode.Name = "cboClarionCode";
            this.cboClarionCode.Sorted = true;
            this.cboClarionCode.SelectedValueChanged += new System.EventHandler(this.ComboCodeClipboard_SelectedValueChanged);
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
            this.grpClipboardCode.ResumeLayout(false);
            this.grpClipboardCode.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpClipboardCode;
        private System.Windows.Forms.Label lblClarion;
        private System.Windows.Forms.ComboBox cboClarionCode;
        private System.Windows.Forms.Button btnCopyClipboard;
        private System.Windows.Forms.TextBox txtCodePreview;
        private System.Windows.Forms.Label lblCmd;
        private System.Windows.Forms.ComboBox cboCmdCode;
    }
}