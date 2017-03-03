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
        private List<AccountActivityObject> _accountactivity;
        private  double _balance;
        
        public AccountObject(string accountnumber)
        {
            _accountnumber = accountnumber;
            _accountactivity = new List<AccountActivityObject>();
            _balance = Balance;
        }

        public string Accountnumber // same as customers account number
        {
            get { return _accountnumber; }
            set { _accountnumber = value; }
        }

        public List<AccountActivityObject> AccountActivity
        {
            // get { return _accountactivity; }
            set { _accountactivity = value; }

            get
            {
                return (from AccountActivity in _accountactivity
                        orderby AccountActivity.Date
                    select AccountActivity).ToList();
            }
        }

        public  double Balance
        {
            get { return _balance; } // print out balance using this
            set { _balance = value; }
        }


        public double CreateNewAccountActivity(DateTime date, TimeSpan time, double transferSum)
        {
            Balance = Balance + transferSum;
            _accountactivity.Add(new AccountActivityObject(date, time, transferSum));
            return Balance;
        }
        
        public List<AccountActivityObject> PrintOutActivityOnTimeIntervall(DateTime startActivity, DateTime endActivity)
        {
            List<AccountActivityObject> res = (from transaction in _accountactivity
                                               where transaction.Date >= startActivity && transaction.Date <= endActivity
                                               orderby transaction.Date
                                     select transaction).ToList();
            return res;
        }

        /*
        public string PrintOutAllActivity()
        {
            for (int i =0; i <Accountactivity.Length; i++)
            {
                Accountactivity();
            }
        }
        */
    }
}
