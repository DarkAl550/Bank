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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void AddCardBtn_Click(object sender, EventArgs e)
        {
            REG reg = new REG();
            reg.Owner = this;
            reg.Show();
            Hide();
        }
    }
}
