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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            var userNameRegex = new Regex("^[a-zA-Z][a-zA-Z0-5]{5,}$");
            var passwordRegex = new Regex("^(?!^[0-9]*$)(?!^[a-zA-Z]*$)^([a-zA-Z0-9]{8,20})$");
            if (!userNameRegex.IsMatch(TextboxUserName.Text) ||
                !passwordRegex.IsMatch(TextboxPassword.Text))
            {
                if (!userNameRegex.IsMatch(TextboxUserName.Text))
                {
                    MessageBox.Show("Please enter a valid User Name! **At Least 6 characters(alphabets and digits only) are required and must present alphabet and digits**");
                }
                else if (!passwordRegex.IsMatch(TextboxPassword.Text))
                {
                    MessageBox.Show("Please enter a valid Password!**At Least 8 and At most 20 characters(alphabets and digits only) are required and must have at least an alphabet and a digit.**");
                }
                else
                {

                }
            }
            else
            {
                MessageBox.Show("Logging In!");
            }
        }
    }
}
