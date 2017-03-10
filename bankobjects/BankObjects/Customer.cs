using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankObjects
{
    class Customer
    {
        private string _firstName;
        private string _lastName;
        private string _accountNumber;


        public Customer(string firstName, string lastName, string accountNumber)
        {
            _firstName = firstName;
            _lastName = lastName;
            _accountNumber = accountNumber;
        }

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public string AccountNumber
        {
            get { return _accountNumber; }
            set { _accountNumber = value; }
        }

        public override string ToString()
        {
            return PrintCustomerInfo();
        }

        private string PrintCustomerInfo() // private is only called here
        {
            return "FirstName: " + _firstName + ", " + " LastName: " + _lastName + ": " + "\nAccountnumber: " + AccountNumber;
        }
    }
}
