using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RechargeGauntlet.CustomUI
{
    public partial class ModemLoading : Form
    {
        public ModemLoading()
        {
            InitializeComponent();
        }

        private void ModemLoading_Load(object sender, EventArgs e)
        {
            Application.EnableVisualStyles();
            MSProgressBar.MarqueeAnimationSpeed = 25;
        }
    }
}
