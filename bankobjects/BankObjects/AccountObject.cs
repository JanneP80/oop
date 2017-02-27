using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankObjects
{
    class AccountObject
    {
        private string _accountnumber;
        private string[] _accountactivity;
        private double balance;

        public string Accountnumber
        {
            get { return _accountnumber; }
            set { _accountnumber = value; }
        }

        public string[] Accountactivity
        {
            get { return _accountactivity; }
            set { _accountactivity = value; }
        }

        public double Balance
        {
            get { return balance; } // print out balance using this
            set { balance = value; }
        }
        /*
        public string PrintOutAllActivity()
        {
            for (int i =0; i <Accountactivity.Length; i++)
            {
                Accountactivity();
            }

        }

        public string PrintOutActivityOnTimeIntervall(DateTime startActivity, DateTime endActivity)
        {

            Accountactivity();

        }

        public double PrintBalance
        {
            
        }
        */
    }
}
