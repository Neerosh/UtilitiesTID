namespace Utilities.Forms
{
    partial class FileFilters
    {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblSelection = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtFilterName = new System.Windows.Forms.TextBox();
            this.dgvFileFilters = new System.Windows.Forms.DataGridView();
            this.btnUpdateFile = new System.Windows.Forms.Button();
            this.lsbFileExtensions = new System.Windows.Forms.ListBox();
            this.lsbFiles = new System.Windows.Forms.ListBox();
            this.lblFileExtensions = new System.Windows.Forms.Label();
            this.lblFiles = new System.Windows.Forms.Label();
            this.btnUpdateExtension = new System.Windows.Forms.Button();
            this.btnDeleteFileFilter = new System.Windows.Forms.Button();
            this.btnUpdateFileFilter = new System.Windows.Forms.Button();
            this.btnInsertFileFilter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFileExtension = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.btnInsertFile = new System.Windows.Forms.Button();
            this.btnInsertExtension = new System.Windows.Forms.Button();
            this.btnDeleteExtension = new System.Windows.Forms.Button();
            this.btnDeleteFile = new System.Windows.Forms.Button();
            this.btnClearFields = new System.Windows.Forms.Button();
            this.txtFilterNotes = new System.Windows.Forms.RichTextBox();
            this.lblNotes = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFileFilters)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSelection
            // 
            this.lblSelection.AutoSize = true;
            this.lblSelection.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSelection.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSelection.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblSelection.Location = new System.Drawing.Point(12, 388);
            this.lblSelection.Name = "lblSelection";
            this.lblSelection.Size = new System.Drawing.Size(65, 16);
            this.lblSelection.TabIndex = 26;
            this.lblSelection.Text = "Selection:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblName.ForeColor = System.Drawing.SystemColors.Control;
            this.lblName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblName.Location = new System.Drawing.Point(12, 20);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(78, 16);
            this.lblName.TabIndex = 19;
            this.lblName.Text = "Filter Name:";
            // 
            // txtFilterName
            // 
            this.txtFilterName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilterName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtFilterName.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtFilterName.ForeColor = System.Drawing.Color.White;
            this.txtFilterName.Location = new System.Drawing.Point(96, 17);
            this.txtFilterName.Name = "txtFilterName";
            this.txtFilterName.Size = new System.Drawing.Size(501, 22);
            this.txtFilterName.TabIndex = 20;
            // 
            // dgvFileFilters
            // 
            this.dgvFileFilters.AllowUserToAddRows = false;
            this.dgvFileFilters.AllowUserToDeleteRows = false;
            this.dgvFileFilters.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFileFilters.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.dgvFileFilters.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgvFileFilters.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.dgvFileFilters.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvFileFilters.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvFileFilters.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFileFilters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFileFilters.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFileFilters.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvFileFilters.GridColor = System.Drawing.Color.White;
            this.dgvFileFilters.Location = new System.Drawing.Point(12, 407);
            this.dgvFileFilters.MultiSelect = false;
            this.dgvFileFilters.Name = "dgvFileFilters";
            this.dgvFileFilters.ReadOnly = true;
            this.dgvFileFilters.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvFileFilters.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvFileFilters.RowHeadersVisible = false;
            this.dgvFileFilters.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvFileFilters.RowTemplate.Height = 25;
            this.dgvFileFilters.RowTemplate.ReadOnly = true;
            this.dgvFileFilters.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvFileFilters.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFileFilters.Size = new System.Drawing.Size(585, 146);
            this.dgvFileFilters.TabIndex = 16;
            this.dgvFileFilters.SelectionChanged += new System.EventHandler(this.dgvFileFilters_SelectionChanged);
            // 
            // btnUpdateFile
            // 
            this.btnUpdateFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdateFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnUpdateFile.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnUpdateFile.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnUpdateFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateFile.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdateFile.ForeColor = System.Drawing.SystemColors.Control;
            this.btnUpdateFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateFile.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnUpdateFile.Location = new System.Drawing.Point(431, 218);
            this.btnUpdateFile.Name = "btnUpdateFile";
            this.btnUpdateFile.Size = new System.Drawing.Size(80, 24);
            this.btnUpdateFile.TabIndex = 23;
            this.btnUpdateFile.Text = "Update File";
            this.btnUpdateFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdateFile.UseVisualStyleBackColor = false;
            this.btnUpdateFile.Click += new System.EventHandler(this.btnUpdateFile_Click);
            // 
            // lsbFileExtensions
            // 
            this.lsbFileExtensions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsbFileExtensions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.lsbFileExtensions.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lsbFileExtensions.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lsbFileExtensions.ForeColor = System.Drawing.Color.White;
            this.lsbFileExtensions.FormattingEnabled = true;
            this.lsbFileExtensions.ItemHeight = 16;
            this.lsbFileExtensions.Location = new System.Drawing.Point(96, 248);
            this.lsbFileExtensions.Name = "lsbFileExtensions";
            this.lsbFileExtensions.Size = new System.Drawing.Size(501, 84);
            this.lsbFileExtensions.Sorted = true;
            this.lsbFileExtensions.TabIndex = 30;
            this.lsbFileExtensions.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lsbFileExtensions_DrawItem);
            this.lsbFileExtensions.SelectedIndexChanged += new System.EventHandler(this.lsbFileExtensions_SelectedIndexChanged);
            // 
            // lsbFiles
            // 
            this.lsbFiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsbFiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.lsbFiles.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lsbFiles.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lsbFiles.ForeColor = System.Drawing.Color.White;
            this.lsbFiles.FormattingEnabled = true;
            this.lsbFiles.ItemHeight = 16;
            this.lsbFiles.Location = new System.Drawing.Point(96, 102);
            this.lsbFiles.Name = "lsbFiles";
            this.lsbFiles.Size = new System.Drawing.Size(501, 84);
            this.lsbFiles.Sorted = true;
            this.lsbFiles.TabIndex = 31;
            this.lsbFiles.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lsbFiles_DrawItem);
            this.lsbFiles.SelectedIndexChanged += new System.EventHandler(this.lsbFiles_SelectedIndexChanged);
            // 
            // lblFileExtensions
            // 
            this.lblFileExtensions.AutoSize = true;
            this.lblFileExtensions.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFileExtensions.ForeColor = System.Drawing.SystemColors.Control;
            this.lblFileExtensions.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblFileExtensions.Location = new System.Drawing.Point(14, 248);
            this.lblFileExtensions.Name = "lblFileExtensions";
            this.lblFileExtensions.Size = new System.Drawing.Size(76, 16);
            this.lblFileExtensions.TabIndex = 32;
            this.lblFileExtensions.Text = "Extensions:";
            // 
            // lblFiles
            // 
            this.lblFiles.AutoSize = true;
            this.lblFiles.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFiles.ForeColor = System.Drawing.SystemColors.Control;
            this.lblFiles.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblFiles.Location = new System.Drawing.Point(51, 102);
            this.lblFiles.Name = "lblFiles";
            this.lblFiles.Size = new System.Drawing.Size(39, 16);
            this.lblFiles.TabIndex = 33;
            this.lblFiles.Text = "Files:";
            // 
            // btnUpdateExtension
            // 
            this.btnUpdateExtension.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdateExtension.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnUpdateExtension.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnUpdateExtension.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnUpdateExtension.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateExtension.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdateExtension.ForeColor = System.Drawing.SystemColors.Control;
            this.btnUpdateExtension.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateExtension.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnUpdateExtension.Location = new System.Drawing.Point(357, 364);
            this.btnUpdateExtension.Name = "btnUpdateExtension";
            this.btnUpdateExtension.Size = new System.Drawing.Size(117, 24);
            this.btnUpdateExtension.TabIndex = 34;
            this.btnUpdateExtension.Text = "Update Extension";
            this.btnUpdateExtension.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateExtension.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdateExtension.UseVisualStyleBackColor = false;
            this.btnUpdateExtension.Click += new System.EventHandler(this.btnUpdateExtension_Click);
            // 
            // btnDeleteFileFilter
            // 
            this.btnDeleteFileFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteFileFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnDeleteFileFilter.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDeleteFileFilter.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnDeleteFileFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteFileFilter.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteFileFilter.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDeleteFileFilter.Image = global::Utilities.Properties.Resources.icons8_delete_clipboard_32;
            this.btnDeleteFileFilter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteFileFilter.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnDeleteFileFilter.Location = new System.Drawing.Point(615, 509);
            this.btnDeleteFileFilter.Name = "btnDeleteFileFilter";
            this.btnDeleteFileFilter.Size = new System.Drawing.Size(155, 44);
            this.btnDeleteFileFilter.TabIndex = 36;
            this.btnDeleteFileFilter.Text = "Delete Selected";
            this.btnDeleteFileFilter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteFileFilter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeleteFileFilter.UseVisualStyleBackColor = false;
            this.btnDeleteFileFilter.Click += new System.EventHandler(this.btnDeleteFileFilter_Click);
            // 
            // btnUpdateFileFilter
            // 
            this.btnUpdateFileFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdateFileFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnUpdateFileFilter.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnUpdateFileFilter.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnUpdateFileFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateFileFilter.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdateFileFilter.ForeColor = System.Drawing.SystemColors.Control;
            this.btnUpdateFileFilter.Image = global::Utilities.Properties.Resources.icons8_update_clipboard_32;
            this.btnUpdateFileFilter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateFileFilter.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnUpdateFileFilter.Location = new System.Drawing.Point(615, 459);
            this.btnUpdateFileFilter.Name = "btnUpdateFileFilter";
            this.btnUpdateFileFilter.Size = new System.Drawing.Size(155, 44);
            this.btnUpdateFileFilter.TabIndex = 37;
            this.btnUpdateFileFilter.Text = "Update Selected";
            this.btnUpdateFileFilter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateFileFilter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdateFileFilter.UseVisualStyleBackColor = false;
            this.btnUpdateFileFilter.Click += new System.EventHandler(this.btnUpdateFileFilter_Click);
            // 
            // btnInsertFileFilter
            // 
            this.btnInsertFileFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInsertFileFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnInsertFileFilter.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnInsertFileFilter.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnInsertFileFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsertFileFilter.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnInsertFileFilter.ForeColor = System.Drawing.SystemColors.Control;
            this.btnInsertFileFilter.Image = global::Utilities.Properties.Resources.icons8_add_clipboard_32;
            this.btnInsertFileFilter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInsertFileFilter.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnInsertFileFilter.Location = new System.Drawing.Point(615, 407);
            this.btnInsertFileFilter.Name = "btnInsertFileFilter";
            this.btnInsertFileFilter.Size = new System.Drawing.Size(155, 44);
            this.btnInsertFileFilter.TabIndex = 35;
            this.btnInsertFileFilter.Text = "Add New Filter";
            this.btnInsertFileFilter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInsertFileFilter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInsertFileFilter.UseVisualStyleBackColor = false;
            this.btnInsertFileFilter.Click += new System.EventHandler(this.btnInsertFileFilter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(96, 339);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 38;
            this.label1.Text = "Extension:";
            // 
            // txtFileExtension
            // 
            this.txtFileExtension.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFileExtension.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtFileExtension.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtFileExtension.ForeColor = System.Drawing.Color.White;
            this.txtFileExtension.Location = new System.Drawing.Point(171, 336);
            this.txtFileExtension.Name = "txtFileExtension";
            this.txtFileExtension.Size = new System.Drawing.Size(426, 22);
            this.txtFileExtension.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(96, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 40;
            this.label2.Text = "File Name:";
            // 
            // txtFileName
            // 
            this.txtFileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFileName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtFileName.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtFileName.ForeColor = System.Drawing.Color.White;
            this.txtFileName.Location = new System.Drawing.Point(172, 190);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(425, 22);
            this.txtFileName.TabIndex = 41;
            // 
            // btnInsertFile
            // 
            this.btnInsertFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInsertFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnInsertFile.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnInsertFile.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnInsertFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsertFile.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnInsertFile.ForeColor = System.Drawing.SystemColors.Control;
            this.btnInsertFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInsertFile.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnInsertFile.Location = new System.Drawing.Point(345, 218);
            this.btnInsertFile.Name = "btnInsertFile";
            this.btnInsertFile.Size = new System.Drawing.Size(80, 24);
            this.btnInsertFile.TabIndex = 42;
            this.btnInsertFile.Text = "Add File";
            this.btnInsertFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInsertFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInsertFile.UseVisualStyleBackColor = false;
            this.btnInsertFile.Click += new System.EventHandler(this.btnInsertFile_Click);
            // 
            // btnInsertExtension
            // 
            this.btnInsertExtension.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInsertExtension.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnInsertExtension.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnInsertExtension.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnInsertExtension.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsertExtension.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnInsertExtension.ForeColor = System.Drawing.SystemColors.Control;
            this.btnInsertExtension.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInsertExtension.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnInsertExtension.Location = new System.Drawing.Point(234, 364);
            this.btnInsertExtension.Name = "btnInsertExtension";
            this.btnInsertExtension.Size = new System.Drawing.Size(117, 24);
            this.btnInsertExtension.TabIndex = 43;
            this.btnInsertExtension.Text = "Add Extension";
            this.btnInsertExtension.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInsertExtension.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInsertExtension.UseVisualStyleBackColor = false;
            this.btnInsertExtension.Click += new System.EventHandler(this.btnInsertExtension_Click);
            // 
            // btnDeleteExtension
            // 
            this.btnDeleteExtension.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteExtension.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnDeleteExtension.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDeleteExtension.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnDeleteExtension.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteExtension.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteExtension.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDeleteExtension.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteExtension.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnDeleteExtension.Location = new System.Drawing.Point(480, 364);
            this.btnDeleteExtension.Name = "btnDeleteExtension";
            this.btnDeleteExtension.Size = new System.Drawing.Size(117, 24);
            this.btnDeleteExtension.TabIndex = 44;
            this.btnDeleteExtension.Text = "Delete Extension";
            this.btnDeleteExtension.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteExtension.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeleteExtension.UseVisualStyleBackColor = false;
            this.btnDeleteExtension.Click += new System.EventHandler(this.btnDeleteExtension_Click);
            // 
            // btnDeleteFile
            // 
            this.btnDeleteFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnDeleteFile.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDeleteFile.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnDeleteFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteFile.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteFile.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDeleteFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteFile.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnDeleteFile.Location = new System.Drawing.Point(517, 218);
            this.btnDeleteFile.Name = "btnDeleteFile";
            this.btnDeleteFile.Size = new System.Drawing.Size(80, 24);
            this.btnDeleteFile.TabIndex = 45;
            this.btnDeleteFile.Text = "Delete File";
            this.btnDeleteFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeleteFile.UseVisualStyleBackColor = false;
            this.btnDeleteFile.Click += new System.EventHandler(this.btnDeleteFile_Click);
            // 
            // btnClearFields
            // 
            this.btnClearFields.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearFields.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnClearFields.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnClearFields.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnClearFields.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearFields.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClearFields.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClearFields.Image = global::Utilities.Properties.Resources.icons8_broom_32;
            this.btnClearFields.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClearFields.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnClearFields.Location = new System.Drawing.Point(615, 17);
            this.btnClearFields.Name = "btnClearFields";
            this.btnClearFields.Size = new System.Drawing.Size(155, 44);
            this.btnClearFields.TabIndex = 46;
            this.btnClearFields.Text = "Clear Fields";
            this.btnClearFields.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClearFields.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClearFields.UseVisualStyleBackColor = false;
            this.btnClearFields.Click += new System.EventHandler(this.btnClearFields_Click);
            // 
            // txtFilterNotes
            // 
            this.txtFilterNotes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilterNotes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtFilterNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFilterNotes.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtFilterNotes.ForeColor = System.Drawing.Color.White;
            this.txtFilterNotes.Location = new System.Drawing.Point(96, 45);
            this.txtFilterNotes.Name = "txtFilterNotes";
            this.txtFilterNotes.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtFilterNotes.Size = new System.Drawing.Size(501, 51);
            this.txtFilterNotes.TabIndex = 47;
            this.txtFilterNotes.Text = "";
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNotes.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNotes.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblNotes.Location = new System.Drawing.Point(12, 45);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(78, 16);
            this.lblNotes.TabIndex = 48;
            this.lblNotes.Text = "Filter Notes:";
            // 
            // FileFilters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(790, 570);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.txtFilterNotes);
            this.Controls.Add(this.btnClearFields);
            this.Controls.Add(this.btnDeleteFile);
            this.Controls.Add(this.btnDeleteExtension);
            this.Controls.Add(this.btnInsertExtension);
            this.Controls.Add(this.btnInsertFile);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFileExtension);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDeleteFileFilter);
            this.Controls.Add(this.btnUpdateFileFilter);
            this.Controls.Add(this.btnInsertFileFilter);
            this.Controls.Add(this.btnUpdateExtension);
            this.Controls.Add(this.lblFiles);
            this.Controls.Add(this.lblFileExtensions);
            this.Controls.Add(this.lsbFiles);
            this.Controls.Add(this.lsbFileExtensions);
            this.Controls.Add(this.lblSelection);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtFilterName);
            this.Controls.Add(this.dgvFileFilters);
            this.Controls.Add(this.btnUpdateFile);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FileFilters";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FileFilters";
            this.Load += new System.EventHandler(this.FileFilters_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFileFilters)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblSelection;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtFilterName;
        private System.Windows.Forms.DataGridView dgvFileFilters;
        private System.Windows.Forms.Button btnUpdateFile;
        private System.Windows.Forms.ListBox lsbFileExtensions;
        private System.Windows.Forms.ListBox lsbFiles;
        private System.Windows.Forms.Label lblFileExtensions;
        private System.Windows.Forms.Label lblFiles;
        private System.Windows.Forms.Button btnUpdateExtension;
        private System.Windows.Forms.Button btnDeleteFileFilter;
        private System.Windows.Forms.Button btnUpdateFileFilter;
        private System.Windows.Forms.Button btnInsertFileFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFileExtension;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Button btnInsertFile;
        private System.Windows.Forms.Button btnInsertExtension;
        private System.Windows.Forms.Button btnDeleteExtension;
        private System.Windows.Forms.Button btnDeleteFile;
        private System.Windows.Forms.Button btnClearFields;
        private System.Windows.Forms.RichTextBox txtFilterNotes;
        private System.Windows.Forms.Label lblNotes;
    }
}