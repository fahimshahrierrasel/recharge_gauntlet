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
using RechargeGauntlet.Util;

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
            //Regex to check Username
            var userNameRegex = new Regex("^[a-zA-Z][a-zA-Z0-5]{5,}$");
            //Regex to check Password
            var passwordRegex = new Regex("^(?!^[0-9]*$)(?!^[a-zA-Z]*$)^([a-zA-Z0-9]{8,20})$");

            //Checking first if the username and password is valid
            if (!userNameRegex.IsMatch(TextboxUserName.Text) ||
                !passwordRegex.IsMatch(TextboxPassword.Text))
            {
                //Username is found not valid
                if (!userNameRegex.IsMatch(TextboxUserName.Text))
                {
                    MessageBox.Show("Please enter a valid User Name! **At Least 6 characters(alphabets and digits only) are required and must present alphabet and digits**");
                }
                //Password is found not valid
                else if (!passwordRegex.IsMatch(TextboxPassword.Text))
                {
                    MessageBox.Show("Please enter a valid Password!**At Least 8 and At most 20 characters(alphabets and digits only) are required and must have at least an alphabet and a digit.**");
                }

                else
                {
                    //For future validations
                }
            }
            //Username and password are found valid, now checking if they are correct by matching them with database existing pairs.
            else
            {
                //Creating a local instance of Database context class
                using (RechargeGauntletDataContext _context = new RechargeGauntletDataContext())
                {
                    //Fetching the particular record of the given username
                    var user = (from u in _context.Users
                        where u.Username == TextboxUserName.Text
                        select u).FirstOrDefault();

                    //Checking if the given username exists in the database
                    if (user==null)
                    {
                        MessageBox.Show("Username doesn't exist!");
                    }

                    //Given Username exists in the database
                    else
                    {                        
                        //creating a hashed password's string instance.
                        string hashedPassword = user.PasswordHash;

                        //Checking whether the given password matches with the existing hashed password
                        if (PasswordHasher.Verify(TextboxPassword.Text, hashedPassword))
                        {
                            MessageBox.Show("Logging In!");
                        }
                        //Passwords doesn't match
                        else
                        {
                            MessageBox.Show("Incorrect Password!");
                        }
                    }
                }                
            }
        }
    }
}
