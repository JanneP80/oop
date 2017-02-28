using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            var BankObject = new BankObject("Deutche Bank");
            var Customer01 = new CustomerObject("Erkki", "Liikanen");
            var Customer02 = new CustomerObject("Sirkka", "Hämäläinen");
            var Customer03 = new CustomerObject("Rolf", "Kullberg");

            Customer03.Accountnumber = BankObject.CreateNewAccount();
            Customer02.Accountnumber = BankObject.CreateNewAccount();
            Customer01.Accountnumber = BankObject.CreateNewAccount();


            Console.WriteLine("customer03: " + Customer03.Firstname);
            Console.WriteLine("customer03, account: "+ Customer03.Accountnumber);

            Console.WriteLine("customer02: " + Customer02.Firstname);
            Console.WriteLine("customer02, account: " + Customer02.Accountnumber);

            Console.WriteLine("customer01: " + Customer01.Firstname);
            Console.WriteLine("customer01, account: " + Customer01.Accountnumber);

            var AccountObject01 = new AccountObject(Customer03.Accountnumber);
            AccountObject01.Balance = AccountObject01.CreateNewAccountActivity(1000300);
            Console.WriteLine("customer01, balance: " + AccountObject01.Balance);

            var AccountObject02 = new AccountObject(Customer03.Accountnumber);
            AccountObject02.Balance = AccountObject02.CreateNewAccountActivity(2000100);
            Console.WriteLine("customer02, balance: " + AccountObject02.Balance);

            var AccountObject03 = new AccountObject(Customer03.Accountnumber);
            AccountObject03.Balance = AccountObject03.CreateNewAccountActivity(3000200);
            Console.WriteLine("customer03, balance: " + AccountObject03.Balance);



            Console.ReadKey();
        }
    }
}
