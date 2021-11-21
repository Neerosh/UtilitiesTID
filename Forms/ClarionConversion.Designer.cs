namespace Utilities.Forms
{
    partial class ClarionConversion
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
            this.txtTime.Size = new System.Drawing.Size(80, 22);
            this.txtTime.TabIndex = 1;
            this.txtTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTime.ValidatingType = typeof(System.DateTime);
            this.txtTime.Validated += new System.EventHandler(this.TxtTime_Validated);
            // 
            // lblClarionTime
            // 
            this.lblClarionTime.AutoSize = true;
            this.lblClarionTime.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblClarionTime.Location = new System.Drawing.Point(157, 25);
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
            this.txtClarionTime.Location = new System.Drawing.Point(245, 22);
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
            this.lblDate.Location = new System.Drawing.Point(21, 57);
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
            this.txtDate.Location = new System.Drawing.Point(65, 54);
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
            this.lblClarionDate.Location = new System.Drawing.Point(157, 57);
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
            this.txtClarionDate.Location = new System.Drawing.Point(245, 54);
            this.txtClarionDate.Mask = "0000000";
            this.txtClarionDate.Name = "txtClarionDate";
            this.txtClarionDate.PromptChar = ' ';
            this.txtClarionDate.Size = new System.Drawing.Size(80, 22);
            this.txtClarionDate.TabIndex = 7;
            this.txtClarionDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtClarionDate.ValidatingType = typeof(int);
            this.txtClarionDate.Validated += new System.EventHandler(this.TxtClarionDate_Validated);
            // 
            // ClarionConversion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(790, 570);
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
    }
}