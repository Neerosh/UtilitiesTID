namespace Utilities.Forms
{
    partial class CustomDialogForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomDialogForm));
            this.picMessage = new System.Windows.Forms.PictureBox();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.picIcon = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.rtbMessage = new System.Windows.Forms.RichTextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.panelMessage = new System.Windows.Forms.Panel();
            this.panelConfirmation = new System.Windows.Forms.Panel();
            this.btnNo = new System.Windows.Forms.Button();
            this.btnYes = new System.Windows.Forms.Button();
            this.panelOk = new System.Windows.Forms.Panel();
            this.panelTitleBorder = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picMessage)).BeginInit();
            this.panelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.panelMessage.SuspendLayout();
            this.panelConfirmation.SuspendLayout();
            this.panelOk.SuspendLayout();
            this.panelTitleBorder.SuspendLayout();
            this.SuspendLayout();
            // 
            // picMessage
            // 
            this.picMessage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picMessage.Image = global::Utilities.Properties.Resources.icons8_info_64;
            this.picMessage.InitialImage = null;
            this.picMessage.Location = new System.Drawing.Point(24, 6);
            this.picMessage.Name = "picMessage";
            this.picMessage.Size = new System.Drawing.Size(50, 50);
            this.picMessage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMessage.TabIndex = 0;
            this.picMessage.TabStop = false;
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panelTitle.Controls.Add(this.picIcon);
            this.panelTitle.Controls.Add(this.lblTitle);
            this.panelTitle.Controls.Add(this.btnClose);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelTitle.Location = new System.Drawing.Point(0, -2);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(450, 30);
            this.panelTitle.TabIndex = 1;
            this.panelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseDown);
            // 
            // picIcon
            // 
            this.picIcon.Dock = System.Windows.Forms.DockStyle.Left;
            this.picIcon.ErrorImage = null;
            this.picIcon.Image = global::Utilities.Properties.Resources.icons8_maintenance_64;
            this.picIcon.InitialImage = null;
            this.picIcon.Location = new System.Drawing.Point(0, 0);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(30, 30);
            this.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picIcon.TabIndex = 2;
            this.picIcon.TabStop = false;
            this.picIcon.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseDown);
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(36, 7);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(370, 20);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Title";
            this.lblTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseDown);
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Image = global::Utilities.Properties.Resources.icons8_close_window_32;
            this.btnClose.Location = new System.Drawing.Point(420, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // rtbMessage
            // 
            this.rtbMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.rtbMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbMessage.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rtbMessage.ForeColor = System.Drawing.Color.White;
            this.rtbMessage.Location = new System.Drawing.Point(83, 21);
            this.rtbMessage.Name = "rtbMessage";
            this.rtbMessage.ReadOnly = true;
            this.rtbMessage.Size = new System.Drawing.Size(345, 83);
            this.rtbMessage.TabIndex = 2;
            this.rtbMessage.Text = "";
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnOk.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnOk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOk.ForeColor = System.Drawing.SystemColors.Control;
            this.btnOk.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnOk.Location = new System.Drawing.Point(180, 2);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(91, 30);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // panelMessage
            // 
            this.panelMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.panelMessage.Controls.Add(this.panelConfirmation);
            this.panelMessage.Controls.Add(this.panelOk);
            this.panelMessage.Controls.Add(this.rtbMessage);
            this.panelMessage.Controls.Add(this.picMessage);
            this.panelMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMessage.ForeColor = System.Drawing.Color.White;
            this.panelMessage.Location = new System.Drawing.Point(0, 30);
            this.panelMessage.Name = "panelMessage";
            this.panelMessage.Size = new System.Drawing.Size(450, 150);
            this.panelMessage.TabIndex = 4;
            // 
            // panelConfirmation
            // 
            this.panelConfirmation.Controls.Add(this.btnNo);
            this.panelConfirmation.Controls.Add(this.btnYes);
            this.panelConfirmation.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelConfirmation.Location = new System.Drawing.Point(0, 70);
            this.panelConfirmation.Name = "panelConfirmation";
            this.panelConfirmation.Size = new System.Drawing.Size(450, 40);
            this.panelConfirmation.TabIndex = 5;
            // 
            // btnNo
            // 
            this.btnNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnNo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnNo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNo.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNo.ForeColor = System.Drawing.SystemColors.Control;
            this.btnNo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnNo.Location = new System.Drawing.Point(258, 2);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(91, 30);
            this.btnNo.TabIndex = 5;
            this.btnNo.Text = "No";
            this.btnNo.UseVisualStyleBackColor = false;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // btnYes
            // 
            this.btnYes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnYes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnYes.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnYes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnYes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYes.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnYes.ForeColor = System.Drawing.SystemColors.Control;
            this.btnYes.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnYes.Location = new System.Drawing.Point(102, 2);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(91, 30);
            this.btnYes.TabIndex = 4;
            this.btnYes.Text = "Yes";
            this.btnYes.UseVisualStyleBackColor = false;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // panelOk
            // 
            this.panelOk.Controls.Add(this.btnOk);
            this.panelOk.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelOk.Location = new System.Drawing.Point(0, 110);
            this.panelOk.Name = "panelOk";
            this.panelOk.Size = new System.Drawing.Size(450, 40);
            this.panelOk.TabIndex = 4;
            // 
            // panelTitleBorder
            // 
            this.panelTitleBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panelTitleBorder.Controls.Add(this.panelTitle);
            this.panelTitleBorder.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBorder.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBorder.Name = "panelTitleBorder";
            this.panelTitleBorder.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.panelTitleBorder.Size = new System.Drawing.Size(450, 30);
            this.panelTitleBorder.TabIndex = 3;
            // 
            // CustomDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(450, 180);
            this.Controls.Add(this.panelMessage);
            this.Controls.Add(this.panelTitleBorder);
            this.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CustomDialogForm";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomMessageBox";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.picMessage)).EndInit();
            this.panelTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.panelMessage.ResumeLayout(false);
            this.panelConfirmation.ResumeLayout(false);
            this.panelOk.ResumeLayout(false);
            this.panelTitleBorder.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picMessage;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.RichTextBox rtbMessage;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox picIcon;
        private System.Windows.Forms.Panel panelMessage;
        private System.Windows.Forms.Panel panelConfirmation;
        private System.Windows.Forms.Button btnNo;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Panel panelOk;
        private System.Windows.Forms.Panel panelTitleBorder;
    }
}