using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace BankSystem
{
    public partial class Main : Form
    {
      

        public Main()
        {
            
            //initial interface components
            InitializeComponent();                  
            
            
        }
        private void Main_Load(object sender, EventArgs e)
        {
            Pass_lbl.BackColor = Color.FromArgb(0, 88, 44, 55);
            Email_lbl.BackColor = Color.FromArgb(0, 88, 44, 55);
            EmLog_txb.Text = "teste@Gmail.Com";
            PassLog_txb.Text = "12345";
            PassLog_txb.PasswordChar = '*';
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            //if no filled 
            if (EmLog_txb.Text.Length < 1 || PassLog_txb.Text.Length < 1)
            {
                MessageBox.Show("Insira Email e Senha e tente novamente!", "Error");
            }
            else
            {
                //if corrects  arguments, enter in MyAcount screen
                if ((EmLog_txb.Text == "teste@Gmail.Com") && (PassLog_txb.Text == "12345"))
                {
                    this.Hide();
                    (new MyAccount()).ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Insira Email e Senha e tente novamente!", "Error");
                }

            }
        }
    }
}
