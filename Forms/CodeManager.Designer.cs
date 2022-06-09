namespace Utilities.Forms
{
    partial class CodeManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CodeManager));
            this.lblCodeText = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblType = new System.Windows.Forms.Label();
            this.txtType = new System.Windows.Forms.TextBox();
            this.btnClearFields = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvCodes = new System.Windows.Forms.DataGridView();
            this.lblCodes = new System.Windows.Forms.Label();
            this.txtCodeText = new System.Windows.Forms.RichTextBox();
            this.btnDeleteAll = new System.Windows.Forms.Button();
            this.btnAddDefaults = new System.Windows.Forms.Button();
            this.btnExportCodes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCodes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodeText
            // 
            this.lblCodeText.AutoSize = true;
            this.lblCodeText.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCodeText.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCodeText.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblCodeText.Location = new System.Drawing.Point(20, 80);
            this.lblCodeText.Name = "lblCodeText";
            this.lblCodeText.Size = new System.Drawing.Size(41, 16);
            this.lblCodeText.TabIndex = 5;
            this.lblCodeText.Text = "Code:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblName.ForeColor = System.Drawing.SystemColors.Control;
            this.lblName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblName.Location = new System.Drawing.Point(16, 25);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 16);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtName.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtName.ForeColor = System.Drawing.Color.White;
            this.txtName.Location = new System.Drawing.Point(67, 22);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(433, 22);
            this.txtName.TabIndex = 2;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblType.ForeColor = System.Drawing.SystemColors.Control;
            this.lblType.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblType.Location = new System.Drawing.Point(23, 53);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(38, 16);
            this.lblType.TabIndex = 3;
            this.lblType.Text = "Type:";
            // 
            // txtType
            // 
            this.txtType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtType.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtType.ForeColor = System.Drawing.Color.White;
            this.txtType.Location = new System.Drawing.Point(67, 50);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(210, 22);
            this.txtType.TabIndex = 4;
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
            this.btnClearFields.Location = new System.Drawing.Point(516, 22);
            this.btnClearFields.Name = "btnClearFields";
            this.btnClearFields.Size = new System.Drawing.Size(138, 44);
            this.btnClearFields.TabIndex = 8;
            this.btnClearFields.Text = "Clear Fields";
            this.btnClearFields.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClearFields.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClearFields.UseVisualStyleBackColor = false;
            this.btnClearFields.Click += new System.EventHandler(this.BtnClearFields_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnInsert.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnInsert.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsert.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnInsert.ForeColor = System.Drawing.SystemColors.Control;
            this.btnInsert.Image = global::Utilities.Properties.Resources.icons8_add_clipboard_32;
            this.btnInsert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInsert.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnInsert.Location = new System.Drawing.Point(516, 136);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(138, 44);
            this.btnInsert.TabIndex = 9;
            this.btnInsert.Text = "Insert Code";
            this.btnInsert.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInsert.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.BtnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.Control;
            this.btnUpdate.Image = global::Utilities.Properties.Resources.icons8_update_clipboard_32;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnUpdate.Location = new System.Drawing.Point(516, 186);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(138, 44);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Update Code";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDelete.Image = global::Utilities.Properties.Resources.icons8_delete_clipboard_32;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnDelete.Location = new System.Drawing.Point(516, 236);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(138, 44);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete Code";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // dgvCodes
            // 
            this.dgvCodes.AllowUserToAddRows = false;
            this.dgvCodes.AllowUserToDeleteRows = false;
            this.dgvCodes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCodes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.dgvCodes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgvCodes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.dgvCodes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCodes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCodes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCodes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCodes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCodes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCodes.GridColor = System.Drawing.Color.White;
            this.dgvCodes.Location = new System.Drawing.Point(20, 310);
            this.dgvCodes.MultiSelect = false;
            this.dgvCodes.Name = "dgvCodes";
            this.dgvCodes.ReadOnly = true;
            this.dgvCodes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCodes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCodes.RowHeadersVisible = false;
            this.dgvCodes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvCodes.RowTemplate.Height = 25;
            this.dgvCodes.RowTemplate.ReadOnly = true;
            this.dgvCodes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvCodes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCodes.Size = new System.Drawing.Size(480, 213);
            this.dgvCodes.TabIndex = 14;
            this.dgvCodes.SelectionChanged += new System.EventHandler(this.DgvCodes_SelectionChanged);
            // 
            // lblCodes
            // 
            this.lblCodes.AutoSize = true;
            this.lblCodes.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCodes.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCodes.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblCodes.Location = new System.Drawing.Point(20, 291);
            this.lblCodes.Name = "lblCodes";
            this.lblCodes.Size = new System.Drawing.Size(48, 16);
            this.lblCodes.TabIndex = 7;
            this.lblCodes.Text = "Codes:";
            // 
            // txtCodeText
            // 
            this.txtCodeText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCodeText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtCodeText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodeText.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtCodeText.ForeColor = System.Drawing.Color.White;
            this.txtCodeText.Location = new System.Drawing.Point(67, 78);
            this.txtCodeText.Name = "txtCodeText";
            this.txtCodeText.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtCodeText.Size = new System.Drawing.Size(433, 202);
            this.txtCodeText.TabIndex = 6;
            this.txtCodeText.Text = "";
            // 
            // btnDeleteAll
            // 
            this.btnDeleteAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnDeleteAll.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDeleteAll.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnDeleteAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteAll.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteAll.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDeleteAll.Image = global::Utilities.Properties.Resources.icons8_delete_database_32;
            this.btnDeleteAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteAll.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnDeleteAll.Location = new System.Drawing.Point(516, 479);
            this.btnDeleteAll.Name = "btnDeleteAll";
            this.btnDeleteAll.Size = new System.Drawing.Size(138, 44);
            this.btnDeleteAll.TabIndex = 13;
            this.btnDeleteAll.Text = "Delete All Codes";
            this.btnDeleteAll.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteAll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeleteAll.UseVisualStyleBackColor = false;
            this.btnDeleteAll.Click += new System.EventHandler(this.btnDeleteAll_Click);
            // 
            // btnAddDefaults
            // 
            this.btnAddDefaults.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddDefaults.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnAddDefaults.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAddDefaults.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnAddDefaults.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDefaults.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddDefaults.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAddDefaults.Image = global::Utilities.Properties.Resources.icons8_add_database_32;
            this.btnAddDefaults.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddDefaults.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAddDefaults.Location = new System.Drawing.Point(516, 429);
            this.btnAddDefaults.Name = "btnAddDefaults";
            this.btnAddDefaults.Size = new System.Drawing.Size(138, 44);
            this.btnAddDefaults.TabIndex = 12;
            this.btnAddDefaults.Text = "Add Default Codes";
            this.btnAddDefaults.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddDefaults.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddDefaults.UseVisualStyleBackColor = false;
            this.btnAddDefaults.Click += new System.EventHandler(this.btnAddDefaults_Click);
            // 
            // btnExportCodes
            // 
            this.btnExportCodes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportCodes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnExportCodes.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExportCodes.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnExportCodes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportCodes.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExportCodes.ForeColor = System.Drawing.SystemColors.Control;
            this.btnExportCodes.Image = global::Utilities.Properties.Resources.icons8_inscription_32;
            this.btnExportCodes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportCodes.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnExportCodes.Location = new System.Drawing.Point(516, 310);
            this.btnExportCodes.Name = "btnExportCodes";
            this.btnExportCodes.Size = new System.Drawing.Size(138, 44);
            this.btnExportCodes.TabIndex = 15;
            this.btnExportCodes.Text = "Export Codes";
            this.btnExportCodes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportCodes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExportCodes.UseVisualStyleBackColor = false;
            this.btnExportCodes.Click += new System.EventHandler(this.btnExportCodes_Click);
            // 
            // CodeManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(678, 535);
            this.Controls.Add(this.btnExportCodes);
            this.Controls.Add(this.txtCodeText);
            this.Controls.Add(this.btnAddDefaults);
            this.Controls.Add(this.btnDeleteAll);
            this.Controls.Add(this.lblCodes);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.dgvCodes);
            this.Controls.Add(this.lblCodeText);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnClearFields);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "CodeManager";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Codes > Manage";
            this.Load += new System.EventHandler(this.CodeManage_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CodeManage_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCodes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodeText;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnClearFields;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.DataGridView dgvCodes;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblCodes;
        private System.Windows.Forms.RichTextBox txtCodeText;
        private System.Windows.Forms.Button btnDeleteAll;
        private System.Windows.Forms.Button btnAddDefaults;
        private System.Windows.Forms.Button btnExportCodes;
    }
}