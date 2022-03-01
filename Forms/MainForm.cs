using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Utilities;
using Utilities.Classes;
using Utilities.Forms;

namespace Teste
{
    public partial class Main : Form
    {
        private SQLite sqlite;
        public readonly string[] arrayForbiddenCombinations = new string[] { ").", "_.", "_03.", "old.", "old--.", "copia.", "copy." };
        private Form activeForm = null;
        private Size formSize;

        public Main() {
            InitializeComponent();
            Padding = new Padding(2);
            BackColor = Color.FromArgb(60, 60, 60);
            BtnMenu_Click(this, new EventArgs());
            sqlite = new SQLite();
        }

        private void MainForm_Load(object sender, EventArgs e) {
            if (!File.Exists("UtilitiesTID.db")) {
                CustomMessage customMessage = sqlite.CreateDatabase();
                CustomDialog.ShowCustomDialog(customMessage, this);
            }
            panelSubMenuFiles.Visible = false;
            panelSubMenuCodes.Visible = false;
        }

        private void btnClose_Click(object sender, EventArgs e) {
            Close();
        }
        private void btnMaximize_Click(object sender, EventArgs e) {
            if (WindowState == FormWindowState.Normal) {
                formSize = ClientSize;
                WindowState = FormWindowState.Maximized;
            } else {
                WindowState = FormWindowState.Normal;
                Size = formSize;
            }
        }
        private void btnMinimize_Click(object sender, EventArgs e) {
            WindowState = FormWindowState.Minimized;
        }

        #region Movable AND Resizable Window
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Main_MouseDown(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        //Overridden methods
        protected override void WndProc(ref Message m) {
            const int WM_NCCALCSIZE = 0x0083;//Standar Title Bar - Snap Window
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MINIMIZE = 0xF020; //Minimize form (Before)
            const int SC_RESTORE = 0xF120; //Restore form (Before)
            const int WM_NCHITTEST = 0x0084;//Win32, Mouse Input Notification: Determine what part of the window corresponds to a point, allows to resize the form.
            const int resizeAreaSize = 10;
            #region Form Resize
            // Resize/WM_NCHITTEST values
            const int HTCLIENT = 1; //Represents the client area of the window
            const int HTLEFT = 10;  //Left border of a window, allows resize horizontally to the left
            const int HTRIGHT = 11; //Right border of a window, allows resize horizontally to the right
            const int HTTOP = 12;   //Upper-horizontal border of a window, allows resize vertically up
            const int HTTOPLEFT = 13;//Upper-left corner of a window border, allows resize diagonally to the left
            const int HTTOPRIGHT = 14;//Upper-right corner of a window border, allows resize diagonally to the right
            const int HTBOTTOM = 15; //Lower-horizontal border of a window, allows resize vertically down
            const int HTBOTTOMLEFT = 16;//Lower-left corner of a window border, allows resize diagonally to the left
            const int HTBOTTOMRIGHT = 17;//Lower-right corner of a window border, allows resize diagonally to the right
            ///<Doc> More Information: https://docs.microsoft.com/en-us/windows/win32/inputdev/wm-nchittest </Doc>
            if (m.Msg == WM_NCHITTEST) { //If the windows m is WM_NCHITTEST
                base.WndProc(ref m);
                if (this.WindowState == FormWindowState.Normal)//Resize the form if it is in normal state
                {
                    if ((int)m.Result == HTCLIENT)//If the result of the m (mouse pointer) is in the client area of the window
                    {
                        Point screenPoint = new Point(m.LParam.ToInt32()); //Gets screen point coordinates(X and Y coordinate of the pointer)                           
                        Point clientPoint = this.PointToClient(screenPoint); //Computes the location of the screen point into client coordinates                          
                        if (clientPoint.Y <= resizeAreaSize)//If the pointer is at the top of the form (within the resize area- X coordinate)
                        {
                            if (clientPoint.X <= resizeAreaSize) //If the pointer is at the coordinate X=0 or less than the resizing area(X=10) in 
                                m.Result = (IntPtr)HTTOPLEFT; //Resize diagonally to the left
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize))//If the pointer is at the coordinate X=11 or less than the width of the form(X=Form.Width-resizeArea)
                                m.Result = (IntPtr)HTTOP; //Resize vertically up
                            else //Resize diagonally to the right
                                m.Result = (IntPtr)HTTOPRIGHT;
                        } else if (clientPoint.Y <= (this.Size.Height - resizeAreaSize)) //If the pointer is inside the form at the Y coordinate(discounting the resize area size)
                          {
                            if (clientPoint.X <= resizeAreaSize)//Resize horizontally to the left
                                m.Result = (IntPtr)HTLEFT;
                            else if (clientPoint.X > (this.Width - resizeAreaSize))//Resize horizontally to the right
                                m.Result = (IntPtr)HTRIGHT;
                        } else {
                            if (clientPoint.X <= resizeAreaSize)//Resize diagonally to the left
                                m.Result = (IntPtr)HTBOTTOMLEFT;
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize)) //Resize vertically down
                                m.Result = (IntPtr)HTBOTTOM;
                            else //Resize diagonally to the right
                                m.Result = (IntPtr)HTBOTTOMRIGHT;
                        }
                    }
                }
                return;
            }
            #endregion
            //Remove border and keep snap window
            if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1) {
                return;
            }
            //Keep form size when it is minimized and restored. Since the form is resized because it takes into account the size of the title bar and borders.
            if (m.Msg == WM_SYSCOMMAND) {
                /// <see cref="https://docs.microsoft.com/en-us/windows/win32/menurc/wm-syscommand"/>
                /// Quote:
                /// In WM_SYSCOMMAND messages, the four low - order bits of the wParam parameter 
                /// are used internally by the system.To obtain the correct result when testing 
                /// the value of wParam, an application must combine the value 0xFFF0 with the 
                /// wParam value by using the bitwise AND operator.
                int wParam = (m.WParam.ToInt32() & 0xFFF0);
                if (wParam == SC_MINIMIZE)  //Before
                    formSize = this.ClientSize;
                if (wParam == SC_RESTORE)// Restored form(Before)
                    this.Size = formSize;
            }
            base.WndProc(ref m);
        }

        private void AdjustForm() {
            switch (this.WindowState) {
                case FormWindowState.Maximized: //Maximized form (After)
                    this.Padding = new Padding(8, 8, 8, 0);
                    break;
                case FormWindowState.Normal: //Restored form (After)
                    if (this.Padding.Top != 2)
                        this.Padding = new Padding(2);
                    break;
            }
        }
        #endregion

        #region SideMenu
        private void PaintSelectedMenuItem(Button selectedButton) {
            foreach (Control control in panelSideMenu.Controls) {
                if (control is Panel) {
                    foreach (Control control1 in control.Controls) {
                        if (control1 is Button) {
                            if (control1 == selectedButton) {
                                control1.BackColor = Color.FromArgb(204, 0, 0);
                                control.Visible = true;
                            } else {
                                control1.BackColor = Color.FromArgb(102, 0, 0);
                            }
                        }
                    }
                }
                if (control is Button) {
                    if (control == selectedButton) {
                        control.BackColor = Color.FromArgb(204, 0, 0);
                    } else {
                        control.BackColor = Color.FromArgb(153, 0, 0);
                    }
                }
            }
        }

        private void OpenChildForm(Form childForm) {
            if (activeForm != null) {
                activeForm.Close();
                activeForm.Dispose();
            }
            if (childForm == null) { return; }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(activeForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void ShowHideSubMenus(Panel submenu) {
            if (submenu.Visible == false) {
                submenu.Visible = true;
            } else {
                submenu.Visible = false;
            }
        }

        private void BtnCodes_Click(object sender, EventArgs e) {
            PaintSelectedMenuItem(btnCodes);
            ShowHideSubMenus(panelSubMenuCodes);
        }
        private void BtnCodesToClipboard_Click(object sender, EventArgs e) {
            OpenChildForm(new CodeToClipboard());
            PaintSelectedMenuItem(btnCodeToClipboard);
        }
        private void BtnCodesManage_Click(object sender, EventArgs e) {
            OpenChildForm(new CodeManage());
            PaintSelectedMenuItem(btnCodesManage);
        }

        private void BtnFiles_Click(object sender, EventArgs e) {
            PaintSelectedMenuItem(btnFiles);
            ShowHideSubMenus(panelSubMenuFiles);
        }
        private void BtnFileManagement_Click(object sender, EventArgs e) {
            OpenChildForm(new FileManagement());
            PaintSelectedMenuItem(btnFileManagement);
        }
        private void BtnFileFilters_Click(object sender, EventArgs e) {
            OpenChildForm(new FileFilters());
            PaintSelectedMenuItem(btnFileFilters);

        }
        private void BtnScriptWriter_Click(object sender, EventArgs e) {
            OpenChildForm(new ScriptWriter());
            PaintSelectedMenuItem(btnScriptWriter);
        }
        private void BtnConvertClarion_Click(object sender, EventArgs e) {
            OpenChildForm(new ClarionConversion());
            PaintSelectedMenuItem(btnConvertClarion);
        }
        private void BtnHelp_Click(object sender, EventArgs e) {
            OpenChildForm(new Utilities.Help(arrayForbiddenCombinations));
            PaintSelectedMenuItem(btnHelp);
        }
        private void btnProcessManagement_Click(object sender, EventArgs e) {
            OpenChildForm(new ProcessManagement());
            PaintSelectedMenuItem(btnProcessManagement);
        }
        private void BtnMenu_Click(object sender, EventArgs e) {
            OpenChildForm(null);
            PaintSelectedMenuItem(btnMenu);
        }
        private void BtnFileChecksum_Click(object sender, EventArgs e) {
            OpenChildForm(new FileChecksum());
            PaintSelectedMenuItem(btnFileChecksum);
        }
        #endregion

        private void Main_Resize(object sender, EventArgs e) {
            AdjustForm();
        }
    }
}
