
namespace Utilities.Forms {
    partial class ScriptWriter {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScriptWriter));
            this.btnScriptRegular = new System.Windows.Forms.Button();
            this.txtProcedureName = new System.Windows.Forms.TextBox();
            this.lblProcedureName = new System.Windows.Forms.Label();
            this.txtScriptName = new System.Windows.Forms.TextBox();
            this.lblScriptName = new System.Windows.Forms.Label();
            this.btnScriptFolderBrowser = new System.Windows.Forms.Button();
            this.btnFolderSQLBrowser = new System.Windows.Forms.Button();
            this.lblScriptFolder = new System.Windows.Forms.Label();
            this.txtScriptFolder = new System.Windows.Forms.TextBox();
            this.lblSQLFolder = new System.Windows.Forms.Label();
            this.txtFolderSQL = new System.Windows.Forms.TextBox();
            this.btnScriptUnified = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnScriptRegular
            // 
            this.btnScriptRegular.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnScriptRegular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnScriptRegular.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnScriptRegular.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btnScriptRegular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScriptRegular.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnScriptRegular.ForeColor = System.Drawing.SystemColors.Control;
            this.btnScriptRegular.Image = global::Utilities.Properties.Resources.icons8_inscription_32;
            this.btnScriptRegular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnScriptRegular.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnScriptRegular.Location = new System.Drawing.Point(634, 24);
            this.btnScriptRegular.Name = "btnScriptRegular";
            this.btnScriptRegular.Size = new System.Drawing.Size(136, 40);
            this.btnScriptRegular.TabIndex = 17;
            this.btnScriptRegular.Text = "Generate Regular Script\r\n";
            this.btnScriptRegular.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnScriptRegular.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnScriptRegular.UseVisualStyleBackColor = false;
            this.btnScriptRegular.Click += new System.EventHandler(this.BtnScriptRegular_Click);
            this.btnScriptRegular.MouseLeave += new System.EventHandler(this.BtnScriptRegular_MouseLeave);
            this.btnScriptRegular.MouseHover += new System.EventHandler(this.BtnScriptRegular_MouseHover);
            // 
            // txtProcedureName
            // 
            this.txtProcedureName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtProcedureName.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtProcedureName.ForeColor = System.Drawing.Color.White;
            this.txtProcedureName.Location = new System.Drawing.Point(111, 121);
            this.txtProcedureName.MaxLength = 20;
            this.txtProcedureName.Name = "txtProcedureName";
            this.txtProcedureName.Size = new System.Drawing.Size(200, 22);
            this.txtProcedureName.TabIndex = 16;
            // 
            // lblProcedureName
            // 
            this.lblProcedureName.AutoSize = true;
            this.lblProcedureName.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblProcedureName.ForeColor = System.Drawing.SystemColors.Control;
            this.lblProcedureName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblProcedureName.Location = new System.Drawing.Point(25, 124);
            this.lblProcedureName.Name = "lblProcedureName";
            this.lblProcedureName.Size = new System.Drawing.Size(80, 16);
            this.lblProcedureName.TabIndex = 15;
            this.lblProcedureName.Text = "Proc. Name:";
            // 
            // txtScriptName
            // 
            this.txtScriptName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtScriptName.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtScriptName.ForeColor = System.Drawing.Color.White;
            this.txtScriptName.Location = new System.Drawing.Point(111, 89);
            this.txtScriptName.MaxLength = 20;
            this.txtScriptName.Name = "txtScriptName";
            this.txtScriptName.Size = new System.Drawing.Size(200, 22);
            this.txtScriptName.TabIndex = 14;
            // 
            // lblScriptName
            // 
            this.lblScriptName.AutoSize = true;
            this.lblScriptName.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblScriptName.ForeColor = System.Drawing.SystemColors.Control;
            this.lblScriptName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblScriptName.Location = new System.Drawing.Point(22, 92);
            this.lblScriptName.Name = "lblScriptName";
            this.lblScriptName.Size = new System.Drawing.Size(83, 16);
            this.lblScriptName.TabIndex = 13;
            this.lblScriptName.Text = "Script Name:";
            // 
            // btnScriptFolderBrowser
            // 
            this.btnScriptFolderBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnScriptFolderBrowser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnScriptFolderBrowser.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnScriptFolderBrowser.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnScriptFolderBrowser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScriptFolderBrowser.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnScriptFolderBrowser.ForeColor = System.Drawing.Color.White;
            this.btnScriptFolderBrowser.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnScriptFolderBrowser.Location = new System.Drawing.Point(589, 56);
            this.btnScriptFolderBrowser.Name = "btnScriptFolderBrowser";
            this.btnScriptFolderBrowser.Size = new System.Drawing.Size(30, 25);
            this.btnScriptFolderBrowser.TabIndex = 12;
            this.btnScriptFolderBrowser.Text = "...";
            this.btnScriptFolderBrowser.UseVisualStyleBackColor = false;
            this.btnScriptFolderBrowser.Click += new System.EventHandler(this.BtnPathScriptBrowser_Click);
            // 
            // btnFolderSQLBrowser
            // 
            this.btnFolderSQLBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFolderSQLBrowser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnFolderSQLBrowser.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnFolderSQLBrowser.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnFolderSQLBrowser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFolderSQLBrowser.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFolderSQLBrowser.ForeColor = System.Drawing.Color.White;
            this.btnFolderSQLBrowser.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnFolderSQLBrowser.Location = new System.Drawing.Point(589, 24);
            this.btnFolderSQLBrowser.Name = "btnFolderSQLBrowser";
            this.btnFolderSQLBrowser.Size = new System.Drawing.Size(30, 25);
            this.btnFolderSQLBrowser.TabIndex = 11;
            this.btnFolderSQLBrowser.Text = "...";
            this.btnFolderSQLBrowser.UseVisualStyleBackColor = false;
            this.btnFolderSQLBrowser.Click += new System.EventHandler(this.BtnPathFolderSQLBrowser_Click);
            // 
            // lblScriptFolder
            // 
            this.lblScriptFolder.AutoSize = true;
            this.lblScriptFolder.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblScriptFolder.ForeColor = System.Drawing.SystemColors.Control;
            this.lblScriptFolder.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblScriptFolder.Location = new System.Drawing.Point(20, 60);
            this.lblScriptFolder.Name = "lblScriptFolder";
            this.lblScriptFolder.Size = new System.Drawing.Size(85, 16);
            this.lblScriptFolder.TabIndex = 9;
            this.lblScriptFolder.Text = "Script Folder:";
            // 
            // txtScriptFolder
            // 
            this.txtScriptFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtScriptFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtScriptFolder.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtScriptFolder.ForeColor = System.Drawing.Color.White;
            this.txtScriptFolder.Location = new System.Drawing.Point(111, 57);
            this.txtScriptFolder.Name = "txtScriptFolder";
            this.txtScriptFolder.Size = new System.Drawing.Size(472, 22);
            this.txtScriptFolder.TabIndex = 10;
            // 
            // lblSQLFolder
            // 
            this.lblSQLFolder.AutoSize = true;
            this.lblSQLFolder.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSQLFolder.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSQLFolder.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblSQLFolder.Location = new System.Drawing.Point(28, 28);
            this.lblSQLFolder.Name = "lblSQLFolder";
            this.lblSQLFolder.Size = new System.Drawing.Size(77, 16);
            this.lblSQLFolder.TabIndex = 7;
            this.lblSQLFolder.Text = "SQL Folder:";
            // 
            // txtFolderSQL
            // 
            this.txtFolderSQL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFolderSQL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtFolderSQL.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtFolderSQL.ForeColor = System.Drawing.Color.White;
            this.txtFolderSQL.Location = new System.Drawing.Point(111, 25);
            this.txtFolderSQL.Name = "txtFolderSQL";
            this.txtFolderSQL.Size = new System.Drawing.Size(472, 22);
            this.txtFolderSQL.TabIndex = 8;
            // 
            // btnScriptUnified
            // 
            this.btnScriptUnified.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnScriptUnified.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnScriptUnified.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnScriptUnified.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btnScriptUnified.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScriptUnified.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnScriptUnified.ForeColor = System.Drawing.SystemColors.Control;
            this.btnScriptUnified.Image = global::Utilities.Properties.Resources.icons8_compose_32;
            this.btnScriptUnified.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnScriptUnified.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnScriptUnified.Location = new System.Drawing.Point(634, 70);
            this.btnScriptUnified.Name = "btnScriptUnified";
            this.btnScriptUnified.Size = new System.Drawing.Size(136, 40);
            this.btnScriptUnified.TabIndex = 6;
            this.btnScriptUnified.Text = "Generate Unified Script\r\n";
            this.btnScriptUnified.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnScriptUnified.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnScriptUnified.UseVisualStyleBackColor = false;
            this.btnScriptUnified.Click += new System.EventHandler(this.BtnScriptUnified_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Image = global::Utilities.Properties.Resources.icons8_compose_32;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(620, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 40);
            this.button1.TabIndex = 18;
            this.button1.Text = "Generate Unified Script test\r\n";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ScriptWriter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(790, 570);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnScriptRegular);
            this.Controls.Add(this.txtProcedureName);
            this.Controls.Add(this.lblSQLFolder);
            this.Controls.Add(this.lblProcedureName);
            this.Controls.Add(this.btnScriptUnified);
            this.Controls.Add(this.txtScriptName);
            this.Controls.Add(this.txtFolderSQL);
            this.Controls.Add(this.lblScriptName);
            this.Controls.Add(this.txtScriptFolder);
            this.Controls.Add(this.btnScriptFolderBrowser);
            this.Controls.Add(this.lblScriptFolder);
            this.Controls.Add(this.btnFolderSQLBrowser);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ScriptWriter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Script Writer";
            this.Load += new System.EventHandler(this.ScriptWriter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnScriptRegular;
        private System.Windows.Forms.TextBox txtProcedureName;
        private System.Windows.Forms.Label lblProcedureName;
        private System.Windows.Forms.TextBox txtScriptName;
        private System.Windows.Forms.Label lblScriptName;
        private System.Windows.Forms.Button btnScriptFolderBrowser;
        private System.Windows.Forms.Button btnFolderSQLBrowser;
        private System.Windows.Forms.Label lblScriptFolder;
        private System.Windows.Forms.TextBox txtScriptFolder;
        private System.Windows.Forms.Label lblSQLFolder;
        private System.Windows.Forms.TextBox txtFolderSQL;
        private System.Windows.Forms.Button btnScriptUnified;
        private System.Windows.Forms.Button button1;
    }
}