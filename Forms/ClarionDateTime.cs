using System;
using System.Globalization;
using System.Windows.Forms;

namespace Utilities {
    public partial class ClarionDateTime : Form {
        private string fieldText;
        public ClarionDateTime() {
            InitializeComponent();
        }

        private void ConvertClarionDate_toDate() {
            long dateValueClarion = Int32.Parse(txtClarionDate.Text);
            DateTime dateClarion= DateTime.ParseExact("01/01/1801", "dd/MM/yyyy", CultureInfo.InvariantCulture);

            if (dateValueClarion <= 4) {
                txtClarionDate.Text = "0000004";
                txtDate.Text = "01/01/1801";
            }

            if (dateValueClarion > 4) {
                dateClarion = dateClarion.AddDays(dateValueClarion - 4);
                txtDate.Text = dateClarion.ToString("dd/MM/yyyy");
            }

        }
        private void ConvertDate_ToClarionDate() {
            DateTime dateField;

            DateTime dateClarion = DateTime.ParseExact("01/01/1801", "dd/MM/yyyy", CultureInfo.InvariantCulture);
            string dateFormat = txtDate.Text;
            long dateValueClarion = 4;

            try {
                dateField = DateTime.ParseExact(dateFormat, "dd/MM/yyyy", CultureInfo.InvariantCulture);

                if (dateField.CompareTo(dateClarion) < 0) {
                    throw new Exception("Dates before 01/01/1801 not allowed.") ;
                }
            }
            catch (Exception e) {
                MessageBox.Show("Error:\n" + e.Message);
                txtDate.Text = "01/01/1801";
                return;
            }

            if (Int32.Parse(dateFormat.Substring(6, 4)) >= 1801) {
                dateValueClarion = (dateField - dateClarion).Days + 4;
            }

            txtClarionDate.Text = dateValueClarion.ToString();
            while (!txtClarionDate.MaskCompleted) {
                txtClarionDate.Text = "0" + txtClarionDate.Text;
            }

        }

        private void ConvertTime_ToClarionTime() {
            string timeFormat;
            long timeMinutes;
            long timeValueClarion = 0;
            timeFormat = txtTime.Text.Replace(":", "");

            if (!timeFormat.Equals("0000")) {
                timeMinutes = (Int32.Parse(timeFormat.Substring(0, 2))) * 60 + Int32.Parse(timeFormat.Substring(2, 2));
                timeValueClarion += (timeMinutes * 6000) + 1;
            }

            txtClarionTime.Text = timeValueClarion.ToString();
            while (!txtClarionTime.MaskCompleted) {
                txtClarionTime.Text = "0" + txtClarionTime.Text;
            }
        }
        private void ConvertClarionTime_ToTime() {
            string timeFormat = "00:00";
            long timeHours, timeMinutes;
            long timeValueClarion = Int32.Parse(txtClarionTime.Text);

            if (timeValueClarion <= 1) {
                txtTime.Text = timeFormat;
                return;
            }

            timeHours = 0;
            if (timeValueClarion > 360000) {
                timeHours = timeValueClarion / 360000;
            }

            timeFormat = timeHours.ToString();

            if (timeHours <= 9) {
                timeFormat = "0" + timeHours.ToString();
            }

            timeMinutes = (timeValueClarion - (timeHours * 360000)) / 6000;

            if (timeMinutes <= 9) {
                timeFormat += ":0" + timeMinutes.ToString();
            }
            else {
                timeFormat += ":" + timeMinutes.ToString();
            }

            txtTime.Text = timeFormat;
        }


        private void TextTimeFormat_Leave(object sender, EventArgs e) {
            //fieldText = txtTime.Text;
            //while (!txtTime.MaskCompleted) {
            //    if (txtTime.Text.Length == 4) {
            //        fieldText = fieldText.Substring(0, 2) + ":" + fieldText.Substring(2, 2);
            //    }
            //    fieldText = "0" + fieldText;
            //    txtTime.Text = fieldText;
            //}
        }

        private void TextTimeFormat_TextChanged(object sender, EventArgs e) {
            if (txtTime.MaskCompleted) {
                //ConvertTime("Clarion");
                ConvertTime_ToClarionTime();
            }
        }
        private void TextClarionTimeFormat_TextChanged(object sender, EventArgs e) {
            if (txtClarionTime.MaskCompleted) {
                //ConvertTime("Time");
                ConvertClarionTime_ToTime();
            }
        }
        private void TextDateFormat_TextChanged(object sender, EventArgs e) {
            if (txtDate.MaskCompleted) {
                ConvertDate_ToClarionDate();
            }
        }
        private void TextClarionDateFormat_TextChanged(object sender, EventArgs e) {
            if (txtClarionDate.MaskCompleted) {
                ConvertClarionDate_toDate();
            }
        }

        private void TextClarionDateFormat_Leave(object sender, EventArgs e) {
            fieldText = txtClarionDate.Text;
            while (!txtClarionDate.MaskCompleted) {
                fieldText = "0" + fieldText;
                txtClarionDate.Text = fieldText;
            }
        }
        private void TextClarionTimeFormat_Leave(object sender, EventArgs e) {
            fieldText = txtClarionTime.Text;
            while (!txtClarionTime.MaskCompleted) {
                fieldText = "0" + fieldText;
                txtClarionTime.Text = fieldText;
            }
        }

    }
}
