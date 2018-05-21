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
            if (txtAmount.Text == "" || txtNumber.Text == "" || txtQuantity.Text == "" || (rdbPrepaid.Checked==false && rdbPostpaid.Checked==false ) || (!numberReg.IsMatch(txtNumber.Text)) || (!numberReg.IsMatch(txtQuantity.Text))||
                (!numberReg.IsMatch(txtAmount.Text)))
            {
                if(rdbPrepaid.Checked == false && rdbPostpaid.Checked == false)
                {
                    MessageBox.Show("Please Select Either Prepaid or postpaid");
                }

                if (txtAmount.Text == "")
                {
                    MessageBox.Show("Please Enter an amount!");
                }
                if (txtQuantity.Text == "")
                {
                    MessageBox.Show("Please Enter an quantity!");
                }
                if (txtNumber.Text == "")
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
            txtNumber.Text = "";
        }

        private void RechargeForm_Load(object sender, EventArgs e)
        {
            this.ActiveControl = lblSummery;
        }
    }
}
