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
    public partial class REG : Form
    {
        public REG()
        {
            InitializeComponent();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            Main menu = new Main();
            menu.Owner = this;
            menu.Show();
          
            Hide();
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            decimal nomer;
            var Result = decimal.TryParse(textBox1.Text, out nomer);

            if (Result == true)
            {
                label2.Visible = true;
                textBox2.Visible = true;
                Next1Btn.Visible = true;
                NextBtn.Visible = false;

            }
        }

        private void REG_Load(object sender, EventArgs e)
        {
            label2.Visible = false;
            textBox2.Visible = false;
            Next1Btn.Visible = false;
        }

        private void Next1Btn_Click(object sender, EventArgs e)
        {

            decimal pass;
            var Result = decimal.TryParse(textBox2.Text, out pass);

            

            if (Result == true)
            {
                string num = textBox1.Text, pas = textBox2.Text;
                
                Random rand = new Random();
                int money = rand.Next(5, 1000);

                Form1 main = Owner as Form1;

                if(main != null)
                {
                    DataRow nRow = main.bANKDataSet.Tables[0].NewRow();
                    int rc = main.DB.RowCount + 1;
                    nRow[0] = rc;
                    nRow[1] = num;
                    nRow[2] = pass;
                    nRow[3] = rand.Next(1, 100);
                    main.bANKDataSet.Tables[0].Rows.Add(nRow);
                    main.bankDBTableAdapter.Update(main.bANKDataSet.BankDB);
                    main.bANKDataSet.Tables[0].AcceptChanges();
                    main.DB.Refresh();

                    SuccessREG suc = new SuccessREG();
                    suc.Owner = this;
                    suc.Show();
                    Hide();

                }
                else
                {
                    Hide();
                }
            }
            

        }
    }
}
