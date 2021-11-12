namespace Utilities.Forms
{
    partial class CodeManage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CodeManage));
            this.lblCodeName = new System.Windows.Forms.Label();
            this.grpForm = new System.Windows.Forms.GroupBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCodeText = new System.Windows.Forms.TextBox();
            this.lblType = new System.Windows.Forms.Label();
            this.txtType = new System.Windows.Forms.TextBox();
            this.btnClearFields = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.grpMaintenance = new System.Windows.Forms.GroupBox();
            this.dgvCodes = new System.Windows.Forms.DataGridView();
            this.grpForm.SuspendLayout();
            this.grpMaintenance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCodes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodeName
            // 
            this.lblCodeName.AutoSize = true;
            this.lblCodeName.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCodeName.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCodeName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblCodeName.Location = new System.Drawing.Point(15, 59);
            this.lblCodeName.Name = "lblCodeName";
            this.lblCodeName.Size = new System.Drawing.Size(41, 16);
            this.lblCodeName.TabIndex = 1;
            this.lblCodeName.Text = "Code:";
            // 
            // grpForm
            // 
            this.grpForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.grpForm.Controls.Add(this.lblName);
            this.grpForm.Controls.Add(this.txtName);
            this.grpForm.Controls.Add(this.lblCodeName);
            this.grpForm.Controls.Add(this.txtCodeText);
            this.grpForm.Controls.Add(this.lblType);
            this.grpForm.Controls.Add(this.txtType);
            this.grpForm.Controls.Add(this.btnClearFields);
            this.grpForm.Controls.Add(this.btnInsert);
            this.grpForm.Controls.Add(this.btnUpdate);
            this.grpForm.Controls.Add(this.btnDelete);
            this.grpForm.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpForm.ForeColor = System.Drawing.Color.White;
            this.grpForm.Location = new System.Drawing.Point(12, 12);
            this.grpForm.Name = "grpForm";
            this.grpForm.Size = new System.Drawing.Size(962, 291);
            this.grpForm.TabIndex = 0;
            this.grpForm.TabStop = false;
            this.grpForm.Text = "Form";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblName.ForeColor = System.Drawing.SystemColors.Control;
            this.lblName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblName.Location = new System.Drawing.Point(15, 27);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 16);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtName.ForeColor = System.Drawing.Color.White;
            this.txtName.Location = new System.Drawing.Point(62, 24);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(300, 24);
            this.txtName.TabIndex = 4;
            // 
            // txtCodeText
            // 
            this.txtCodeText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtCodeText.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtCodeText.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtCodeText.ForeColor = System.Drawing.Color.White;
            this.txtCodeText.Location = new System.Drawing.Point(62, 55);
            this.txtCodeText.Margin = new System.Windows.Forms.Padding(0);
            this.txtCodeText.Multiline = true;
            this.txtCodeText.Name = "txtCodeText";
            this.txtCodeText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCodeText.Size = new System.Drawing.Size(734, 222);
            this.txtCodeText.TabIndex = 6;
            this.txtCodeText.TabStop = false;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblType.ForeColor = System.Drawing.SystemColors.Control;
            this.lblType.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblType.Location = new System.Drawing.Point(377, 27);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(38, 16);
            this.lblType.TabIndex = 2;
            this.lblType.Text = "Type:";
            // 
            // txtType
            // 
            this.txtType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtType.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtType.ForeColor = System.Drawing.Color.White;
            this.txtType.Location = new System.Drawing.Point(421, 24);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(170, 24);
            this.txtType.TabIndex = 5;
            // 
            // btnClearFields
            // 
            this.btnClearFields.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnClearFields.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnClearFields.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnClearFields.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearFields.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClearFields.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClearFields.Image = global::Utilities.Properties.Resources.icons8_broom_32;
            this.btnClearFields.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClearFields.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnClearFields.Location = new System.Drawing.Point(802, 55);
            this.btnClearFields.Name = "btnClearFields";
            this.btnClearFields.Size = new System.Drawing.Size(147, 45);
            this.btnClearFields.TabIndex = 8;
            this.btnClearFields.Text = "Clear Fields";
            this.btnClearFields.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClearFields.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClearFields.UseVisualStyleBackColor = false;
            this.btnClearFields.Click += new System.EventHandler(this.BtnClearFields_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnInsert.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnInsert.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsert.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnInsert.ForeColor = System.Drawing.SystemColors.Control;
            this.btnInsert.Image = global::Utilities.Properties.Resources.icons8_add_clipboard_32;
            this.btnInsert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInsert.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnInsert.Location = new System.Drawing.Point(802, 130);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(147, 45);
            this.btnInsert.TabIndex = 7;
            this.btnInsert.Text = "Add New Code";
            this.btnInsert.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInsert.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.BtnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.Control;
            this.btnUpdate.Image = global::Utilities.Properties.Resources.icons8_update_clipboard_32;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnUpdate.Location = new System.Drawing.Point(801, 181);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(148, 45);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Update Selected";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDelete.Image = global::Utilities.Properties.Resources.icons8_delete_clipboard_32;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnDelete.Location = new System.Drawing.Point(801, 232);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(148, 45);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete Selected";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // grpMaintenance
            // 
            this.grpMaintenance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.grpMaintenance.Controls.Add(this.dgvCodes);
            this.grpMaintenance.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpMaintenance.ForeColor = System.Drawing.Color.White;
            this.grpMaintenance.Location = new System.Drawing.Point(12, 309);
            this.grpMaintenance.Name = "grpMaintenance";
            this.grpMaintenance.Size = new System.Drawing.Size(962, 240);
            this.grpMaintenance.TabIndex = 1;
            this.grpMaintenance.TabStop = false;
            this.grpMaintenance.Text = "Selection";
            // 
            // dgvCodes
            // 
            this.dgvCodes.AllowUserToAddRows = false;
            this.dgvCodes.AllowUserToDeleteRows = false;
            this.dgvCodes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.dgvCodes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgvCodes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCodes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCodes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(52)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCodes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCodes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCodes.GridColor = System.Drawing.Color.White;
            this.dgvCodes.Location = new System.Drawing.Point(15, 22);
            this.dgvCodes.MultiSelect = false;
            this.dgvCodes.Name = "dgvCodes";
            this.dgvCodes.ReadOnly = true;
            this.dgvCodes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dgvCodes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCodes.RowHeadersVisible = false;
            this.dgvCodes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvCodes.RowTemplate.Height = 25;
            this.dgvCodes.RowTemplate.ReadOnly = true;
            this.dgvCodes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvCodes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCodes.Size = new System.Drawing.Size(934, 207);
            this.dgvCodes.TabIndex = 0;
            this.dgvCodes.SelectionChanged += new System.EventHandler(this.DgvCodes_SelectionChanged);
            // 
            // CodeManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(986, 561);
            this.Controls.Add(this.grpForm);
            this.Controls.Add(this.grpMaintenance);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CodeManage";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Codes";
            this.Load += new System.EventHandler(this.CodeManage_Load);
            this.grpForm.ResumeLayout(false);
            this.grpForm.PerformLayout();
            this.grpMaintenance.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCodes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCodeName;
        private System.Windows.Forms.GroupBox grpForm;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCodeText;
        private System.Windows.Forms.GroupBox grpMaintenance;
        private System.Windows.Forms.Button btnClearFields;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.DataGridView dgvCodes;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
    }
}