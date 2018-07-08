using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using RechargeGauntlet.CustomControls;
using RechargeGauntlet.Modem;

namespace RechargeGauntlet
{
    public partial class RechargeForm : Form
    {
        private List<OperatorModemInfo> _operatorModemInfos;

        public RechargeForm(List<OperatorModemInfo> operatorModemInfos)
        {
            InitializeComponent();
            _operatorModemInfos = operatorModemInfos;
            
        }

        private void RechargeForm_Shown(object sender, EventArgs e)
        {
            InitializeModems();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            var numberReg = new Regex("^01[5-9][0-9]{8}"); // Regex for mobile number start with 01 and one digit from 5-9 other 8 digits
            var amountReg = new Regex("(^[1-9][0-9]+.?[0-9]{0,2})"); // support both decimal and non decimal number upto 2 decimal point
            var quantityReg = new Regex("^[1-9][0-9]*");

            string rechargeAmount = txtAmount.Text;
            string rechargeQuantity = txtQuantity.Text;
            string mobileNumber = txtNumber.Text;

            if (!amountReg.IsMatch(rechargeAmount))
            {
                MessageBox.Show("Please Enter an valid amount!");
                return;
            }
            if (!quantityReg.IsMatch(rechargeQuantity))
            {
                MessageBox.Show("Please Enter an valid quantity!");
                return;
            }
            if (!numberReg.IsMatch(mobileNumber))
            {
                MessageBox.Show("Please Enter an valid Mobile Number!");
                return;
            }

            
        }

        private void InitializeModems()
        {
            int width = 0;
            foreach (var operatorModemPort in _operatorModemInfos)
            {
                Console.WriteLine($@"{operatorModemPort.ComPort} -- {operatorModemPort.OperatorName} -- {operatorModemPort.MobileNumber}");
                var operatorControl = new OperatorControl(operatorModemPort.ComPort, operatorModemPort.OperatorName, operatorModemPort.MobileNumber)
                {
                    Visible = true,
                    Top = 0,
                    Left = 0+width,
                };
                width = operatorControl.Width + 5;
                PanelModemConnection.Controls.Add(operatorControl);
            }
        }

        private void txtNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar > '1' && txtNumber.SelectionStart < 2)
            {
                e.Handled = true;
            }

            if (e.KeyChar > '0' && e.KeyChar < '2' && txtNumber.SelectionStart < 1)
            {
                e.Handled = true;
            }

            if (txtNumber.SelectionStart > 10 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Set operator logo based on the mobile number
        /// </summary>
        /// <param name="operatorCode">Mobile Number for setting the operator logo</param>
        private void SetOperatorLogo(string operatorCode)
        {
            switch (operatorCode)
            {
                case "015":
                    PBOperatorLogo.Image = Properties.Resources.teletalk;
                    break;
                case "016":
                    PBOperatorLogo.Image = Properties.Resources.airtel;
                    break;
                case "017":
                    PBOperatorLogo.Image = Properties.Resources.gp;
                    break;
                case "018":
                    PBOperatorLogo.Image = Properties.Resources.robi;
                    break;
                case "019":
                    PBOperatorLogo.Image = Properties.Resources.banglalink;
                    break;
                default:
                    PBOperatorLogo.Image = null;
                    break;
            }
        }

        private void txtNumber_Enter(object sender, EventArgs e)
        {
            if (txtNumber.Text == "01XXXXXXXXX")
            {
                txtNumber.Text = "";
            }
        }

        private void txtNumber_Leave(object sender, EventArgs e)
        {
            if (txtNumber.Text == "")
            {
                txtNumber.Text = "01XXXXXXXXX";
            }
        }

        private void txtQuantity_Leave(object sender, EventArgs e)
        {
            if (txtQuantity.Text == "")
            {
                txtQuantity.Text = "1";
            }
        }

        private void txtAmount_Enter(object sender, EventArgs e)
        {
            if (txtAmount.Text == "100.00")
            {
                txtAmount.Text = "";
            }
        }

        private void txtAmount_Leave(object sender, EventArgs e)
        {
            if (txtAmount.Text == "")
            {
                txtAmount.Text = "100.00";
            }
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && txtAmount.SelectionStart < 2)
            {
                e.Handled = true;
            }
            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        // Check Number when they are get matched with the operator number
        private void txtNumber_TextChanged(object sender, EventArgs e)
        {
            TextBox phoneNumber = (TextBox)sender;
            if (phoneNumber.Text.Length == 3)
            {
                string operatorCode = phoneNumber.Text.Substring(0, 3);
                SetOperatorLogo(operatorCode);
            }
            else if (phoneNumber.Text.Length < 3)
            {
                SetOperatorLogo("None");
            }
        }

        // Input only Integers (no numbers and decimal number)
        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && txtAmount.SelectionStart < 2)
            {
                e.Handled = true;
            }
        }

        
    }
}
