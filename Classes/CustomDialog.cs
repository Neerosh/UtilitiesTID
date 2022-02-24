using System;
using System.Windows.Forms;
using Utilities.Classes;
using Utilities.Forms;

namespace Utilities
{
    class CustomDialog
    {

        public static DialogResult ShowCustomDialog(CustomMessage customMessage, Form form) {
            if (customMessage.Message.Equals("") || customMessage == null) { return DialogResult.None; }
            CustomDialogForm cmb = new CustomDialogForm(customMessage);
            DialogResult dialogResult = cmb.ShowDialog(form);
            return dialogResult;
        }
    }
}
