using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankObjects
{
    class BankObject
    {
        private string _bankName;
        private string[] _account;
        private Random _rand = new Random(DateTime.Now.Millisecond);

        public string BankName
        {
            get { return _bankName; }
            set { _bankName = value; }
        }

        public BankObject(string bankName)
        {
            _bankName = bankName;
            // _account = account;
        }

        public string[] Account
        {
            get { return _account; }
            set { _account = value; }
        }

        public string CreateNewAccount()
        {
            
            var _accountNumber = "FI";
            for (int i = 0; i < 16; i++)
            {
                _accountNumber +=  _rand.Next(0, 9);
            }
            
            return _accountNumber;
        }
    }
}
