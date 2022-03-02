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
            CustomDialogForm customDialog = new CustomDialogForm(customMessage);
            if (form == null) {
                customDialog.StartPosition = FormStartPosition.CenterScreen;
            }
            DialogResult dialogResult = customDialog.ShowDialog(form);
            return dialogResult;
        }
    }
}
