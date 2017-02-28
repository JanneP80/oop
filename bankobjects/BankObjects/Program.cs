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
            var bankObject = new BankObject("Deutche Bank");
            var customer01 = new CustomerObject("Erkki", "Liikanen");
            var customer02 = new CustomerObject("Sirkka", "Hämäläinen");
            var customer03 = new CustomerObject("Rolf", "Kullberg");
            customer03.Accountnumber = bankObject.CreateNewAccount();
            customer02.Accountnumber = bankObject.CreateNewAccount();
            customer01.Accountnumber = bankObject.CreateNewAccount();


            Console.WriteLine("customer03: " + customer03.Firstname);
            Console.WriteLine("customer03, account: "+ customer03.Accountnumber);

            Console.WriteLine("customer02: " + customer02.Firstname);
            Console.WriteLine("customer02, account: " + customer02.Accountnumber);

            Console.WriteLine("customer01: " + customer01.Firstname);
            Console.WriteLine("customer01, account: " + customer01.Accountnumber);

            var accountObject01 = new AccountObject(customer03.Accountnumber);
            accountObject01.Balance = accountObject01.CreateNewAccountActivity(1000300);
            Console.WriteLine("customer01, balance: " + accountObject01.Balance);

            var AccountObject02 = new AccountObject(customer03.Accountnumber);
            AccountObject02.Balance = AccountObject02.CreateNewAccountActivity(2000100);
            Console.WriteLine("customer02, balance: " + AccountObject02.Balance);

            var AccountObject03 = new AccountObject(customer03.Accountnumber); // or putting accountnumber into the naming accountobjectXX
            AccountObject03.Balance = AccountObject03.CreateNewAccountActivity(3000200);
            Console.WriteLine("customer03, balance: " + AccountObject03.Balance);

            Console.Write(customer01);
            Console.WriteLine(", balance: " + accountObject01.Balance);
            Console.Write(customer02);
            Console.WriteLine(", balance: " + AccountObject02.Balance);
            Console.Write(customer03);
            Console.WriteLine(", balance: " + AccountObject03.Balance);
            Console.WriteLine("\n");

            // TODO!!! new activity with timestamps
            accountObject01.Balance = accountObject01.CreateNewAccountActivity(-10300);

            var includeTimestamp02 = new AccountActivityObject(new DateTime(2017, 2, 1), new TimeSpan(9, 30, 0),  -10300);
            Console.WriteLine("Account activity 02: "+ includeTimestamp02);

            AccountObject02.Balance = AccountObject02.CreateNewAccountActivity(-20700);
            AccountObject03.Balance = AccountObject03.CreateNewAccountActivity(-200300);
            accountObject01.Balance = accountObject01.CreateNewAccountActivity(-7300);
            AccountObject02.Balance = AccountObject02.CreateNewAccountActivity(-11300);

            Console.Write(customer01);
            Console.WriteLine(", balance: " + accountObject01.Balance);
            Console.Write(customer02);
            Console.WriteLine(", balance: " + AccountObject02.Balance);
            Console.Write(customer03);
            Console.WriteLine(", balance: " + AccountObject03.Balance);


            Console.ReadKey();
        }
    }
}
