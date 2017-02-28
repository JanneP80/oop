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
        private string _accountactivity;
        private double _balance;

        public AccountObject(string accountnumber)
        {
            _accountnumber = accountnumber;
            _balance = Balance;

        }

        public string Accountnumber // same as customers account number
        {

            get { return _accountnumber; }
            set { _accountnumber = value; }
        }

        public string Accountactivity
        {
            get { return _accountactivity; }
            set { _accountactivity = value; }
        }

        public double Balance
        {
            get { return _balance; } // print out balance using this
            set { _balance = value; }
        }


        public double CreateNewAccountActivity(double transferSum)
        {
            Balance = Balance + transferSum;
            return Balance;

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
