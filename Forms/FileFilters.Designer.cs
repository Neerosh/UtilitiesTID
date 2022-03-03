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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblSelection = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtFilterName = new System.Windows.Forms.TextBox();
            this.dgvFileFilters = new System.Windows.Forms.DataGridView();
            this.lblConditions = new System.Windows.Forms.Label();
            this.btnUpdateCondition = new System.Windows.Forms.Button();
            this.btnDeleteFileFilter = new System.Windows.Forms.Button();
            this.btnUpdateFileFilter = new System.Windows.Forms.Button();
            this.btnInsertFileFilter = new System.Windows.Forms.Button();
            this.lblCondition = new System.Windows.Forms.Label();
            this.txtCondition = new System.Windows.Forms.TextBox();
            this.btnInsertCondition = new System.Windows.Forms.Button();
            this.btnDeleteCondition = new System.Windows.Forms.Button();
            this.btnClearFields = new System.Windows.Forms.Button();
            this.txtFilterNotes = new System.Windows.Forms.RichTextBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.dgvFileFilterConditions = new System.Windows.Forms.DataGridView();
            this.cboConditionType = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFileFilters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFileFilterConditions)).BeginInit();
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
            this.dgvFileFilters.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvFileFilters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFileFilters.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgvFileFilters.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvFileFilters.GridColor = System.Drawing.Color.White;
            this.dgvFileFilters.Location = new System.Drawing.Point(12, 407);
            this.dgvFileFilters.MultiSelect = false;
            this.dgvFileFilters.Name = "dgvFileFilters";
            this.dgvFileFilters.ReadOnly = true;
            this.dgvFileFilters.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvFileFilters.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
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
            // lblConditions
            // 
            this.lblConditions.AutoSize = true;
            this.lblConditions.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblConditions.ForeColor = System.Drawing.SystemColors.Control;
            this.lblConditions.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblConditions.Location = new System.Drawing.Point(18, 149);
            this.lblConditions.Name = "lblConditions";
            this.lblConditions.Size = new System.Drawing.Size(72, 16);
            this.lblConditions.TabIndex = 33;
            this.lblConditions.Text = "Conditions:";
            // 
            // btnUpdateCondition
            // 
            this.btnUpdateCondition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdateCondition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnUpdateCondition.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnUpdateCondition.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnUpdateCondition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateCondition.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdateCondition.ForeColor = System.Drawing.SystemColors.Control;
            this.btnUpdateCondition.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateCondition.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnUpdateCondition.Location = new System.Drawing.Point(480, 333);
            this.btnUpdateCondition.Name = "btnUpdateCondition";
            this.btnUpdateCondition.Size = new System.Drawing.Size(117, 24);
            this.btnUpdateCondition.TabIndex = 34;
            this.btnUpdateCondition.Text = "Update Condition";
            this.btnUpdateCondition.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateCondition.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdateCondition.UseVisualStyleBackColor = false;
            this.btnUpdateCondition.Click += new System.EventHandler(this.btnUpdateCondition_Click);
            // 
            // btnDeleteFileFilter
            // 
            this.btnDeleteFileFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
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
            this.btnUpdateFileFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
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
            this.btnInsertFileFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
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
            // lblCondition
            // 
            this.lblCondition.AutoSize = true;
            this.lblCondition.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCondition.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCondition.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblCondition.Location = new System.Drawing.Point(96, 306);
            this.lblCondition.Name = "lblCondition";
            this.lblCondition.Size = new System.Drawing.Size(65, 16);
            this.lblCondition.TabIndex = 38;
            this.lblCondition.Text = "Condition:";
            // 
            // txtCondition
            // 
            this.txtCondition.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCondition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtCondition.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtCondition.ForeColor = System.Drawing.Color.White;
            this.txtCondition.Location = new System.Drawing.Point(167, 303);
            this.txtCondition.Name = "txtCondition";
            this.txtCondition.Size = new System.Drawing.Size(307, 22);
            this.txtCondition.TabIndex = 39;
            // 
            // btnInsertCondition
            // 
            this.btnInsertCondition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInsertCondition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnInsertCondition.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnInsertCondition.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnInsertCondition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsertCondition.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnInsertCondition.ForeColor = System.Drawing.SystemColors.Control;
            this.btnInsertCondition.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInsertCondition.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnInsertCondition.Location = new System.Drawing.Point(480, 303);
            this.btnInsertCondition.Name = "btnInsertCondition";
            this.btnInsertCondition.Size = new System.Drawing.Size(117, 24);
            this.btnInsertCondition.TabIndex = 43;
            this.btnInsertCondition.Text = "Add Condition";
            this.btnInsertCondition.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInsertCondition.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInsertCondition.UseVisualStyleBackColor = false;
            this.btnInsertCondition.Click += new System.EventHandler(this.btnInsertCondition_Click);
            // 
            // btnDeleteCondition
            // 
            this.btnDeleteCondition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteCondition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnDeleteCondition.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDeleteCondition.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnDeleteCondition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteCondition.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteCondition.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDeleteCondition.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteCondition.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnDeleteCondition.Location = new System.Drawing.Point(480, 363);
            this.btnDeleteCondition.Name = "btnDeleteCondition";
            this.btnDeleteCondition.Size = new System.Drawing.Size(117, 24);
            this.btnDeleteCondition.TabIndex = 44;
            this.btnDeleteCondition.Text = "Delete Condition";
            this.btnDeleteCondition.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteCondition.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeleteCondition.UseVisualStyleBackColor = false;
            this.btnDeleteCondition.Click += new System.EventHandler(this.btnDeleteCondition_Click);
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
            this.txtFilterNotes.Size = new System.Drawing.Size(501, 98);
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
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblType.ForeColor = System.Drawing.SystemColors.Control;
            this.lblType.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblType.Location = new System.Drawing.Point(123, 334);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(38, 16);
            this.lblType.TabIndex = 49;
            this.lblType.Text = "Type:";
            // 
            // dgvFileFilterConditions
            // 
            this.dgvFileFilterConditions.AllowUserToAddRows = false;
            this.dgvFileFilterConditions.AllowUserToDeleteRows = false;
            this.dgvFileFilterConditions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFileFilterConditions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.dgvFileFilterConditions.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgvFileFilterConditions.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.dgvFileFilterConditions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvFileFilterConditions.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvFileFilterConditions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvFileFilterConditions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFileFilterConditions.DefaultCellStyle = dataGridViewCellStyle17;
            this.dgvFileFilterConditions.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvFileFilterConditions.GridColor = System.Drawing.Color.White;
            this.dgvFileFilterConditions.Location = new System.Drawing.Point(96, 149);
            this.dgvFileFilterConditions.MultiSelect = false;
            this.dgvFileFilterConditions.Name = "dgvFileFilterConditions";
            this.dgvFileFilterConditions.ReadOnly = true;
            this.dgvFileFilterConditions.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvFileFilterConditions.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dgvFileFilterConditions.RowHeadersVisible = false;
            this.dgvFileFilterConditions.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvFileFilterConditions.RowTemplate.Height = 25;
            this.dgvFileFilterConditions.RowTemplate.ReadOnly = true;
            this.dgvFileFilterConditions.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvFileFilterConditions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFileFilterConditions.Size = new System.Drawing.Size(501, 146);
            this.dgvFileFilterConditions.TabIndex = 50;
            this.dgvFileFilterConditions.SelectionChanged += new System.EventHandler(this.dgvFileFilterConditions_SelectionChanged);
            // 
            // cboConditionType
            // 
            this.cboConditionType.AutoCompleteCustomSource.AddRange(new string[] {
            "List Owners ap~"});
            this.cboConditionType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.cboConditionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboConditionType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboConditionType.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cboConditionType.ForeColor = System.Drawing.Color.White;
            this.cboConditionType.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cboConditionType.Items.AddRange(new object[] {
            "Name Contains",
            "Name Ends With",
            "Name is Exactly"});
            this.cboConditionType.Location = new System.Drawing.Point(167, 331);
            this.cboConditionType.Name = "cboConditionType";
            this.cboConditionType.Size = new System.Drawing.Size(170, 24);
            this.cboConditionType.Sorted = true;
            this.cboConditionType.TabIndex = 51;
            // 
            // FileFilters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(790, 570);
            this.Controls.Add(this.dgvFileFilters);
            this.Controls.Add(this.lblSelection);
            this.Controls.Add(this.btnDeleteFileFilter);
            this.Controls.Add(this.btnUpdateFileFilter);
            this.Controls.Add(this.btnInsertFileFilter);
            this.Controls.Add(this.btnClearFields);
            this.Controls.Add(this.btnDeleteCondition);
            this.Controls.Add(this.btnUpdateCondition);
            this.Controls.Add(this.btnInsertCondition);
            this.Controls.Add(this.cboConditionType);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.txtCondition);
            this.Controls.Add(this.lblCondition);
            this.Controls.Add(this.dgvFileFilterConditions);
            this.Controls.Add(this.lblConditions);
            this.Controls.Add(this.txtFilterNotes);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.txtFilterName);
            this.Controls.Add(this.lblName);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FileFilters";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FileFilters";
            this.Load += new System.EventHandler(this.FileFilters_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FileFilters_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFileFilters)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFileFilterConditions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblSelection;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtFilterName;
        private System.Windows.Forms.DataGridView dgvFileFilters;
        private System.Windows.Forms.Label lblConditions;
        private System.Windows.Forms.Button btnUpdateCondition;
        private System.Windows.Forms.Button btnDeleteFileFilter;
        private System.Windows.Forms.Button btnUpdateFileFilter;
        private System.Windows.Forms.Button btnInsertFileFilter;
        private System.Windows.Forms.Label lblCondition;
        private System.Windows.Forms.TextBox txtCondition;
        private System.Windows.Forms.Button btnInsertCondition;
        private System.Windows.Forms.Button btnDeleteCondition;
        private System.Windows.Forms.Button btnClearFields;
        private System.Windows.Forms.RichTextBox txtFilterNotes;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.DataGridView dgvFileFilterConditions;
        private System.Windows.Forms.ComboBox cboConditionType;
    }
}