using System;
using System.Data;
using System.Windows.Forms;
using Utilities.Classes;

namespace Utilities
{
    public partial class CodeToClipboard : Form
    {
        private SQLite sqlite;
        private Timer timerLabelClipboard;
        public CodeToClipboard() {
            InitializeComponent();
            sqlite = new SQLite();
            timerLabelClipboard = new Timer();
            timerLabelClipboard.Interval = 10000;
            timerLabelClipboard.Tick += (source, e) => { lblCopyToClipboard.Visible = false; timerLabelClipboard.Stop(); };
        }
        private void CodeToClipboard_Load(object sender, EventArgs e) {
            RefreshCodeTypes();
            RefreshCodeNames();
        }

        private void RefreshCodeNames() {
            DataTable dt;
            if (cboCodeType.SelectedItem != null) {
                dt = sqlite.SelectAllCodes(cboCodeType.SelectedValue.ToString());
            } else {
                dt = sqlite.SelectAllCodes("");
            }
            cboCodeName.DataSource = dt;
            cboCodeName.DisplayMember = "Name";
            cboCodeName.ValueMember = "Code";
            cboCodeName.Refresh();
        }
        private void RefreshCodeTypes() {
            DataTable dt = sqlite.SelectAllCodeTypes();
            cboCodeType.DataSource = dt;
            cboCodeType.DisplayMember = "Type";
            cboCodeType.ValueMember = "Type";
            cboCodeType.Refresh();
        }

        private void BtnCopyClipboard_Click(object sender, EventArgs e) {
            if (cboCodeName.SelectedItem != null) {
                Clipboard.SetText(cboCodeName.SelectedValue.ToString());
                lblCopyToClipboard.Visible = true;
                timerLabelClipboard.Start();
            }
        }
        private void CboCodeName_SelectedValueChanged(object sender, EventArgs e) {
            if (cboCodeName.SelectedItem != null) {
                txtCodePreview.Text = "Preview: \r\n" + cboCodeName.SelectedValue.ToString();
                timerLabelClipboard.Stop();
                lblCopyToClipboard.Visible = false;
            }
        }
        private void cboCodeType_SelectedValueChanged(object sender, EventArgs e) {
            if (cboCodeType.SelectedItem != null) {
                RefreshCodeNames();
                timerLabelClipboard.Stop();
                lblCopyToClipboard.Visible = false;
            }
        }
    }
}
