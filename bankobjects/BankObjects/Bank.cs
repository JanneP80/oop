using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankObjects
{
    class Bank
    {
        private string _bankName;
        private List<Account> _accounts; // list is better
        private Random _rand = new Random(DateTime.Now.Millisecond);

        public string BankName
        {
            get { return _bankName; }
            set { _bankName = value; }
        }

        public Bank(string bankName)
        {
            _bankName = bankName;
            _accounts = new List<Account>();
        }

        public List<Account> Accounts // accounts
        {
            get { return _accounts; }
            set { _accounts = value; }
        }

        public string CreateNewAccount()
        {
            // create new "IBAN"
            var accountNumber = "FI";
            for (int i = 0; i < 16; i++)
            {
                accountNumber += _rand.Next(0, 9);
            }

            var account = new Account(accountNumber);
            _accounts.Add(account);
            // return bankAccount.AccountNumber
            // _accounts.Add(new Account(_accountNumber));
            return account.Accountnumber;
        }

        public void AddNewAccountEvent(string bankAccountNumber, double amount, DateTime date)
        {
            var account = FindAccountByAccountNumber(bankAccountNumber);
            account.CreateNewAccountActivity(date, amount);
        }

        public double FindAccountBalanceByAccountNumber(string bankAccountNumber)
        {
            var account = FindAccountByAccountNumber(bankAccountNumber);
            return account.Balance;
        }

        public List<AccountActivity> FindAccountEventsByAccountNumber(string bankAccountNumber, DateTime from, DateTime to)
        {
            var account = FindAccountByAccountNumber(bankAccountNumber);
            return account.FindActivitiesOnTimeIntervall(from, to);
        }

        private Account FindAccountByAccountNumber(string bankAccountNumber)
        {
            return _accounts.First(a => a.Accountnumber == bankAccountNumber);
        }
    }
}
