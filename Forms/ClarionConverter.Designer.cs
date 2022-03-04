namespace Utilities.Forms
{
    partial class ClarionConverter
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
            this.lblTime = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.MaskedTextBox();
            this.lblClarionTime = new System.Windows.Forms.Label();
            this.txtClarionTime = new System.Windows.Forms.MaskedTextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.MaskedTextBox();
            this.lblClarionDate = new System.Windows.Forms.Label();
            this.txtClarionDate = new System.Windows.Forms.MaskedTextBox();
            this.lblWeekDay = new System.Windows.Forms.Label();
            this.txtWeekDay = new System.Windows.Forms.TextBox();
            this.cboDateFormat = new System.Windows.Forms.ComboBox();
            this.lblDateFormat = new System.Windows.Forms.Label();
            this.txtTimeConversion = new System.Windows.Forms.RichTextBox();
            this.txtDateConversion = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTime.Location = new System.Drawing.Point(20, 25);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(39, 16);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "Time:";
            // 
            // txtTime
            // 
            this.txtTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtTime.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtTime.ForeColor = System.Drawing.Color.White;
            this.txtTime.Location = new System.Drawing.Point(65, 22);
            this.txtTime.Mask = "00:00";
            this.txtTime.Name = "txtTime";
            this.txtTime.PromptChar = ' ';
            this.txtTime.Size = new System.Drawing.Size(79, 22);
            this.txtTime.TabIndex = 1;
            this.txtTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTime.ValidatingType = typeof(System.DateTime);
            this.txtTime.Validated += new System.EventHandler(this.TxtTime_Validated);
            // 
            // lblClarionTime
            // 
            this.lblClarionTime.AutoSize = true;
            this.lblClarionTime.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblClarionTime.Location = new System.Drawing.Point(156, 25);
            this.lblClarionTime.Name = "lblClarionTime";
            this.lblClarionTime.Size = new System.Drawing.Size(83, 16);
            this.lblClarionTime.TabIndex = 2;
            this.lblClarionTime.Text = "Clarion Time:";
            // 
            // txtClarionTime
            // 
            this.txtClarionTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtClarionTime.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtClarionTime.ForeColor = System.Drawing.Color.White;
            this.txtClarionTime.Location = new System.Drawing.Point(244, 22);
            this.txtClarionTime.Mask = "000000000";
            this.txtClarionTime.Name = "txtClarionTime";
            this.txtClarionTime.PromptChar = ' ';
            this.txtClarionTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtClarionTime.Size = new System.Drawing.Size(80, 22);
            this.txtClarionTime.TabIndex = 3;
            this.txtClarionTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtClarionTime.ValidatingType = typeof(int);
            this.txtClarionTime.Validated += new System.EventHandler(this.TxtClarionTime_Validated);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDate.Location = new System.Drawing.Point(20, 162);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(38, 16);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "Date:";
            // 
            // txtDate
            // 
            this.txtDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtDate.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtDate.ForeColor = System.Drawing.Color.White;
            this.txtDate.Location = new System.Drawing.Point(64, 159);
            this.txtDate.Mask = "00/00/0000";
            this.txtDate.Name = "txtDate";
            this.txtDate.PromptChar = ' ';
            this.txtDate.Size = new System.Drawing.Size(80, 22);
            this.txtDate.TabIndex = 5;
            this.txtDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDate.ValidatingType = typeof(System.DateTime);
            this.txtDate.Validated += new System.EventHandler(this.TxtDate_Validated);
            // 
            // lblClarionDate
            // 
            this.lblClarionDate.AutoSize = true;
            this.lblClarionDate.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblClarionDate.Location = new System.Drawing.Point(156, 162);
            this.lblClarionDate.Name = "lblClarionDate";
            this.lblClarionDate.Size = new System.Drawing.Size(82, 16);
            this.lblClarionDate.TabIndex = 6;
            this.lblClarionDate.Text = "Clarion Date:";
            // 
            // txtClarionDate
            // 
            this.txtClarionDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtClarionDate.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtClarionDate.ForeColor = System.Drawing.Color.White;
            this.txtClarionDate.Location = new System.Drawing.Point(244, 159);
            this.txtClarionDate.Mask = "0000000";
            this.txtClarionDate.Name = "txtClarionDate";
            this.txtClarionDate.PromptChar = ' ';
            this.txtClarionDate.Size = new System.Drawing.Size(80, 22);
            this.txtClarionDate.TabIndex = 7;
            this.txtClarionDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtClarionDate.ValidatingType = typeof(int);
            this.txtClarionDate.Validated += new System.EventHandler(this.TxtClarionDate_Validated);
            // 
            // lblWeekDay
            // 
            this.lblWeekDay.AutoSize = true;
            this.lblWeekDay.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblWeekDay.Location = new System.Drawing.Point(340, 162);
            this.lblWeekDay.Name = "lblWeekDay";
            this.lblWeekDay.Size = new System.Drawing.Size(72, 16);
            this.lblWeekDay.TabIndex = 8;
            this.lblWeekDay.Text = "Week Day:";
            // 
            // txtWeekDay
            // 
            this.txtWeekDay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtWeekDay.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtWeekDay.ForeColor = System.Drawing.Color.White;
            this.txtWeekDay.Location = new System.Drawing.Point(418, 159);
            this.txtWeekDay.Name = "txtWeekDay";
            this.txtWeekDay.ReadOnly = true;
            this.txtWeekDay.Size = new System.Drawing.Size(104, 22);
            this.txtWeekDay.TabIndex = 9;
            // 
            // cboDateFormat
            // 
            this.cboDateFormat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.cboDateFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDateFormat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboDateFormat.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cboDateFormat.ForeColor = System.Drawing.Color.White;
            this.cboDateFormat.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cboDateFormat.Location = new System.Drawing.Point(627, 159);
            this.cboDateFormat.Name = "cboDateFormat";
            this.cboDateFormat.Size = new System.Drawing.Size(103, 24);
            this.cboDateFormat.Sorted = true;
            this.cboDateFormat.TabIndex = 10;
            // 
            // lblDateFormat
            // 
            this.lblDateFormat.AutoSize = true;
            this.lblDateFormat.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDateFormat.Location = new System.Drawing.Point(538, 162);
            this.lblDateFormat.Name = "lblDateFormat";
            this.lblDateFormat.Size = new System.Drawing.Size(83, 16);
            this.lblDateFormat.TabIndex = 11;
            this.lblDateFormat.Text = "Date Format:";
            // 
            // txtTimeConversion
            // 
            this.txtTimeConversion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimeConversion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtTimeConversion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTimeConversion.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtTimeConversion.ForeColor = System.Drawing.Color.White;
            this.txtTimeConversion.HideSelection = false;
            this.txtTimeConversion.Location = new System.Drawing.Point(20, 59);
            this.txtTimeConversion.Name = "txtTimeConversion";
            this.txtTimeConversion.ReadOnly = true;
            this.txtTimeConversion.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtTimeConversion.Size = new System.Drawing.Size(738, 80);
            this.txtTimeConversion.TabIndex = 17;
            this.txtTimeConversion.TabStop = false;
            this.txtTimeConversion.Text = "";
            // 
            // txtDateConversion
            // 
            this.txtDateConversion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDateConversion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtDateConversion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDateConversion.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtDateConversion.ForeColor = System.Drawing.Color.White;
            this.txtDateConversion.HideSelection = false;
            this.txtDateConversion.Location = new System.Drawing.Point(20, 202);
            this.txtDateConversion.Name = "txtDateConversion";
            this.txtDateConversion.ReadOnly = true;
            this.txtDateConversion.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtDateConversion.Size = new System.Drawing.Size(738, 129);
            this.txtDateConversion.TabIndex = 18;
            this.txtDateConversion.TabStop = false;
            this.txtDateConversion.Text = "";
            // 
            // ClarionConversion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(790, 570);
            this.Controls.Add(this.txtDateConversion);
            this.Controls.Add(this.txtTimeConversion);
            this.Controls.Add(this.lblDateFormat);
            this.Controls.Add(this.cboDateFormat);
            this.Controls.Add(this.txtWeekDay);
            this.Controls.Add(this.lblWeekDay);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.lblClarionTime);
            this.Controls.Add(this.txtClarionDate);
            this.Controls.Add(this.txtClarionTime);
            this.Controls.Add(this.lblClarionDate);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.txtDate);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ClarionConversion";
            this.Text = "Clarion Conversion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.MaskedTextBox txtTime;
        private System.Windows.Forms.Label lblClarionTime;
        private System.Windows.Forms.MaskedTextBox txtClarionTime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.MaskedTextBox txtDate;
        private System.Windows.Forms.Label lblClarionDate;
        private System.Windows.Forms.MaskedTextBox txtClarionDate;
        private System.Windows.Forms.Label lblWeekDay;
        private System.Windows.Forms.TextBox txtWeekDay;
        private System.Windows.Forms.ComboBox cboDateFormat;
        private System.Windows.Forms.Label lblDateFormat;
        private System.Windows.Forms.RichTextBox txtTimeConversion;
        private System.Windows.Forms.RichTextBox txtDateConversion;
    }
}