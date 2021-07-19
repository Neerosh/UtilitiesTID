
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
            this.lblCodeClipboard = new System.Windows.Forms.Label();
            this.cboCodeClipboard = new System.Windows.Forms.ComboBox();
            this.btnCopyClipboard = new System.Windows.Forms.Button();
            this.grpClipboardCode.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpClipboardCode
            // 
            this.grpClipboardCode.Controls.Add(this.txtCodePreview);
            this.grpClipboardCode.Controls.Add(this.lblCodeClipboard);
            this.grpClipboardCode.Controls.Add(this.cboCodeClipboard);
            this.grpClipboardCode.Controls.Add(this.btnCopyClipboard);
            this.grpClipboardCode.Font = new System.Drawing.Font("Arial", 10F);
            this.grpClipboardCode.ForeColor = System.Drawing.Color.White;
            this.grpClipboardCode.Location = new System.Drawing.Point(14, 15);
            this.grpClipboardCode.Name = "grpClipboardCode";
            this.grpClipboardCode.Size = new System.Drawing.Size(793, 377);
            this.grpClipboardCode.TabIndex = 0;
            this.grpClipboardCode.TabStop = false;
            this.grpClipboardCode.Text = "Code to Clipboard";
            // 
            // txtCodePreview
            // 
            this.txtCodePreview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCodePreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodePreview.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtCodePreview.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodePreview.ForeColor = System.Drawing.Color.Lime;
            this.txtCodePreview.Location = new System.Drawing.Point(17, 79);
            this.txtCodePreview.Multiline = true;
            this.txtCodePreview.Name = "txtCodePreview";
            this.txtCodePreview.ReadOnly = true;
            this.txtCodePreview.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCodePreview.Size = new System.Drawing.Size(758, 283);
            this.txtCodePreview.TabIndex = 3;
            this.txtCodePreview.TabStop = false;
            // 
            // lblCodeClipboard
            // 
            this.lblCodeClipboard.AutoSize = true;
            this.lblCodeClipboard.Font = new System.Drawing.Font("Arial", 9.5F);
            this.lblCodeClipboard.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCodeClipboard.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblCodeClipboard.Location = new System.Drawing.Point(19, 32);
            this.lblCodeClipboard.Name = "lblCodeClipboard";
            this.lblCodeClipboard.Size = new System.Drawing.Size(52, 16);
            this.lblCodeClipboard.TabIndex = 0;
            this.lblCodeClipboard.Text = "Clarion:";
            // 
            // cboCodeClipboard
            // 
            this.cboCodeClipboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cboCodeClipboard.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCodeClipboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboCodeClipboard.Font = new System.Drawing.Font("Arial", 9.5F);
            this.cboCodeClipboard.ForeColor = System.Drawing.Color.White;
            this.cboCodeClipboard.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cboCodeClipboard.Items.AddRange(new object[] {
            "Acronym (Default Test)",
            "APP (Allow only one Instance)",
            "Column (Width Change)",
            "Column Group (Width Change)",
            "Directory (Create)",
            "Message (Error)",
            "Message (Warning)",
            "Message Case (Yes/No)",
            "Message TID (Error)",
            "Message TID (Warning)",
            "Owner Database (Get)",
            "Print (Multiline String Manually) ",
            "Process Label (Change Text Down)",
            "Process Label (Change Text Up)",
            "Queue (Add Record)",
            "TabelaSQL (Select)",
            "TabelaSQL (Update)",
            "Window (Force Refresh)"});
            this.cboCodeClipboard.Location = new System.Drawing.Point(77, 29);
            this.cboCodeClipboard.Name = "cboCodeClipboard";
            this.cboCodeClipboard.Size = new System.Drawing.Size(262, 24);
            this.cboCodeClipboard.Sorted = true;
            this.cboCodeClipboard.TabIndex = 1;
            this.cboCodeClipboard.SelectedValueChanged += new System.EventHandler(this.ComboCodeClipboard_SelectedValueChanged);
            // 
            // btnCopyClipboard
            // 
            this.btnCopyClipboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCopyClipboard.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCopyClipboard.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnCopyClipboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopyClipboard.Font = new System.Drawing.Font("Arial", 9.5F);
            this.btnCopyClipboard.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCopyClipboard.Image = global::Utilities.Properties.Resources.icons8_copy_32;
            this.btnCopyClipboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCopyClipboard.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCopyClipboard.Location = new System.Drawing.Point(606, 22);
            this.btnCopyClipboard.Name = "btnCopyClipboard";
            this.btnCopyClipboard.Size = new System.Drawing.Size(169, 47);
            this.btnCopyClipboard.TabIndex = 2;
            this.btnCopyClipboard.Text = "Copy to Clipboard";
            this.btnCopyClipboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCopyClipboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCopyClipboard.UseVisualStyleBackColor = false;
            this.btnCopyClipboard.Click += new System.EventHandler(this.BtnCopyClipboard_Click);
            // 
            // CodeToClipboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(820, 402);
            this.Controls.Add(this.grpClipboardCode);
            this.Font = new System.Drawing.Font("Arial", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CodeToClipboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Code to Clipboard";
            this.grpClipboardCode.ResumeLayout(false);
            this.grpClipboardCode.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpClipboardCode;
        private System.Windows.Forms.Label lblCodeClipboard;
        private System.Windows.Forms.ComboBox cboCodeClipboard;
        private System.Windows.Forms.Button btnCopyClipboard;
        private System.Windows.Forms.TextBox txtCodePreview;
    }
}