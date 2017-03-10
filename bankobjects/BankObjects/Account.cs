using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankObjects
{
    class Account
    {
        private string _accountnumber;
        private List<AccountActivity> _accountactivity;
        private double _balance;

        public Account(string accountnumber)
        {
            _accountnumber = accountnumber;
            _accountactivity = new List<AccountActivity>();
            _balance = Balance;
        }

        public string Accountnumber // same as customers account number
        {
            get { return _accountnumber; }
            set { _accountnumber = value; }
        }

        public List<AccountActivity> AccountActivity
        {
             get { return _accountactivity; }
            /*set { _accountactivity = value; }

            get
            {
                return (from AccountActivity in _accountactivity
                        orderby AccountActivity.Date
                        select AccountActivity).ToList();
            }*/
        }

        public double Balance
        {
            get { return _balance; } // print out balance using this
            set { _balance = value; }
        }

        public void AddEvent(double amount, DateTime date)
        {
            _accountactivity.Add(new AccountActivity(date, amount));
            _balance += amount;
        }

        public double CreateNewAccountActivity(DateTime date, double transferSum)
        {
            Balance = Balance + transferSum;
            _accountactivity.Add(new AccountActivity(date, transferSum));
            return Balance;
        }
       
        /*
        public List<BankAccountEvent> GetEventsByDateBetween(DateTime fromDate, DateTime toDate)
        {
            return _accountEvents.FindAll(e => e.TimeStamp >= fromDate && e.TimeStamp <= toDate)
                .OrderBy(e => e.TimeStamp)
                .ToList();
        }*/
        public List<AccountActivity> FindActivitiesOnTimeIntervall(DateTime startActivity, DateTime endActivity)
        {
            /*
            List<AccountActivity> res = (from transaction in _accountactivity
                                               where transaction.Date >= startActivity && transaction.Date <= endActivity
                                               orderby transaction.Date
                                               select transaction).ToList();
            return res;
            */
            return _accountactivity.FindAll(e => e.TimeStamp >= startActivity && e.TimeStamp <= endActivity)
                .OrderBy(e => e.TimeStamp)
                .ToList();
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
