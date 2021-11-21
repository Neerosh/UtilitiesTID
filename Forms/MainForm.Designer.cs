
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
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnConvertClarion = new System.Windows.Forms.Button();
            this.btnScriptWriter = new System.Windows.Forms.Button();
            this.panelSubMenuCodes = new System.Windows.Forms.Panel();
            this.btnCodesManage = new System.Windows.Forms.Button();
            this.btnCodesCopyToClipboard = new System.Windows.Forms.Button();
            this.btnCodes = new System.Windows.Forms.Button();
            this.btnFileManagement = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblNameLogo = new System.Windows.Forms.Label();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.panelBar = new System.Windows.Forms.Panel();
            this.lblOpenWindow = new System.Windows.Forms.Label();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panelBorderChildForm = new System.Windows.Forms.Panel();
            this.panelSideMenu.SuspendLayout();
            this.panelSubMenuCodes.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.panelBar.SuspendLayout();
            this.panelBorderChildForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panelSideMenu.Controls.Add(this.linkCreator);
            this.panelSideMenu.Controls.Add(this.btnHelp);
            this.panelSideMenu.Controls.Add(this.btnConvertClarion);
            this.panelSideMenu.Controls.Add(this.btnScriptWriter);
            this.panelSideMenu.Controls.Add(this.panelSubMenuCodes);
            this.panelSideMenu.Controls.Add(this.btnCodes);
            this.panelSideMenu.Controls.Add(this.btnFileManagement);
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
            this.linkCreator.Location = new System.Drawing.Point(12, 560);
            this.linkCreator.Name = "linkCreator";
            this.linkCreator.Size = new System.Drawing.Size(129, 16);
            this.linkCreator.TabIndex = 7;
            this.linkCreator.TabStop = true;
            this.linkCreator.Text = "Created by Nerrosh";
            this.linkCreator.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(157)))), ((int)(((byte)(0)))));
            this.linkCreator.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkCreator_LinkClicked);
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnHelp.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnHelp.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHelp.FlatAppearance.BorderSize = 0;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHelp.ForeColor = System.Drawing.Color.White;
            this.btnHelp.Image = global::Utilities.Properties.Resources.icons8_info_squared_32;
            this.btnHelp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHelp.Location = new System.Drawing.Point(0, 333);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnHelp.Size = new System.Drawing.Size(210, 45);
            this.btnHelp.TabIndex = 6;
            this.btnHelp.Text = "Help";
            this.btnHelp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHelp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.BtnHelp_Click);
            // 
            // btnConvertClarion
            // 
            this.btnConvertClarion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnConvertClarion.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnConvertClarion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConvertClarion.FlatAppearance.BorderSize = 0;
            this.btnConvertClarion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConvertClarion.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConvertClarion.ForeColor = System.Drawing.Color.White;
            this.btnConvertClarion.Image = global::Utilities.Properties.Resources.icons8_clock_32;
            this.btnConvertClarion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConvertClarion.Location = new System.Drawing.Point(0, 288);
            this.btnConvertClarion.Name = "btnConvertClarion";
            this.btnConvertClarion.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnConvertClarion.Size = new System.Drawing.Size(210, 45);
            this.btnConvertClarion.TabIndex = 5;
            this.btnConvertClarion.Text = "Clarion Conversion";
            this.btnConvertClarion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConvertClarion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConvertClarion.UseVisualStyleBackColor = false;
            this.btnConvertClarion.Click += new System.EventHandler(this.BtnConvertClarion_Click);
            // 
            // btnScriptWriter
            // 
            this.btnScriptWriter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnScriptWriter.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnScriptWriter.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnScriptWriter.FlatAppearance.BorderSize = 0;
            this.btnScriptWriter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScriptWriter.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnScriptWriter.ForeColor = System.Drawing.Color.White;
            this.btnScriptWriter.Image = global::Utilities.Properties.Resources.icons8_scroll_32;
            this.btnScriptWriter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnScriptWriter.Location = new System.Drawing.Point(0, 243);
            this.btnScriptWriter.Name = "btnScriptWriter";
            this.btnScriptWriter.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnScriptWriter.Size = new System.Drawing.Size(210, 45);
            this.btnScriptWriter.TabIndex = 4;
            this.btnScriptWriter.Text = "Script Writer";
            this.btnScriptWriter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnScriptWriter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnScriptWriter.UseVisualStyleBackColor = false;
            this.btnScriptWriter.Click += new System.EventHandler(this.BtnScriptWriter_Click);
            // 
            // panelSubMenuCodes
            // 
            this.panelSubMenuCodes.Controls.Add(this.btnCodesManage);
            this.panelSubMenuCodes.Controls.Add(this.btnCodesCopyToClipboard);
            this.panelSubMenuCodes.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenuCodes.Location = new System.Drawing.Point(0, 163);
            this.panelSubMenuCodes.Name = "panelSubMenuCodes";
            this.panelSubMenuCodes.Size = new System.Drawing.Size(210, 80);
            this.panelSubMenuCodes.TabIndex = 3;
            // 
            // btnCodesManage
            // 
            this.btnCodesManage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnCodesManage.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnCodesManage.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCodesManage.FlatAppearance.BorderSize = 0;
            this.btnCodesManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCodesManage.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCodesManage.ForeColor = System.Drawing.Color.White;
            this.btnCodesManage.Image = global::Utilities.Properties.Resources.icons8_manage_clipboard_32;
            this.btnCodesManage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCodesManage.Location = new System.Drawing.Point(0, 40);
            this.btnCodesManage.Name = "btnCodesManage";
            this.btnCodesManage.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnCodesManage.Size = new System.Drawing.Size(210, 40);
            this.btnCodesManage.TabIndex = 1;
            this.btnCodesManage.Text = "Manage";
            this.btnCodesManage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCodesManage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCodesManage.UseVisualStyleBackColor = false;
            this.btnCodesManage.Click += new System.EventHandler(this.BtnCodesManage_Click);
            // 
            // btnCodesCopyToClipboard
            // 
            this.btnCodesCopyToClipboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnCodesCopyToClipboard.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnCodesCopyToClipboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCodesCopyToClipboard.FlatAppearance.BorderSize = 0;
            this.btnCodesCopyToClipboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCodesCopyToClipboard.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCodesCopyToClipboard.ForeColor = System.Drawing.Color.White;
            this.btnCodesCopyToClipboard.Image = global::Utilities.Properties.Resources.icons8_copy_to_clipboard_32;
            this.btnCodesCopyToClipboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCodesCopyToClipboard.Location = new System.Drawing.Point(0, 0);
            this.btnCodesCopyToClipboard.Name = "btnCodesCopyToClipboard";
            this.btnCodesCopyToClipboard.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnCodesCopyToClipboard.Size = new System.Drawing.Size(210, 40);
            this.btnCodesCopyToClipboard.TabIndex = 0;
            this.btnCodesCopyToClipboard.Text = "Copy To Clipboard";
            this.btnCodesCopyToClipboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCodesCopyToClipboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCodesCopyToClipboard.UseVisualStyleBackColor = false;
            this.btnCodesCopyToClipboard.Click += new System.EventHandler(this.BtnCodesCopyToClipboard_Click);
            // 
            // btnCodes
            // 
            this.btnCodes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnCodes.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnCodes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCodes.FlatAppearance.BorderSize = 0;
            this.btnCodes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCodes.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCodes.ForeColor = System.Drawing.Color.White;
            this.btnCodes.Image = global::Utilities.Properties.Resources.icons8_data_32;
            this.btnCodes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCodes.Location = new System.Drawing.Point(0, 118);
            this.btnCodes.Name = "btnCodes";
            this.btnCodes.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnCodes.Size = new System.Drawing.Size(210, 45);
            this.btnCodes.TabIndex = 2;
            this.btnCodes.Text = "Codes";
            this.btnCodes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCodes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCodes.UseVisualStyleBackColor = false;
            this.btnCodes.Click += new System.EventHandler(this.BtnCodes_Click);
            // 
            // btnFileManagement
            // 
            this.btnFileManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnFileManagement.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnFileManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFileManagement.FlatAppearance.BorderSize = 0;
            this.btnFileManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFileManagement.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFileManagement.ForeColor = System.Drawing.Color.White;
            this.btnFileManagement.Image = ((System.Drawing.Image)(resources.GetObject("btnFileManagement.Image")));
            this.btnFileManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFileManagement.Location = new System.Drawing.Point(0, 73);
            this.btnFileManagement.Name = "btnFileManagement";
            this.btnFileManagement.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnFileManagement.Size = new System.Drawing.Size(210, 45);
            this.btnFileManagement.TabIndex = 1;
            this.btnFileManagement.Text = "File Management";
            this.btnFileManagement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFileManagement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFileManagement.UseVisualStyleBackColor = false;
            this.btnFileManagement.Click += new System.EventHandler(this.BtnFileManagement_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panelLogo.Controls.Add(this.picLogo);
            this.panelLogo.Controls.Add(this.lblNameLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(210, 73);
            this.panelLogo.TabIndex = 0;
            this.panelLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            // 
            // picLogo
            // 
            this.picLogo.Image = global::Utilities.Properties.Resources.icons8_maintenance_64;
            this.picLogo.Location = new System.Drawing.Point(12, 12);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(45, 45);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 2;
            this.picLogo.TabStop = false;
            this.picLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            // 
            // lblNameLogo
            // 
            this.lblNameLogo.AutoSize = true;
            this.lblNameLogo.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNameLogo.ForeColor = System.Drawing.Color.White;
            this.lblNameLogo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblNameLogo.Location = new System.Drawing.Point(63, 21);
            this.lblNameLogo.Name = "lblNameLogo";
            this.lblNameLogo.Size = new System.Drawing.Size(128, 26);
            this.lblNameLogo.TabIndex = 1;
            this.lblNameLogo.Text = "Utilities TID";
            this.lblNameLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNameLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(2, 2);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(788, 568);
            this.panelChildForm.TabIndex = 8;
            // 
            // panelBar
            // 
            this.panelBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panelBar.Controls.Add(this.lblOpenWindow);
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
            // lblOpenWindow
            // 
            this.lblOpenWindow.AutoSize = true;
            this.lblOpenWindow.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOpenWindow.ForeColor = System.Drawing.Color.White;
            this.lblOpenWindow.Location = new System.Drawing.Point(6, 7);
            this.lblOpenWindow.Name = "lblOpenWindow";
            this.lblOpenWindow.Size = new System.Drawing.Size(0, 16);
            this.lblOpenWindow.TabIndex = 7;
            this.lblOpenWindow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Image = global::Utilities.Properties.Resources.icons8_minimize_window_32;
            this.btnMinimize.Location = new System.Drawing.Point(700, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(30, 30);
            this.btnMinimize.TabIndex = 6;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnMaximize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Image = global::Utilities.Properties.Resources.icons8_maximize_window_32;
            this.btnMaximize.Location = new System.Drawing.Point(730, 0);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(30, 30);
            this.btnMaximize.TabIndex = 5;
            this.btnMaximize.UseVisualStyleBackColor = false;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::Utilities.Properties.Resources.icons8_close_window_32;
            this.btnClose.Location = new System.Drawing.Point(760, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 4;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panelBorderChildForm
            // 
            this.panelBorderChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panelBorderChildForm.Controls.Add(this.panelChildForm);
            this.panelBorderChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBorderChildForm.Location = new System.Drawing.Point(210, 30);
            this.panelBorderChildForm.Name = "panelBorderChildForm";
            this.panelBorderChildForm.Padding = new System.Windows.Forms.Padding(2, 2, 0, 0);
            this.panelBorderChildForm.Size = new System.Drawing.Size(790, 570);
            this.panelBorderChildForm.TabIndex = 0;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.panelBorderChildForm);
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
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.panelBar.ResumeLayout(false);
            this.panelBar.PerformLayout();
            this.panelBorderChildForm.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel panelSubMenuCodes;
        private System.Windows.Forms.Button btnCodesManage;
        private System.Windows.Forms.Button btnCodesCopyToClipboard;
        private System.Windows.Forms.Button btnCodes;
        private System.Windows.Forms.Button btnFileManagement;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnScriptWriter;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Label lblNameLogo;
        private System.Windows.Forms.Button btnConvertClarion;
        private System.Windows.Forms.Panel panelBar;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.LinkLabel linkCreator;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Panel panelBorderChildForm;
        private System.Windows.Forms.Label lblOpenWindow;
    }
}

