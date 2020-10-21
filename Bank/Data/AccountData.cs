using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Schema;
using System.Xml.XPath;

namespace Bank.Data
{
    class AccountData
    {
        protected readonly int numberAccount, agencyAccount, digitAccount;
        protected float balance;
        XElement xml = XElement.Load("XMLData.xml");

        public AccountData()
        {
            this.numberAccount = 1111;
            this.agencyAccount = 1234;
            this.digitAccount = 3;
            this.balance = float.Parse((string)xml.Element("balance").Value);
        }

        public float getBalance()
        {
            return this.balance;
        }
        public void setBalance(float value)
        {
            this.balance = value;
            xml.Element("balance").Value = value.ToString();
        }

    }
}
