
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
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.linkCreator = new System.Windows.Forms.LinkLabel();
            this.sideMenuHelp = new System.Windows.Forms.Button();
            this.sideMenuConvertClarion = new System.Windows.Forms.Button();
            this.sideMenuScriptWriter = new System.Windows.Forms.Button();
            this.panelSubMenuCodes = new System.Windows.Forms.Panel();
            this.menuSubManageCodes = new System.Windows.Forms.Button();
            this.menuSubCopyToClipboard = new System.Windows.Forms.Button();
            this.sideMenuCodes = new System.Windows.Forms.Button();
            this.sideMenuFileManagement = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.lblNameLogo = new System.Windows.Forms.Label();
            this.panelImageLogo = new System.Windows.Forms.Panel();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.panelBar = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panelSideMenu.SuspendLayout();
            this.panelSubMenuCodes.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panelSideMenu.Controls.Add(this.linkCreator);
            this.panelSideMenu.Controls.Add(this.sideMenuHelp);
            this.panelSideMenu.Controls.Add(this.sideMenuConvertClarion);
            this.panelSideMenu.Controls.Add(this.sideMenuScriptWriter);
            this.panelSideMenu.Controls.Add(this.panelSubMenuCodes);
            this.panelSideMenu.Controls.Add(this.sideMenuCodes);
            this.panelSideMenu.Controls.Add(this.sideMenuFileManagement);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(210, 600);
            this.panelSideMenu.TabIndex = 6;
            this.panelSideMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            // 
            // linkCreator
            // 
            this.linkCreator.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(138)))), ((int)(((byte)(0)))));
            this.linkCreator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.linkCreator.AutoSize = true;
            this.linkCreator.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.linkCreator.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(0)))));
            this.linkCreator.Location = new System.Drawing.Point(10, 575);
            this.linkCreator.Name = "linkCreator";
            this.linkCreator.Size = new System.Drawing.Size(129, 16);
            this.linkCreator.TabIndex = 7;
            this.linkCreator.TabStop = true;
            this.linkCreator.Text = "Created by Nerrosh";
            this.linkCreator.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(157)))), ((int)(((byte)(0)))));
            this.linkCreator.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkCreator_LinkClicked);
            // 
            // sideMenuHelp
            // 
            this.sideMenuHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.sideMenuHelp.Dock = System.Windows.Forms.DockStyle.Top;
            this.sideMenuHelp.FlatAppearance.BorderSize = 0;
            this.sideMenuHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sideMenuHelp.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sideMenuHelp.ForeColor = System.Drawing.Color.White;
            this.sideMenuHelp.Image = global::Utilities.Properties.Resources.icons8_info_squared_32;
            this.sideMenuHelp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sideMenuHelp.Location = new System.Drawing.Point(0, 330);
            this.sideMenuHelp.Name = "sideMenuHelp";
            this.sideMenuHelp.Size = new System.Drawing.Size(210, 45);
            this.sideMenuHelp.TabIndex = 6;
            this.sideMenuHelp.Text = "Help";
            this.sideMenuHelp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sideMenuHelp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.sideMenuHelp.UseVisualStyleBackColor = false;
            this.sideMenuHelp.Click += new System.EventHandler(this.sideMenuHelp_Click);
            // 
            // sideMenuConvertClarion
            // 
            this.sideMenuConvertClarion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.sideMenuConvertClarion.Dock = System.Windows.Forms.DockStyle.Top;
            this.sideMenuConvertClarion.FlatAppearance.BorderSize = 0;
            this.sideMenuConvertClarion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sideMenuConvertClarion.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sideMenuConvertClarion.ForeColor = System.Drawing.Color.White;
            this.sideMenuConvertClarion.Image = global::Utilities.Properties.Resources.icons8_clock_32;
            this.sideMenuConvertClarion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sideMenuConvertClarion.Location = new System.Drawing.Point(0, 285);
            this.sideMenuConvertClarion.Name = "sideMenuConvertClarion";
            this.sideMenuConvertClarion.Size = new System.Drawing.Size(210, 45);
            this.sideMenuConvertClarion.TabIndex = 5;
            this.sideMenuConvertClarion.Text = "Clarion Conversion";
            this.sideMenuConvertClarion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sideMenuConvertClarion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.sideMenuConvertClarion.UseVisualStyleBackColor = false;
            this.sideMenuConvertClarion.Click += new System.EventHandler(this.sideMenuConvertClarion_Click);
            // 
            // sideMenuScriptWriter
            // 
            this.sideMenuScriptWriter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.sideMenuScriptWriter.Dock = System.Windows.Forms.DockStyle.Top;
            this.sideMenuScriptWriter.FlatAppearance.BorderSize = 0;
            this.sideMenuScriptWriter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sideMenuScriptWriter.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sideMenuScriptWriter.ForeColor = System.Drawing.Color.White;
            this.sideMenuScriptWriter.Image = global::Utilities.Properties.Resources.icons8_scroll_32;
            this.sideMenuScriptWriter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sideMenuScriptWriter.Location = new System.Drawing.Point(0, 240);
            this.sideMenuScriptWriter.Name = "sideMenuScriptWriter";
            this.sideMenuScriptWriter.Size = new System.Drawing.Size(210, 45);
            this.sideMenuScriptWriter.TabIndex = 4;
            this.sideMenuScriptWriter.Text = "Script Writer";
            this.sideMenuScriptWriter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sideMenuScriptWriter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.sideMenuScriptWriter.UseVisualStyleBackColor = false;
            this.sideMenuScriptWriter.Click += new System.EventHandler(this.sideMenuScriptWriter_Click);
            // 
            // panelSubMenuCodes
            // 
            this.panelSubMenuCodes.Controls.Add(this.menuSubManageCodes);
            this.panelSubMenuCodes.Controls.Add(this.menuSubCopyToClipboard);
            this.panelSubMenuCodes.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenuCodes.Location = new System.Drawing.Point(0, 160);
            this.panelSubMenuCodes.Name = "panelSubMenuCodes";
            this.panelSubMenuCodes.Size = new System.Drawing.Size(210, 80);
            this.panelSubMenuCodes.TabIndex = 3;
            // 
            // menuSubManageCodes
            // 
            this.menuSubManageCodes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.menuSubManageCodes.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuSubManageCodes.FlatAppearance.BorderSize = 0;
            this.menuSubManageCodes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.menuSubManageCodes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuSubManageCodes.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.menuSubManageCodes.ForeColor = System.Drawing.Color.White;
            this.menuSubManageCodes.Image = global::Utilities.Properties.Resources.icons8_manage_clipboard_32;
            this.menuSubManageCodes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuSubManageCodes.Location = new System.Drawing.Point(0, 40);
            this.menuSubManageCodes.Name = "menuSubManageCodes";
            this.menuSubManageCodes.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.menuSubManageCodes.Size = new System.Drawing.Size(210, 40);
            this.menuSubManageCodes.TabIndex = 1;
            this.menuSubManageCodes.Text = "Manage";
            this.menuSubManageCodes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuSubManageCodes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.menuSubManageCodes.UseVisualStyleBackColor = false;
            this.menuSubManageCodes.Click += new System.EventHandler(this.menuSubManageCodes_Click);
            // 
            // menuSubCopyToClipboard
            // 
            this.menuSubCopyToClipboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.menuSubCopyToClipboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuSubCopyToClipboard.FlatAppearance.BorderSize = 0;
            this.menuSubCopyToClipboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.menuSubCopyToClipboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuSubCopyToClipboard.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.menuSubCopyToClipboard.ForeColor = System.Drawing.Color.White;
            this.menuSubCopyToClipboard.Image = global::Utilities.Properties.Resources.icons8_copy_to_clipboard_32;
            this.menuSubCopyToClipboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuSubCopyToClipboard.Location = new System.Drawing.Point(0, 0);
            this.menuSubCopyToClipboard.Name = "menuSubCopyToClipboard";
            this.menuSubCopyToClipboard.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.menuSubCopyToClipboard.Size = new System.Drawing.Size(210, 40);
            this.menuSubCopyToClipboard.TabIndex = 0;
            this.menuSubCopyToClipboard.Text = "Copy To Clipboard";
            this.menuSubCopyToClipboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuSubCopyToClipboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.menuSubCopyToClipboard.UseVisualStyleBackColor = false;
            this.menuSubCopyToClipboard.Click += new System.EventHandler(this.menuSubCopyToClipboard_Click);
            // 
            // sideMenuCodes
            // 
            this.sideMenuCodes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.sideMenuCodes.Dock = System.Windows.Forms.DockStyle.Top;
            this.sideMenuCodes.FlatAppearance.BorderSize = 0;
            this.sideMenuCodes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sideMenuCodes.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sideMenuCodes.ForeColor = System.Drawing.Color.White;
            this.sideMenuCodes.Image = global::Utilities.Properties.Resources.icons8_data_32;
            this.sideMenuCodes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sideMenuCodes.Location = new System.Drawing.Point(0, 115);
            this.sideMenuCodes.Name = "sideMenuCodes";
            this.sideMenuCodes.Size = new System.Drawing.Size(210, 45);
            this.sideMenuCodes.TabIndex = 2;
            this.sideMenuCodes.Text = "Codes";
            this.sideMenuCodes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sideMenuCodes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.sideMenuCodes.UseVisualStyleBackColor = false;
            this.sideMenuCodes.Click += new System.EventHandler(this.sideMenuCodes_Click);
            // 
            // sideMenuFileManagement
            // 
            this.sideMenuFileManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.sideMenuFileManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.sideMenuFileManagement.FlatAppearance.BorderSize = 0;
            this.sideMenuFileManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sideMenuFileManagement.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sideMenuFileManagement.ForeColor = System.Drawing.Color.White;
            this.sideMenuFileManagement.Image = ((System.Drawing.Image)(resources.GetObject("sideMenuFileManagement.Image")));
            this.sideMenuFileManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sideMenuFileManagement.Location = new System.Drawing.Point(0, 70);
            this.sideMenuFileManagement.Name = "sideMenuFileManagement";
            this.sideMenuFileManagement.Size = new System.Drawing.Size(210, 45);
            this.sideMenuFileManagement.TabIndex = 1;
            this.sideMenuFileManagement.Text = "Manage Files";
            this.sideMenuFileManagement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sideMenuFileManagement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.sideMenuFileManagement.UseVisualStyleBackColor = false;
            this.sideMenuFileManagement.Click += new System.EventHandler(this.sideMenuFileManagement_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panelLogo.Controls.Add(this.lblNameLogo);
            this.panelLogo.Controls.Add(this.panelImageLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(210, 70);
            this.panelLogo.TabIndex = 0;
            this.panelLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            // 
            // lblNameLogo
            // 
            this.lblNameLogo.AutoSize = true;
            this.lblNameLogo.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNameLogo.ForeColor = System.Drawing.Color.White;
            this.lblNameLogo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblNameLogo.Location = new System.Drawing.Point(66, 22);
            this.lblNameLogo.Name = "lblNameLogo";
            this.lblNameLogo.Size = new System.Drawing.Size(128, 26);
            this.lblNameLogo.TabIndex = 1;
            this.lblNameLogo.Text = "Utilities TID";
            this.lblNameLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNameLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            // 
            // panelImageLogo
            // 
            this.panelImageLogo.BackgroundImage = global::Utilities.Properties.Resources.icons8_maintenance_64;
            this.panelImageLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelImageLogo.Location = new System.Drawing.Point(10, 10);
            this.panelImageLogo.Name = "panelImageLogo";
            this.panelImageLogo.Size = new System.Drawing.Size(50, 50);
            this.panelImageLogo.TabIndex = 0;
            this.panelImageLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            // 
            // panelChildForm
            // 
            this.panelChildForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panelChildForm.Location = new System.Drawing.Point(210, 30);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(790, 570);
            this.panelChildForm.TabIndex = 8;
            // 
            // panelBar
            // 
            this.panelBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panelBar.Controls.Add(this.btnMinimize);
            this.panelBar.Controls.Add(this.btnMaximize);
            this.panelBar.Controls.Add(this.btnClose);
            this.panelBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBar.Location = new System.Drawing.Point(210, 0);
            this.panelBar.Name = "panelBar";
            this.panelBar.Size = new System.Drawing.Size(790, 30);
            this.panelBar.TabIndex = 9;
            this.panelBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Image = global::Utilities.Properties.Resources.icons8_minimize_window_32;
            this.btnMinimize.Location = new System.Drawing.Point(700, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(30, 30);
            this.btnMinimize.TabIndex = 6;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Image = global::Utilities.Properties.Resources.icons8_maximize_window_32;
            this.btnMaximize.Location = new System.Drawing.Point(730, 0);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(30, 30);
            this.btnMaximize.TabIndex = 5;
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::Utilities.Properties.Resources.icons8_close_window_32;
            this.btnClose.Location = new System.Drawing.Point(760, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 4;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelBar);
            this.Controls.Add(this.panelSideMenu);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "Main";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Utilities TID";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            this.Resize += new System.EventHandler(this.Main_Resize);
            this.panelSideMenu.ResumeLayout(false);
            this.panelSideMenu.PerformLayout();
            this.panelSubMenuCodes.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel panelSubMenuCodes;
        private System.Windows.Forms.Button menuSubManageCodes;
        private System.Windows.Forms.Button menuSubCopyToClipboard;
        private System.Windows.Forms.Button sideMenuCodes;
        private System.Windows.Forms.Button sideMenuFileManagement;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button sideMenuScriptWriter;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Button sideMenuHelp;
        private System.Windows.Forms.Label lblNameLogo;
        private System.Windows.Forms.Panel panelImageLogo;
        private System.Windows.Forms.Button sideMenuConvertClarion;
        private System.Windows.Forms.Panel panelBar;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.LinkLabel linkCreator;
    }
}

