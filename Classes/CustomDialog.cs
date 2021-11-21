using System.Drawing;
using System.Windows.Forms;
using Utilities.Forms;

namespace Utilities
{
    class CustomDialog 
    {
        public static DialogResult ShowCustomDialog(string message, string title, string icon) {
            CustomDialogForm cmb = new CustomDialogForm(message, title, icon);
            DialogResult dialogResult = cmb.ShowDialog();
            return dialogResult;
        }
    }
}
