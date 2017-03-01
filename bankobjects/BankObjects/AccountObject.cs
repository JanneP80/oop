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

        public override string ToString()
        {
            return TesterOne();
            //return TesterOne();
        }

        private string TesterOne() // private is only called here
        {
            string dingdong = "Testeri: ";
           // return dingdong;
           /*
            Console.WriteLine("{0}", AccountActivity.OrderBy(date => date.Date.Month.Equals(11)));

            var list = _accountactivity.GetItems()
                    .Where(p => p.Status == 1)
                    .OrderBy(x => x.Date).First();

            var date = AccountActivity.Min(c => c.Date);
            AccountActivity.GetItems().Where(p => p.Status == 1 && c.Date == date).ToList();

            for (int i = 0; i < AccountActivity.Count; i++)
            {
                //Console.WriteLine(account1.AccountActivity.OrderByDescending(x => x.Date.Month));
                //{
                Console.WriteLine(AccountActivity[i]);

                //}
            }*/
            return dingdong;
        }
        /*
        var account01 = new AccountObject(Accountnumber);
        _account01 += 100;

        var AccountActivity03 = new AccountObject("Rolf", "Kullberg");

        AccountActivity03.Accountnumber = BankObject.CreateNewAccount();
        return _balance;
    }
    */
        // kirjaa tapahtuma 
        // lisää/ poista rahaa balanceen


        /*
        var _accountNumber = "FI";
        for (int i = 0; i < 16; i++)
        {
            _accountNumber += _rand.Next(0, 9);
        }
        // revoke account 
        return _accountNumber;
        */




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
