﻿
namespace Utilities {
    partial class Help {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Help));
            this.txtFunctionality = new System.Windows.Forms.RichTextBox();
            this.txtSqlServerInstall = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txtFunctionality
            // 
            this.txtFunctionality.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtFunctionality.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtFunctionality.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFunctionality.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtFunctionality.ForeColor = System.Drawing.Color.White;
            this.txtFunctionality.Location = new System.Drawing.Point(20, 25);
            this.txtFunctionality.Name = "txtFunctionality";
            this.txtFunctionality.ReadOnly = true;
            this.txtFunctionality.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtFunctionality.Size = new System.Drawing.Size(370, 484);
            this.txtFunctionality.TabIndex = 0;
            this.txtFunctionality.Text = "";
            // 
            // txtSqlServerInstall
            // 
            this.txtSqlServerInstall.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSqlServerInstall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtSqlServerInstall.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSqlServerInstall.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtSqlServerInstall.ForeColor = System.Drawing.Color.White;
            this.txtSqlServerInstall.Location = new System.Drawing.Point(396, 25);
            this.txtSqlServerInstall.Name = "txtSqlServerInstall";
            this.txtSqlServerInstall.ReadOnly = true;
            this.txtSqlServerInstall.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtSqlServerInstall.Size = new System.Drawing.Size(258, 484);
            this.txtSqlServerInstall.TabIndex = 1;
            this.txtSqlServerInstall.Text = "";
            this.txtSqlServerInstall.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.txtSqlServerInstall_LinkClicked);
            // 
            // Help
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(678, 535);
            this.Controls.Add(this.txtSqlServerInstall);
            this.Controls.Add(this.txtFunctionality);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Help";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Help";
            this.Load += new System.EventHandler(this.Notes_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtFunctionality;
        private System.Windows.Forms.RichTextBox txtSqlServerInstall;
    }
}