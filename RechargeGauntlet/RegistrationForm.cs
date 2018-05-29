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
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            var userNameRegex = new Regex("^[a-zA-Z][a-zA-Z0-5]{5,}$");
            var nameRegex = new Regex("^[a-zA-Z][a-zA-Z ]{4,}$");
            var passwordRegex  = new Regex("^(?!^[0-9]*$)(?!^[a-zA-Z]*$)^([a-zA-Z0-9]{8,20})$");
            if (!userNameRegex.IsMatch(TextboxUsername.Text) ||
                !nameRegex.IsMatch(TextboxUsername.Text) ||
                !passwordRegex.IsMatch(TextboxPassword.Text) ||
                !passwordRegex.IsMatch(TextboxPassConfirm.Text) ||
                TextboxPassword.Text != TextboxPassConfirm.Text )
            {
                if (!nameRegex.IsMatch(TextboxName.Text))
                {
                    MessageBox.Show("Please enter a valid Name! **At Least 5 characters and space between name are only allowed**");
                }
                else if (!userNameRegex.IsMatch(TextboxUsername.Text))
                {
                    MessageBox.Show("Please enter a valid User Name! **At Least 6 characters(alphabets and digits only) are required and must present alphabet and digits**");
                }
                else if (!passwordRegex.IsMatch(TextboxPassword.Text))
                {
                    MessageBox.Show("Please enter a valid Password!**At Least 8 and At most 20 characters(alphabets and digits only) are required and must have at least an alphabet and a digit.**");
                }
                else if (!passwordRegex.IsMatch(TextboxPassConfirm.Text))
                {
                    MessageBox.Show("Please enter a valid Confirm Password!**At Least 8 and At most 20 characters(alphabets and digits only) are required and must have at least an alphabet and a digit**");
                }
                else if (TextboxPassword.Text != TextboxPassConfirm.Text)
                {
                    MessageBox.Show("Password and Confirm Password Doesn't Match!");
                }
                else
                {
                    
                }
            }
            else
            {
                MessageBox.Show("Registering!");
            }
        }
    }
}
