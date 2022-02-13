﻿
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
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnScriptWriter = new System.Windows.Forms.Button();
            this.btnProcessManagement = new System.Windows.Forms.Button();
            this.panelSubMenuFileManagement = new System.Windows.Forms.Panel();
            this.btnFileFilters = new System.Windows.Forms.Button();
            this.btnFileManagement = new System.Windows.Forms.Button();
            this.btnFileEncryption = new System.Windows.Forms.Button();
            this.panelSubMenuCodes = new System.Windows.Forms.Panel();
            this.btnCodesManage = new System.Windows.Forms.Button();
            this.btnCodes = new System.Windows.Forms.Button();
            this.btnConvertClarion = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblNameLogo = new System.Windows.Forms.Label();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.panelBar = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panelSideMenu.SuspendLayout();
            this.panelSubMenuFileManagement.SuspendLayout();
            this.panelSubMenuCodes.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.panelBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panelSideMenu.Controls.Add(this.btnHelp);
            this.panelSideMenu.Controls.Add(this.btnScriptWriter);
            this.panelSideMenu.Controls.Add(this.btnProcessManagement);
            this.panelSideMenu.Controls.Add(this.panelSubMenuFileManagement);
            this.panelSideMenu.Controls.Add(this.btnFileManagement);
            this.panelSideMenu.Controls.Add(this.btnFileEncryption);
            this.panelSideMenu.Controls.Add(this.panelSubMenuCodes);
            this.panelSideMenu.Controls.Add(this.btnCodes);
            this.panelSideMenu.Controls.Add(this.btnConvertClarion);
            this.panelSideMenu.Controls.Add(this.btnMenu);
            this.panelSideMenu.Controls.Add(this.panel1);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.ForeColor = System.Drawing.Color.White;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(210, 611);
            this.panelSideMenu.TabIndex = 6;
            this.panelSideMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnHelp.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnHelp.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHelp.FlatAppearance.BorderSize = 0;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHelp.ForeColor = System.Drawing.Color.White;
            this.btnHelp.Image = global::Utilities.Properties.Resources.icons8_help_32;
            this.btnHelp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHelp.Location = new System.Drawing.Point(0, 456);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnHelp.Size = new System.Drawing.Size(210, 44);
            this.btnHelp.TabIndex = 6;
            this.btnHelp.Text = "Help";
            this.btnHelp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHelp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.BtnHelp_Click);
            // 
            // btnScriptWriter
            // 
            this.btnScriptWriter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnScriptWriter.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnScriptWriter.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnScriptWriter.FlatAppearance.BorderSize = 0;
            this.btnScriptWriter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScriptWriter.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnScriptWriter.ForeColor = System.Drawing.Color.White;
            this.btnScriptWriter.Image = global::Utilities.Properties.Resources.icons8_scroll_32;
            this.btnScriptWriter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnScriptWriter.Location = new System.Drawing.Point(0, 412);
            this.btnScriptWriter.Name = "btnScriptWriter";
            this.btnScriptWriter.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnScriptWriter.Size = new System.Drawing.Size(210, 44);
            this.btnScriptWriter.TabIndex = 4;
            this.btnScriptWriter.Text = "Script Writer";
            this.btnScriptWriter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnScriptWriter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnScriptWriter.UseVisualStyleBackColor = false;
            this.btnScriptWriter.Click += new System.EventHandler(this.BtnScriptWriter_Click);
            // 
            // btnProcessManagement
            // 
            this.btnProcessManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnProcessManagement.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnProcessManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProcessManagement.FlatAppearance.BorderSize = 0;
            this.btnProcessManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcessManagement.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnProcessManagement.ForeColor = System.Drawing.Color.White;
            this.btnProcessManagement.Image = global::Utilities.Properties.Resources.icons8_processes_32;
            this.btnProcessManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProcessManagement.Location = new System.Drawing.Point(0, 368);
            this.btnProcessManagement.Name = "btnProcessManagement";
            this.btnProcessManagement.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnProcessManagement.Size = new System.Drawing.Size(210, 44);
            this.btnProcessManagement.TabIndex = 10;
            this.btnProcessManagement.Text = "Process Management";
            this.btnProcessManagement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProcessManagement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProcessManagement.UseVisualStyleBackColor = false;
            this.btnProcessManagement.Click += new System.EventHandler(this.btnProcessManagement_Click);
            // 
            // panelSubMenuFileManagement
            // 
            this.panelSubMenuFileManagement.Controls.Add(this.btnFileFilters);
            this.panelSubMenuFileManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenuFileManagement.Location = new System.Drawing.Point(0, 326);
            this.panelSubMenuFileManagement.Name = "panelSubMenuFileManagement";
            this.panelSubMenuFileManagement.Size = new System.Drawing.Size(210, 42);
            this.panelSubMenuFileManagement.TabIndex = 4;
            // 
            // btnFileFilters
            // 
            this.btnFileFilters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnFileFilters.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnFileFilters.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFileFilters.FlatAppearance.BorderSize = 0;
            this.btnFileFilters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFileFilters.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFileFilters.ForeColor = System.Drawing.Color.White;
            this.btnFileFilters.Image = global::Utilities.Properties.Resources.icons8_tune_32;
            this.btnFileFilters.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFileFilters.Location = new System.Drawing.Point(0, 0);
            this.btnFileFilters.Name = "btnFileFilters";
            this.btnFileFilters.Padding = new System.Windows.Forms.Padding(34, 0, 0, 0);
            this.btnFileFilters.Size = new System.Drawing.Size(210, 42);
            this.btnFileFilters.TabIndex = 1;
            this.btnFileFilters.Text = "Manage File Filters";
            this.btnFileFilters.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFileFilters.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFileFilters.UseVisualStyleBackColor = false;
            this.btnFileFilters.Click += new System.EventHandler(this.btnFileFilters_Click);
            // 
            // btnFileManagement
            // 
            this.btnFileManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnFileManagement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnFileManagement.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnFileManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFileManagement.FlatAppearance.BorderSize = 0;
            this.btnFileManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFileManagement.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFileManagement.ForeColor = System.Drawing.Color.White;
            this.btnFileManagement.Image = global::Utilities.Properties.Resources.icons8_manage_file_32;
            this.btnFileManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFileManagement.Location = new System.Drawing.Point(0, 282);
            this.btnFileManagement.Name = "btnFileManagement";
            this.btnFileManagement.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnFileManagement.Size = new System.Drawing.Size(210, 44);
            this.btnFileManagement.TabIndex = 1;
            this.btnFileManagement.Text = "File Management";
            this.btnFileManagement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFileManagement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFileManagement.UseVisualStyleBackColor = false;
            this.btnFileManagement.Click += new System.EventHandler(this.BtnFileManagement_Click);
            // 
            // btnFileEncryption
            // 
            this.btnFileEncryption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnFileEncryption.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnFileEncryption.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFileEncryption.FlatAppearance.BorderSize = 0;
            this.btnFileEncryption.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFileEncryption.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFileEncryption.ForeColor = System.Drawing.Color.White;
            this.btnFileEncryption.Image = global::Utilities.Properties.Resources.icons8_check_file_32;
            this.btnFileEncryption.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFileEncryption.Location = new System.Drawing.Point(0, 238);
            this.btnFileEncryption.Name = "btnFileEncryption";
            this.btnFileEncryption.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnFileEncryption.Size = new System.Drawing.Size(210, 44);
            this.btnFileEncryption.TabIndex = 11;
            this.btnFileEncryption.Text = "File Checksum";
            this.btnFileEncryption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFileEncryption.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFileEncryption.UseVisualStyleBackColor = false;
            this.btnFileEncryption.Click += new System.EventHandler(this.btnFileEncryption_Click);
            // 
            // panelSubMenuCodes
            // 
            this.panelSubMenuCodes.Controls.Add(this.btnCodesManage);
            this.panelSubMenuCodes.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenuCodes.Location = new System.Drawing.Point(0, 196);
            this.panelSubMenuCodes.Name = "panelSubMenuCodes";
            this.panelSubMenuCodes.Size = new System.Drawing.Size(210, 42);
            this.panelSubMenuCodes.TabIndex = 3;
            // 
            // btnCodesManage
            // 
            this.btnCodesManage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCodesManage.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnCodesManage.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCodesManage.FlatAppearance.BorderSize = 0;
            this.btnCodesManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCodesManage.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCodesManage.ForeColor = System.Drawing.Color.White;
            this.btnCodesManage.Image = global::Utilities.Properties.Resources.icons8_tune_32;
            this.btnCodesManage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCodesManage.Location = new System.Drawing.Point(0, 0);
            this.btnCodesManage.Name = "btnCodesManage";
            this.btnCodesManage.Padding = new System.Windows.Forms.Padding(34, 0, 0, 0);
            this.btnCodesManage.Size = new System.Drawing.Size(210, 42);
            this.btnCodesManage.TabIndex = 1;
            this.btnCodesManage.Text = "Manage Codes";
            this.btnCodesManage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCodesManage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCodesManage.UseVisualStyleBackColor = false;
            this.btnCodesManage.Click += new System.EventHandler(this.BtnCodesManage_Click);
            // 
            // btnCodes
            // 
            this.btnCodes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCodes.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnCodes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCodes.FlatAppearance.BorderSize = 0;
            this.btnCodes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCodes.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCodes.ForeColor = System.Drawing.Color.White;
            this.btnCodes.Image = global::Utilities.Properties.Resources.icons8_code_32;
            this.btnCodes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCodes.Location = new System.Drawing.Point(0, 152);
            this.btnCodes.Name = "btnCodes";
            this.btnCodes.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnCodes.Size = new System.Drawing.Size(210, 44);
            this.btnCodes.TabIndex = 2;
            this.btnCodes.Text = "Codes To Clipboard";
            this.btnCodes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCodes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCodes.UseVisualStyleBackColor = false;
            this.btnCodes.Click += new System.EventHandler(this.BtnCodes_Click);
            // 
            // btnConvertClarion
            // 
            this.btnConvertClarion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnConvertClarion.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnConvertClarion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConvertClarion.FlatAppearance.BorderSize = 0;
            this.btnConvertClarion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConvertClarion.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConvertClarion.ForeColor = System.Drawing.Color.White;
            this.btnConvertClarion.Image = global::Utilities.Properties.Resources.icons8_convert_32;
            this.btnConvertClarion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConvertClarion.Location = new System.Drawing.Point(0, 108);
            this.btnConvertClarion.Name = "btnConvertClarion";
            this.btnConvertClarion.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnConvertClarion.Size = new System.Drawing.Size(210, 44);
            this.btnConvertClarion.TabIndex = 5;
            this.btnConvertClarion.Text = "Clarion Conversion";
            this.btnConvertClarion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConvertClarion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConvertClarion.UseVisualStyleBackColor = false;
            this.btnConvertClarion.Click += new System.EventHandler(this.BtnConvertClarion_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMenu.ForeColor = System.Drawing.Color.White;
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu.Location = new System.Drawing.Point(0, 64);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnMenu.Size = new System.Drawing.Size(210, 44);
            this.btnMenu.TabIndex = 8;
            this.btnMenu.Text = "Menu";
            this.btnMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.picLogo);
            this.panel1.Controls.Add(this.lblNameLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 64);
            this.panel1.TabIndex = 9;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            // 
            // picLogo
            // 
            this.picLogo.Image = global::Utilities.Properties.Resources.icons8_maintenance_64;
            this.picLogo.Location = new System.Drawing.Point(12, 8);
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
            this.lblNameLogo.Location = new System.Drawing.Point(63, 18);
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
            this.panelChildForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(210, 26);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Padding = new System.Windows.Forms.Padding(2);
            this.panelChildForm.Size = new System.Drawing.Size(794, 585);
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
            this.panelBar.Size = new System.Drawing.Size(794, 26);
            this.panelBar.TabIndex = 9;
            this.panelBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Image = global::Utilities.Properties.Resources.icons8_minimize_window_32;
            this.btnMinimize.Location = new System.Drawing.Point(710, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(28, 26);
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
            this.btnMaximize.Location = new System.Drawing.Point(738, 0);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(28, 26);
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
            this.btnClose.Location = new System.Drawing.Point(766, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(28, 26);
            this.btnClose.TabIndex = 4;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(1004, 611);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelBar);
            this.Controls.Add(this.panelSideMenu);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1020, 650);
            this.Name = "Main";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Utilities TID";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            this.Resize += new System.EventHandler(this.Main_Resize);
            this.panelSideMenu.ResumeLayout(false);
            this.panelSubMenuFileManagement.ResumeLayout(false);
            this.panelSubMenuCodes.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.panelBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel panelSubMenuCodes;
        private System.Windows.Forms.Button btnCodesManage;
        private System.Windows.Forms.Button btnCodes;
        private System.Windows.Forms.Button btnFileManagement;
        private System.Windows.Forms.Button btnScriptWriter;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Label lblNameLogo;
        private System.Windows.Forms.Button btnConvertClarion;
        private System.Windows.Forms.Panel panelBar;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnProcessManagement;
        private System.Windows.Forms.Panel panelSubMenuFileManagement;
        private System.Windows.Forms.Button btnFileFilters;
        private System.Windows.Forms.Button btnFileEncryption;
    }
}

