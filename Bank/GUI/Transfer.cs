using BankSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bank.Data;
namespace Bank.GUI
{
    public partial class Transfer : Form
    {
        public Transfer()
        {
            InitializeComponent();
        }

        private void Tranfer_Load(object sender, EventArgs e)
        {

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            MyAccount myAccount = new MyAccount();
            myAccount.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string valueToTransfer = Value_txt.Text;
            string agencia = Agency_txb.Text;
            string count = Count_txb.Text;
            AccountData balance = new AccountData();
            

            if (!string.IsNullOrEmpty(valueToTransfer))
            {
               
                if (!string.IsNullOrEmpty(agencia))
                {
                    if (!string.IsNullOrEmpty(count))
                    {
                        if (balance.getBalance() > float.Parse(valueToTransfer))
                        {                            
                            balance.setBalance(balance.getBalance() - float.Parse(valueToTransfer));
                            this.Hide();
                            (new Back()).ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Saldo insuficiente");
                        }
                    }
                    else
                    {                        
                        MessageBox.Show("Prencha campos");
                    }                    

                }
                else
                {
                    MessageBox.Show("Prencha campos");
                }
            }
            else
            {
                MessageBox.Show("Prencha campos");
            }
        }
    }
}
