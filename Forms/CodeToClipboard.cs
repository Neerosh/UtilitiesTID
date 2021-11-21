using System;
using System.Data;
using System.Windows.Forms;
using Utilities.Classes;
using Utilities.Forms;

namespace Utilities
{
    public partial class CodeToClipboard : Form
    {
        private readonly SQLite sqlite = new SQLite();

        public CodeToClipboard() {
            InitializeComponent();
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
                txtCodePreview.Text = cboCodeName.Text + "\r\nCopied to clipboard successfully.";
            }
        }
        private void CboCodeName_SelectedValueChanged(object sender, EventArgs e) {
            if (cboCodeName.SelectedItem != null) {
                txtCodePreview.Text = "Preview: \r\n" + cboCodeName.SelectedValue.ToString();
            }
        }
        private void cboCodeType_SelectedValueChanged(object sender, EventArgs e) {
            if (cboCodeType.SelectedItem != null) {
                RefreshCodeNames();
            }
        }

        private void cboCodeName_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void grpClipboardCode_Enter(object sender, EventArgs e) {

        }
    }
}
