using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RechargeGauntlet
{
    public partial class RechargeForm : Form
    {
        public RechargeForm()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            var numberReg = new Regex("^[0-9.]*$");
            if (String.IsNullOrWhiteSpace(txtAmount.Text) || String.IsNullOrWhiteSpace(txtNumber.Text) || String.IsNullOrWhiteSpace(txtQuantity.Text)|| (rdbPrepaid.Checked==false && rdbPostpaid.Checked==false ) || (!numberReg.IsMatch(txtNumber.Text)) || (!numberReg.IsMatch(txtQuantity.Text))||
                (!numberReg.IsMatch(txtAmount.Text)))
            {
                if(rdbPrepaid.Checked == false && rdbPostpaid.Checked == false)
                {
                    MessageBox.Show("Please Select Either Prepaid or postpaid");
                }

                if (String.IsNullOrWhiteSpace(txtAmount.Text))
                {
                    MessageBox.Show("Please Enter an amount!");
                }
                if (String.IsNullOrWhiteSpace(txtQuantity.Text ))
                {
                    MessageBox.Show("Please Enter an quantity!");
                }
                if (String.IsNullOrWhiteSpace(txtNumber.Text))
                {
                    MessageBox.Show("Please Enter an number!");
                }
                if (!numberReg.IsMatch(txtAmount.Text))
                {
                    MessageBox.Show("Please Enter an valid amount!");
                }
                if (!numberReg.IsMatch(txtQuantity.Text))
                {
                    MessageBox.Show("Please Enter an valid quantity!");
                }
                if (!numberReg.IsMatch(txtNumber.Text))
                {
                    MessageBox.Show("Please Enter an valid Mobile Number!");
                }
            }
            else
            {
                MessageBox.Show("Okay");
            }
        }

        private void txtNumberFocus(object sender, EventArgs e)
        {
            if (txtNumber.Text == "017XXXXXXXX")
            {
                txtNumber.Text = "";
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

        private void txtNumber_Leave(object sender, EventArgs e)
        {
            if (txtNumber.Text == "")
            {
                txtNumber.Text = "017XXXXXXXX";
            }
        }

        private void txtQuantity_Enter(object sender, EventArgs e)
        {
            if (txtNumber.Text == "1")
            {
                txtNumber.Text = "";
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

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
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
    }
}
