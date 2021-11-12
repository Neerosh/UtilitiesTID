
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
            this.grpSQLScripts = new System.Windows.Forms.GroupBox();
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
            this.grpSQLScripts.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpSQLScripts
            // 
            this.grpSQLScripts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.grpSQLScripts.Controls.Add(this.btnScriptRegular);
            this.grpSQLScripts.Controls.Add(this.txtProcedureName);
            this.grpSQLScripts.Controls.Add(this.lblProcedureName);
            this.grpSQLScripts.Controls.Add(this.txtScriptName);
            this.grpSQLScripts.Controls.Add(this.lblScriptName);
            this.grpSQLScripts.Controls.Add(this.btnScriptFolderBrowser);
            this.grpSQLScripts.Controls.Add(this.btnFolderSQLBrowser);
            this.grpSQLScripts.Controls.Add(this.lblScriptFolder);
            this.grpSQLScripts.Controls.Add(this.txtScriptFolder);
            this.grpSQLScripts.Controls.Add(this.lblSQLFolder);
            this.grpSQLScripts.Controls.Add(this.txtFolderSQL);
            this.grpSQLScripts.Controls.Add(this.btnScriptUnified);
            this.grpSQLScripts.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpSQLScripts.ForeColor = System.Drawing.SystemColors.Control;
            this.grpSQLScripts.Location = new System.Drawing.Point(12, 12);
            this.grpSQLScripts.Name = "grpSQLScripts";
            this.grpSQLScripts.Size = new System.Drawing.Size(579, 160);
            this.grpSQLScripts.TabIndex = 9;
            this.grpSQLScripts.TabStop = false;
            this.grpSQLScripts.Text = "SQL Scripts";
            // 
            // btnScriptRegular
            // 
            this.btnScriptRegular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnScriptRegular.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnScriptRegular.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btnScriptRegular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScriptRegular.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnScriptRegular.ForeColor = System.Drawing.SystemColors.Control;
            this.btnScriptRegular.Image = global::Utilities.Properties.Resources.icons8_inscription_32;
            this.btnScriptRegular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnScriptRegular.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnScriptRegular.Location = new System.Drawing.Point(291, 93);
            this.btnScriptRegular.Name = "btnScriptRegular";
            this.btnScriptRegular.Size = new System.Drawing.Size(133, 51);
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
            this.txtProcedureName.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtProcedureName.ForeColor = System.Drawing.Color.White;
            this.txtProcedureName.Location = new System.Drawing.Point(116, 122);
            this.txtProcedureName.MaxLength = 20;
            this.txtProcedureName.Name = "txtProcedureName";
            this.txtProcedureName.Size = new System.Drawing.Size(159, 22);
            this.txtProcedureName.TabIndex = 16;
            // 
            // lblProcedureName
            // 
            this.lblProcedureName.AutoSize = true;
            this.lblProcedureName.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblProcedureName.ForeColor = System.Drawing.SystemColors.Control;
            this.lblProcedureName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblProcedureName.Location = new System.Drawing.Point(5, 125);
            this.lblProcedureName.Name = "lblProcedureName";
            this.lblProcedureName.Size = new System.Drawing.Size(108, 16);
            this.lblProcedureName.TabIndex = 15;
            this.lblProcedureName.Text = "Procedure Name:";
            // 
            // txtScriptName
            // 
            this.txtScriptName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtScriptName.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtScriptName.ForeColor = System.Drawing.Color.White;
            this.txtScriptName.Location = new System.Drawing.Point(102, 91);
            this.txtScriptName.MaxLength = 20;
            this.txtScriptName.Name = "txtScriptName";
            this.txtScriptName.Size = new System.Drawing.Size(173, 22);
            this.txtScriptName.TabIndex = 14;
            // 
            // lblScriptName
            // 
            this.lblScriptName.AutoSize = true;
            this.lblScriptName.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblScriptName.ForeColor = System.Drawing.SystemColors.Control;
            this.lblScriptName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblScriptName.Location = new System.Drawing.Point(12, 94);
            this.lblScriptName.Name = "lblScriptName";
            this.lblScriptName.Size = new System.Drawing.Size(83, 16);
            this.lblScriptName.TabIndex = 13;
            this.lblScriptName.Text = "Script Name:";
            // 
            // btnScriptFolderBrowser
            // 
            this.btnScriptFolderBrowser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnScriptFolderBrowser.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnScriptFolderBrowser.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnScriptFolderBrowser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScriptFolderBrowser.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnScriptFolderBrowser.ForeColor = System.Drawing.Color.White;
            this.btnScriptFolderBrowser.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnScriptFolderBrowser.Location = new System.Drawing.Point(532, 57);
            this.btnScriptFolderBrowser.Name = "btnScriptFolderBrowser";
            this.btnScriptFolderBrowser.Size = new System.Drawing.Size(31, 27);
            this.btnScriptFolderBrowser.TabIndex = 12;
            this.btnScriptFolderBrowser.Text = "...";
            this.btnScriptFolderBrowser.UseVisualStyleBackColor = false;
            this.btnScriptFolderBrowser.Click += new System.EventHandler(this.BtnPathScriptBrowser_Click);
            // 
            // btnFolderSQLBrowser
            // 
            this.btnFolderSQLBrowser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnFolderSQLBrowser.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnFolderSQLBrowser.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnFolderSQLBrowser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFolderSQLBrowser.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFolderSQLBrowser.ForeColor = System.Drawing.Color.White;
            this.btnFolderSQLBrowser.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnFolderSQLBrowser.Location = new System.Drawing.Point(532, 25);
            this.btnFolderSQLBrowser.Name = "btnFolderSQLBrowser";
            this.btnFolderSQLBrowser.Size = new System.Drawing.Size(31, 27);
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
            this.lblScriptFolder.Location = new System.Drawing.Point(10, 62);
            this.lblScriptFolder.Name = "lblScriptFolder";
            this.lblScriptFolder.Size = new System.Drawing.Size(85, 16);
            this.lblScriptFolder.TabIndex = 9;
            this.lblScriptFolder.Text = "Script Folder:";
            // 
            // txtScriptFolder
            // 
            this.txtScriptFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtScriptFolder.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtScriptFolder.ForeColor = System.Drawing.Color.White;
            this.txtScriptFolder.Location = new System.Drawing.Point(102, 59);
            this.txtScriptFolder.Name = "txtScriptFolder";
            this.txtScriptFolder.Size = new System.Drawing.Size(424, 22);
            this.txtScriptFolder.TabIndex = 10;
            // 
            // lblSQLFolder
            // 
            this.lblSQLFolder.AutoSize = true;
            this.lblSQLFolder.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSQLFolder.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSQLFolder.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblSQLFolder.Location = new System.Drawing.Point(18, 30);
            this.lblSQLFolder.Name = "lblSQLFolder";
            this.lblSQLFolder.Size = new System.Drawing.Size(77, 16);
            this.lblSQLFolder.TabIndex = 7;
            this.lblSQLFolder.Text = "SQL Folder:";
            // 
            // txtFolderSQL
            // 
            this.txtFolderSQL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtFolderSQL.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFolderSQL.ForeColor = System.Drawing.Color.White;
            this.txtFolderSQL.Location = new System.Drawing.Point(102, 27);
            this.txtFolderSQL.Name = "txtFolderSQL";
            this.txtFolderSQL.Size = new System.Drawing.Size(424, 22);
            this.txtFolderSQL.TabIndex = 8;
            // 
            // btnScriptUnified
            // 
            this.btnScriptUnified.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnScriptUnified.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnScriptUnified.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btnScriptUnified.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScriptUnified.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnScriptUnified.ForeColor = System.Drawing.SystemColors.Control;
            this.btnScriptUnified.Image = global::Utilities.Properties.Resources.icons8_compose_32;
            this.btnScriptUnified.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnScriptUnified.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnScriptUnified.Location = new System.Drawing.Point(430, 93);
            this.btnScriptUnified.Name = "btnScriptUnified";
            this.btnScriptUnified.Size = new System.Drawing.Size(133, 51);
            this.btnScriptUnified.TabIndex = 6;
            this.btnScriptUnified.Text = "Generate Unified Script\r\n";
            this.btnScriptUnified.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnScriptUnified.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnScriptUnified.UseVisualStyleBackColor = false;
            this.btnScriptUnified.Click += new System.EventHandler(this.BtnScriptUnified_Click);
            // 
            // ScriptWriter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(603, 182);
            this.Controls.Add(this.grpSQLScripts);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ScriptWriter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Script Writer";
            this.Load += new System.EventHandler(this.ScriptWriter_Load);
            this.grpSQLScripts.ResumeLayout(false);
            this.grpSQLScripts.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSQLScripts;
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
    }
}