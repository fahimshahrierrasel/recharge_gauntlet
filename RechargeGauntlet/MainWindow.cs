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
            modemLoding.Show();
        }

        private void phoneBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PhoneBookForm phoneBook = new PhoneBookForm();
            phoneBook.Show();
        }
    }
}
