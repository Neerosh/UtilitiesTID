
namespace Utilities
{
    partial class ClarionDateTime
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClarionDateTime));
            this.grpDateTime = new System.Windows.Forms.GroupBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.MaskedTextBox();
            this.lblClarionTime = new System.Windows.Forms.Label();
            this.txtClarionTime = new System.Windows.Forms.MaskedTextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.MaskedTextBox();
            this.lblClarionDate = new System.Windows.Forms.Label();
            this.txtClarionDate = new System.Windows.Forms.MaskedTextBox();
            this.grpDateTime.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDateTime
            // 
            this.grpDateTime.Controls.Add(this.lblTime);
            this.grpDateTime.Controls.Add(this.txtTime);
            this.grpDateTime.Controls.Add(this.lblClarionTime);
            this.grpDateTime.Controls.Add(this.txtClarionTime);
            this.grpDateTime.Controls.Add(this.lblDate);
            this.grpDateTime.Controls.Add(this.txtDate);
            this.grpDateTime.Controls.Add(this.lblClarionDate);
            this.grpDateTime.Controls.Add(this.txtClarionDate);
            this.grpDateTime.Font = new System.Drawing.Font("Arial", 10F);
            this.grpDateTime.ForeColor = System.Drawing.Color.White;
            this.grpDateTime.Location = new System.Drawing.Point(14, 13);
            this.grpDateTime.Name = "grpDateTime";
            this.grpDateTime.Size = new System.Drawing.Size(408, 91);
            this.grpDateTime.TabIndex = 0;
            this.grpDateTime.TabStop = false;
            this.grpDateTime.Text = "Date and Time ";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Arial", 9.5F);
            this.lblTime.Location = new System.Drawing.Point(21, 26);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(40, 16);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "Time:";
            // 
            // txtTime
            // 
            this.txtTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTime.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.txtTime.ForeColor = System.Drawing.Color.White;
            this.txtTime.Location = new System.Drawing.Point(111, 23);
            this.txtTime.Mask = "00:00";
            this.txtTime.Name = "txtTime";
            this.txtTime.PromptChar = ' ';
            this.txtTime.Size = new System.Drawing.Size(80, 23);
            this.txtTime.TabIndex = 1;
            this.txtTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTime.ValidatingType = typeof(System.DateTime);
            this.txtTime.TextChanged += new System.EventHandler(this.TextTimeFormat_TextChanged);
            this.txtTime.Leave += new System.EventHandler(this.TextTimeFormat_Leave);
            // 
            // lblClarionTime
            // 
            this.lblClarionTime.AutoSize = true;
            this.lblClarionTime.Font = new System.Drawing.Font("Arial", 9.5F);
            this.lblClarionTime.Location = new System.Drawing.Point(21, 58);
            this.lblClarionTime.Name = "lblClarionTime";
            this.lblClarionTime.Size = new System.Drawing.Size(84, 16);
            this.lblClarionTime.TabIndex = 2;
            this.lblClarionTime.Text = "Clarion Time:";
            // 
            // txtClarionTime
            // 
            this.txtClarionTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtClarionTime.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.txtClarionTime.ForeColor = System.Drawing.Color.White;
            this.txtClarionTime.Location = new System.Drawing.Point(111, 56);
            this.txtClarionTime.Mask = "0000000";
            this.txtClarionTime.Name = "txtClarionTime";
            this.txtClarionTime.PromptChar = ' ';
            this.txtClarionTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtClarionTime.Size = new System.Drawing.Size(80, 23);
            this.txtClarionTime.TabIndex = 3;
            this.txtClarionTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtClarionTime.ValidatingType = typeof(int);
            this.txtClarionTime.TextChanged += new System.EventHandler(this.TextClarionTimeFormat_TextChanged);
            this.txtClarionTime.Leave += new System.EventHandler(this.TextClarionTimeFormat_Leave);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Arial", 9.5F);
            this.lblDate.Location = new System.Drawing.Point(219, 26);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(39, 16);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "Date:";
            // 
            // txtDate
            // 
            this.txtDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDate.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.txtDate.ForeColor = System.Drawing.Color.White;
            this.txtDate.Location = new System.Drawing.Point(308, 23);
            this.txtDate.Mask = "00/00/0000";
            this.txtDate.Name = "txtDate";
            this.txtDate.PromptChar = ' ';
            this.txtDate.Size = new System.Drawing.Size(80, 23);
            this.txtDate.TabIndex = 5;
            this.txtDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDate.ValidatingType = typeof(System.DateTime);
            this.txtDate.TextChanged += new System.EventHandler(this.TextDateFormat_TextChanged);
            // 
            // lblClarionDate
            // 
            this.lblClarionDate.AutoSize = true;
            this.lblClarionDate.Font = new System.Drawing.Font("Arial", 9.5F);
            this.lblClarionDate.Location = new System.Drawing.Point(219, 59);
            this.lblClarionDate.Name = "lblClarionDate";
            this.lblClarionDate.Size = new System.Drawing.Size(83, 16);
            this.lblClarionDate.TabIndex = 6;
            this.lblClarionDate.Text = "Clarion Date:";
            // 
            // txtClarionDate
            // 
            this.txtClarionDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtClarionDate.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.txtClarionDate.ForeColor = System.Drawing.Color.White;
            this.txtClarionDate.Location = new System.Drawing.Point(308, 55);
            this.txtClarionDate.Mask = "0000000";
            this.txtClarionDate.Name = "txtClarionDate";
            this.txtClarionDate.PromptChar = ' ';
            this.txtClarionDate.Size = new System.Drawing.Size(80, 23);
            this.txtClarionDate.TabIndex = 7;
            this.txtClarionDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtClarionDate.ValidatingType = typeof(int);
            this.txtClarionDate.TextChanged += new System.EventHandler(this.TextClarionDateFormat_TextChanged);
            this.txtClarionDate.Leave += new System.EventHandler(this.TextClarionDateFormat_Leave);
            // 
            // ClarionDateTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(433, 118);
            this.Controls.Add(this.grpDateTime);
            this.Font = new System.Drawing.Font("Arial", 10F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ClarionDateTime";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clarion Date and Time";
            this.grpDateTime.ResumeLayout(false);
            this.grpDateTime.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDateTime;
        private System.Windows.Forms.MaskedTextBox txtTime;
        private System.Windows.Forms.Label lblClarionTime;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.MaskedTextBox txtClarionDate;
        private System.Windows.Forms.MaskedTextBox txtDate;
        private System.Windows.Forms.MaskedTextBox txtClarionTime;
        private System.Windows.Forms.Label lblClarionDate;
        private System.Windows.Forms.Label lblDate;
    }
}