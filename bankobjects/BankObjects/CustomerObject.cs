using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankObjects
{
    class CustomerObject
    {
        private string _firstname;
        private string _lastname;
        private string _accountnumber;


        public CustomerObject(string firstname, string lastname, string accountnumber)
        {
            _firstname = firstname;
            _lastname = lastname;
            _accountnumber = accountnumber;
        }

        public string Firstname
        {
            get { return _firstname; }
            set { _firstname = value; }
        }

        public string Lastname
        {
            get { return _lastname; }
            set { _lastname = value; }
        }

        public string Accountnumber
        {
            get { return _accountnumber; }
            set { _accountnumber = value; }
        }

        public override string ToString()
        {
            return PrintCustomerInfo();
        }

        private string PrintCustomerInfo() // private is only called here
        {
            return "Firstname: " + _firstname + ", " + " Lastname: " + _lastname + ": " + "\nAccountnumber: " + Accountnumber;
        }
    }
}
