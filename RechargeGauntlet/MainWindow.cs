using System;
using System.Windows.Forms;
using RechargeGauntlet.CustomUI;

namespace RechargeGauntlet
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void rechargeToolStripMenuItem_Click(object sender, EventArgs e)
        {
//            RechargeForm rechargeForm = new RechargeForm();
//            rechargeForm.Show();
            ModemLoading modemLoding = new ModemLoading();
            modemLoding.ShowDialog();
        }

        private void phoneBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PhoneBook phoneBook = new PhoneBook();
            phoneBook.Show();
        }
    }
}
