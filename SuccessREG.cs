using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BANK
{
    public partial class SuccessREG : Form
    {
        public SuccessREG()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main menu = new Main();
            menu.Owner = this;
            menu.Show();
            Hide();
        }
    }
}
