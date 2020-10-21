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
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new MyAccount()).ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int barCode = txb_barCode.Text != "" ? Convert.ToInt16(txb_barCode.Text): 0 ;
            float payValue = txb_Value.Text != ""?float.Parse(txb_Value.Text): 0;
            DateTime dateTime = Convert.ToDateTime(txb_DuoDate.Text) ;
            string describe = !string.IsNullOrEmpty(txb_describe.Text)? txb_describe.Text  :null;
            float balance = new AccountData().getBalance();

            if (barCode == 0 || payValue == 0 || txb_DuoDate.Text == "" ||describe == null )
            {
                MessageBox.Show("Todos os campos sao obrigatórios");
            }
            else {

                
                if (balance < payValue)
                {
                    MessageBox.Show("Saldo insuficiente");

                }
                else
                {
                    this.Hide();
                    (new Back()).ShowDialog();
                }
            }
        }
       
    }
}
