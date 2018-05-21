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
    public partial class PhoneBook : Form
    {
        public PhoneBook()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var numberRegex = new Regex("^[0-9]*$");
            var nameRegex = new Regex("^[a-zA-Z. ]*$");
            if (!numberRegex.IsMatch(txtNumber.Text) || String.IsNullOrWhiteSpace(txtNumber.Text) || !nameRegex.IsMatch(txtName.Text) ||
                String.IsNullOrWhiteSpace(txtName.Text) ||
                txtNumber.Text.Length != 11)
            {
                
                if (!nameRegex.IsMatch(txtName.Text) ||  String.IsNullOrWhiteSpace(txtName.Text))
                {
                    MessageBox.Show("Please enter a valid name");
                }
                else if (!numberRegex.IsMatch(txtNumber.Text) || String.IsNullOrWhiteSpace(txtNumber.Text))
                {
                    MessageBox.Show("Please enter a valid number");
                }
                else if (txtNumber.Text.Length != 11)
                {
                    MessageBox.Show("Mobile Number must be 11 digit");
                }
            }
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && char.IsDigit(e.KeyChar) &&
                (e.KeyChar != ' ') && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == ' ') && txtName.SelectionStart < 2)
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && txtName.SelectionStart < 2)
            {
                e.Handled = true;
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

            if (txtNumber.SelectionStart > 10)
            {
                e.Handled = true;
            }
            
        }
    }
}
