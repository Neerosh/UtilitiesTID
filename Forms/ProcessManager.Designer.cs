namespace Utilities.Forms
{
    partial class ProcessManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProcessManager));
            this.dgvProcess = new System.Windows.Forms.DataGridView();
            this.btnListProcesses = new System.Windows.Forms.Button();
            this.lblFilters = new System.Windows.Forms.Label();
            this.txtWhereValue = new System.Windows.Forms.TextBox();
            this.btnListFilteredProcesses = new System.Windows.Forms.Button();
            this.chkShowUnknownUsers = new System.Windows.Forms.CheckBox();
            this.btnEndSelectedProcess = new System.Windows.Forms.Button();
            this.lblListProgress = new System.Windows.Forms.Label();
            this.cboWhereField = new System.Windows.Forms.ComboBox();
            this.lblProcesses = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcess)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProcess
            // 
            this.dgvProcess.AllowUserToAddRows = false;
            this.dgvProcess.AllowUserToDeleteRows = false;
            this.dgvProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProcess.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.dgvProcess.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgvProcess.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.dgvProcess.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProcess.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvProcess.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProcess.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProcess.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProcess.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvProcess.GridColor = System.Drawing.Color.White;
            this.dgvProcess.Location = new System.Drawing.Point(24, 105);
            this.dgvProcess.MultiSelect = false;
            this.dgvProcess.Name = "dgvProcess";
            this.dgvProcess.ReadOnly = true;
            this.dgvProcess.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvProcess.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProcess.RowHeadersVisible = false;
            this.dgvProcess.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvProcess.RowTemplate.Height = 25;
            this.dgvProcess.RowTemplate.ReadOnly = true;
            this.dgvProcess.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvProcess.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProcess.Size = new System.Drawing.Size(564, 444);
            this.dgvProcess.TabIndex = 7;
            // 
            // btnListProcesses
            // 
            this.btnListProcesses.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnListProcesses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnListProcesses.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnListProcesses.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnListProcesses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListProcesses.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnListProcesses.ForeColor = System.Drawing.SystemColors.Control;
            this.btnListProcesses.Image = global::Utilities.Properties.Resources.icons8_process_32;
            this.btnListProcesses.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListProcesses.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnListProcesses.Location = new System.Drawing.Point(606, 105);
            this.btnListProcesses.Name = "btnListProcesses";
            this.btnListProcesses.Size = new System.Drawing.Size(155, 44);
            this.btnListProcesses.TabIndex = 5;
            this.btnListProcesses.Text = "List Running Processes";
            this.btnListProcesses.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListProcesses.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnListProcesses.UseVisualStyleBackColor = false;
            this.btnListProcesses.Click += new System.EventHandler(this.BtnListProcesses_Click);
            // 
            // lblFilters
            // 
            this.lblFilters.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFilters.AutoSize = true;
            this.lblFilters.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFilters.ForeColor = System.Drawing.SystemColors.Control;
            this.lblFilters.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblFilters.Location = new System.Drawing.Point(24, 35);
            this.lblFilters.Name = "lblFilters";
            this.lblFilters.Size = new System.Drawing.Size(49, 16);
            this.lblFilters.TabIndex = 0;
            this.lblFilters.Text = "Where:";
            // 
            // txtWhereValue
            // 
            this.txtWhereValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtWhereValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtWhereValue.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtWhereValue.ForeColor = System.Drawing.Color.White;
            this.txtWhereValue.Location = new System.Drawing.Point(249, 32);
            this.txtWhereValue.Name = "txtWhereValue";
            this.txtWhereValue.Size = new System.Drawing.Size(339, 22);
            this.txtWhereValue.TabIndex = 1;
            this.txtWhereValue.Validated += new System.EventHandler(this.TxtWhereValue_Validated);
            // 
            // btnListFilteredProcesses
            // 
            this.btnListFilteredProcesses.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnListFilteredProcesses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnListFilteredProcesses.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnListFilteredProcesses.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btnListFilteredProcesses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListFilteredProcesses.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnListFilteredProcesses.ForeColor = System.Drawing.SystemColors.Control;
            this.btnListFilteredProcesses.Image = global::Utilities.Properties.Resources.icons8_search_process_32;
            this.btnListFilteredProcesses.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListFilteredProcesses.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnListFilteredProcesses.Location = new System.Drawing.Point(606, 21);
            this.btnListFilteredProcesses.Name = "btnListFilteredProcesses";
            this.btnListFilteredProcesses.Size = new System.Drawing.Size(155, 44);
            this.btnListFilteredProcesses.TabIndex = 4;
            this.btnListFilteredProcesses.Text = "List Filtered Processes";
            this.btnListFilteredProcesses.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListFilteredProcesses.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnListFilteredProcesses.UseVisualStyleBackColor = false;
            this.btnListFilteredProcesses.Click += new System.EventHandler(this.BtnListFilteredProcesses_Click);
            // 
            // chkShowUnknownUsers
            // 
            this.chkShowUnknownUsers.AutoSize = true;
            this.chkShowUnknownUsers.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkShowUnknownUsers.ForeColor = System.Drawing.Color.White;
            this.chkShowUnknownUsers.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chkShowUnknownUsers.Location = new System.Drawing.Point(79, 63);
            this.chkShowUnknownUsers.Name = "chkShowUnknownUsers";
            this.chkShowUnknownUsers.Size = new System.Drawing.Size(250, 20);
            this.chkShowUnknownUsers.TabIndex = 3;
            this.chkShowUnknownUsers.Text = "Show Processes With Unknown Users";
            this.chkShowUnknownUsers.UseVisualStyleBackColor = true;
            // 
            // btnEndSelectedProcess
            // 
            this.btnEndSelectedProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEndSelectedProcess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnEndSelectedProcess.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEndSelectedProcess.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnEndSelectedProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEndSelectedProcess.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEndSelectedProcess.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEndSelectedProcess.Image = global::Utilities.Properties.Resources.icons8_delete_process_32;
            this.btnEndSelectedProcess.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEndSelectedProcess.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnEndSelectedProcess.Location = new System.Drawing.Point(606, 505);
            this.btnEndSelectedProcess.Name = "btnEndSelectedProcess";
            this.btnEndSelectedProcess.Size = new System.Drawing.Size(155, 44);
            this.btnEndSelectedProcess.TabIndex = 6;
            this.btnEndSelectedProcess.Text = "End Selected Process";
            this.btnEndSelectedProcess.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEndSelectedProcess.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEndSelectedProcess.UseVisualStyleBackColor = false;
            this.btnEndSelectedProcess.Click += new System.EventHandler(this.BtnEndSelectedProcess_Click);
            // 
            // lblListProgress
            // 
            this.lblListProgress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblListProgress.AutoSize = true;
            this.lblListProgress.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblListProgress.ForeColor = System.Drawing.Color.Chartreuse;
            this.lblListProgress.Location = new System.Drawing.Point(465, 86);
            this.lblListProgress.Name = "lblListProgress";
            this.lblListProgress.Size = new System.Drawing.Size(123, 16);
            this.lblListProgress.TabIndex = 27;
            this.lblListProgress.Text = "Listing Processes...";
            this.lblListProgress.Visible = false;
            // 
            // cboWhereField
            // 
            this.cboWhereField.AutoCompleteCustomSource.AddRange(new string[] {
            "List Owners ap~"});
            this.cboWhereField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.cboWhereField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboWhereField.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboWhereField.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cboWhereField.ForeColor = System.Drawing.Color.White;
            this.cboWhereField.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cboWhereField.Items.AddRange(new object[] {
            "ID",
            "Name"});
            this.cboWhereField.Location = new System.Drawing.Point(79, 32);
            this.cboWhereField.Name = "cboWhereField";
            this.cboWhereField.Size = new System.Drawing.Size(83, 24);
            this.cboWhereField.Sorted = true;
            this.cboWhereField.TabIndex = 28;
            this.cboWhereField.SelectionChangeCommitted += new System.EventHandler(this.cboWhereField_SelectionChangeCommitted);
            // 
            // lblProcesses
            // 
            this.lblProcesses.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProcesses.AutoSize = true;
            this.lblProcesses.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblProcesses.ForeColor = System.Drawing.SystemColors.Control;
            this.lblProcesses.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblProcesses.Location = new System.Drawing.Point(24, 86);
            this.lblProcesses.Name = "lblProcesses";
            this.lblProcesses.Size = new System.Drawing.Size(73, 16);
            this.lblProcesses.TabIndex = 30;
            this.lblProcesses.Text = "Processes:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(174, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 31;
            this.label1.Text = "Is Exactly:";
            // 
            // ProcessManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(790, 570);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblProcesses);
            this.Controls.Add(this.cboWhereField);
            this.Controls.Add(this.lblListProgress);
            this.Controls.Add(this.btnEndSelectedProcess);
            this.Controls.Add(this.chkShowUnknownUsers);
            this.Controls.Add(this.lblFilters);
            this.Controls.Add(this.txtWhereValue);
            this.Controls.Add(this.btnListFilteredProcesses);
            this.Controls.Add(this.btnListProcesses);
            this.Controls.Add(this.dgvProcess);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProcessManager";
            this.Text = "ProcessManagement";
            this.Load += new System.EventHandler(this.ProcessManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcess)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProcess;
        private System.Windows.Forms.Button btnListProcesses;
        private System.Windows.Forms.Label lblFilters;
        private System.Windows.Forms.TextBox txtWhereValue;
        private System.Windows.Forms.Button btnListFilteredProcesses;
        private System.Windows.Forms.CheckBox chkShowUnknownUsers;
        private System.Windows.Forms.Button btnEndSelectedProcess;
        private System.Windows.Forms.Label lblListProgress;
        private System.Windows.Forms.ComboBox cboWhereField;
        private System.Windows.Forms.Label lblProcesses;
        private System.Windows.Forms.Label label1;
    }
}