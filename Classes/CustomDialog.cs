using System.Drawing;
using System.Windows.Forms;
using Utilities.Classes;
using Utilities.Forms;

namespace Utilities
{
    class CustomDialog 
    {

        public static DialogResult ShowCustomDialog(CustomMessage customMessage, Form owner) {
            if (customMessage.Message.Equals("") || customMessage == null) { return DialogResult.None; }

            CustomDialogForm cmb = new CustomDialogForm(customMessage, owner);
            DialogResult dialogResult = cmb.ShowDialog();
            return dialogResult;
        }
    }
}
