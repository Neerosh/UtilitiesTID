using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilities.Classes;
using Utilities.Properties;

namespace Utilities.Forms
{
    public partial class CustomDialogForm : Form
    {
        public CustomDialogForm(CustomMessage customMessage,Form owner) {
            InitializeComponent();
            Padding = new Padding(2);
            BackColor = Color.FromArgb(50, 50, 50);
            lblTitle.Text = customMessage.Title;
            rtbMessage.Text = customMessage.Message;
            switch (customMessage.Type) {
                case "error":
                    picMessage.Image = Resources.icons8_error_64;
                    panelConfirmation.Height = 40;
                    break;
                case "success":
                    picMessage.Image = Resources.icons8_info_64;
                    panelConfirmation.Height = 40;
                    break;
                case "confirmation":
                    picMessage.Image = Resources.icons8_question_64;
                    panelOk.Height = 40;
                    break;
                default:
                    picMessage.Image = Resources.icons8_info_64;
                    panelConfirmation.Height = 40;
                    break;
            }
            if (owner != null) { Owner = owner; StartPosition = FormStartPosition.CenterParent; }
        }
        #region Movable Window
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void panelTitle_MouseDown(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #endregion

        private void btnClose_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnOk_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnYes_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Continue;
            Close();
        }

        private void btnNo_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
