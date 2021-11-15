﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Utilities.Forms
{
    public partial class ClarionConversion : Form
    {
        public ClarionConversion() {
            InitializeComponent();
        }

        #region Clarion Date / Time Conversion
        private void ConvertDate(string toFormat) {
            DateTime dateField, dateClarion = DateTime.ParseExact("01/01/1801", "dd/MM/yyyy", CultureInfo.InvariantCulture);
            string dateFormat;
            long dateValueClarion;

            if (toFormat.Equals("ClarionDate")) {
                dateFormat = txtDate.Text;
                try {
                    dateField = DateTime.ParseExact(dateFormat, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                } catch (Exception) {
                    dateField = DateTime.ParseExact("01/01/1801", "dd/MM/yyyy", CultureInfo.InvariantCulture);
                }

                if (Int32.Parse(dateFormat.Substring(6, 4)) <= 1801) {
                    txtClarionDate.Text = "0000004";
                    txtDate.Text = "01/01/1801";
                } else {
                    dateValueClarion = (dateField - dateClarion).Days + 4;
                    txtClarionDate.Text = dateValueClarion.ToString();
                    while (!txtClarionDate.MaskCompleted) {
                        txtClarionDate.Text = "0" + txtClarionDate.Text;
                    }
                }
            } else {
                dateValueClarion = Int32.Parse(txtClarionDate.Text);

                if (dateValueClarion <= 4) {
                    txtClarionDate.Text = "0000004";
                    txtDate.Text = "01/01/1801";
                } else {
                    dateClarion = dateClarion.AddDays(dateValueClarion - 4);
                    txtDate.Text = dateClarion.ToString("dd/MM/yyyy");
                }
            }
        }
        private void ConvertTime(string toFormat) {
            string timeFormat;
            long timeMinutes, timeHours;
            long timeValueClarion = 0;

            if (toFormat.Equals("ClarionTime")) {
                if (txtTime.Text.Length == 0) { return; }
                timeFormat = txtTime.Text.Replace(":", "");
                if (!timeFormat.Equals("0000")) {
                    timeMinutes = (Int32.Parse(timeFormat.Substring(0, 2))) * 60 + Int32.Parse(timeFormat.Substring(2, 2));
                    timeValueClarion += (timeMinutes * 6000) + 1;
                } else {
                    timeValueClarion = 4;
                }

                txtClarionTime.Text = timeValueClarion.ToString();
                while (!txtClarionTime.MaskCompleted) {
                    txtClarionTime.Text = "0" + txtClarionTime.Text;
                }
            } else {
                if (txtClarionTime.Text.Length == 0) { return; }
                timeFormat = "00:00";
                timeValueClarion = Int32.Parse(txtClarionTime.Text);

                if (timeValueClarion <= 4) {
                    txtTime.Text = timeFormat;
                    timeValueClarion = 4;
                    txtClarionTime.Text = timeValueClarion.ToString();
                    while (!txtClarionTime.MaskCompleted) {
                        txtClarionTime.Text = "0" + txtClarionTime.Text;
                    }
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
                } else {
                    timeFormat += ":" + timeMinutes.ToString();
                }

                txtTime.Text = timeFormat;
            }
        }

        private void TxtTime_Validated(object sender, EventArgs e) {
            string fieldText = txtTime.Text;
            while (!txtTime.MaskCompleted) {
                fieldText = "0" + fieldText;
                txtTime.Text = fieldText;
            }
            ConvertTime("ClarionTime");
        }
        private void TxtClarionTime_Validated(object sender, EventArgs e) {
            string fieldText = txtClarionTime.Text;
            while (!txtClarionTime.MaskCompleted) {
                fieldText = "0" + fieldText;
                txtClarionTime.Text = fieldText;
            }
            ConvertTime("Time");
        }
        private void TxtDate_Validated(object sender, EventArgs e) {
            if (!txtDate.MaskCompleted) {
                txtDate.Text = "01/01/1801";
            }
            ConvertDate("ClarionDate");
        }
        private void TxtClarionDate_Validated(object sender, EventArgs e) {
            string fieldText = txtClarionDate.Text;
            while (!txtClarionDate.MaskCompleted) {
                fieldText = "0" + fieldText;
                txtClarionDate.Text = fieldText;
            }
            ConvertDate("Date");

        }
        #endregion

    }
}
