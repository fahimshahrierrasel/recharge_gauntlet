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
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {

            //Regex for checking username 
            var userNameRegex = new Regex("^[a-zA-Z][a-zA-Z0-5]{5,}$");
            //Regex for checking name
            var nameRegex = new Regex("^[a-zA-Z][a-zA-Z ]{4,}$");
            //Regex for checking password
            var passwordRegex  = new Regex("^(?!^[0-9]*$)(?!^[a-zA-Z]*$)^([a-zA-Z0-9]{8,20})$");

            //Checking whether the given input data is valid or not by using corresponding regex
            if (!nameRegex.IsMatch(TextboxName.Text) ||
                !userNameRegex.IsMatch(TextboxUsername.Text) ||
                !passwordRegex.IsMatch(TextboxPassword.Text) ||
                !passwordRegex.IsMatch(TextboxPassConfirm.Text) ||
                TextboxPassword.Text != TextboxPassConfirm.Text )
            {
                //Checking whether given name is valid
                if (!nameRegex.IsMatch(TextboxName.Text))
                {
                    MessageBox.Show("Please enter a valid Name! **At Least 5 characters and space between name are only allowed**");
                }
                //Checking whether given username is valid
                else if (!userNameRegex.IsMatch(TextboxUsername.Text))
                {
                    MessageBox.Show("Please enter a valid User Name! **At Least 6 characters(alphabets and digits only) are required and must present alphabet and digits**");
                }
                //Checking whether given name is valid
                else if (!passwordRegex.IsMatch(TextboxPassword.Text))
                {
                    MessageBox.Show("Please enter a valid Password!**At Least 8 and At most 20 characters(alphabets and digits only) are required and must have at least an alphabet and a digit.**");
                }
                //Checking whether given password is valid
                else if (!passwordRegex.IsMatch(TextboxPassConfirm.Text))
                {
                    MessageBox.Show("Please enter a valid Confirm Password!**At Least 8 and At most 20 characters(alphabets and digits only) are required and must have at least an alphabet and a digit**");
                }
                //Checking whether given confirm password is valid
                else if (TextboxPassword.Text != TextboxPassConfirm.Text)
                {
                    MessageBox.Show("Password and Confirm Password Doesn't Match!");
                }
                else
                {
                    //for future logic
                }
            }
            //Given data is valid to be inserted into database
            else
            {
                //Creating string instance of the given username
                string uname = TextboxUsername.Text;

                //creating local instance of database context to communicate withe database
                using (RechargeGauntletDataContext _context = new RechargeGauntletDataContext())
                {
                    //Checking if the given username already exists in the database
                    if (_context.Users.Count(u => u.Username == uname) != 0)
                    {
                        MessageBox.Show("Username already Exists!");
                    }

                    //Username doesn't exists in the database
                    else
                    {
                        //Creating string instance of the given password
                        string password = TextboxPassword.Text;
                        //Creating string instance of the hashed version of given password
                        string hashedPassword = PasswordHasher.Hash(password);

                        //creating a new User Instance to be inserted to the User Table
                        User user = new User
                        {
                            //Initializing properties of User
                            Username = uname, 
                            Name = TextboxName.Text,
                            PasswordHash = hashedPassword                      
                        };
                        //Adding new Instance to the instance of database.
                        _context.Users.InsertOnSubmit(user);

                        //Saving changes
                        _context.SubmitChanges();
                        MessageBox.Show("Registered!");
                    }
                }
                
            }
        }
    }
}
