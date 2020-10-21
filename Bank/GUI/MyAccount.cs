using Bank.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Bank.Data;

namespace BankSystem
{
    public partial class MyAccount : Form
    {
        public float balance;
        public MyAccount()
        {
            InitializeComponent();               

            
            lbl_Balance.BackColor = Color.FromArgb(0, 88, 44, 55);
            
        }    


        private void saldo_btn(object sender, EventArgs e)
        {
            lbl_Balance.Text = (new AccountData()).getBalance().ToString();
            lbl_Balance.BackColor = Color.Empty;
            lbl_Balance.ForeColor = Color.DarkGray;
        }

        private void Transfer_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new Transfer()).ShowDialog();
        }

        private void Stratum_Click(object sender, EventArgs e)
        {

        }

        private void Payment_Click(object sender, EventArgs e)
        {

        }
    }
}
