using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BankObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            var bankObject = new BankObject("Deutche Bank");

            List<CustomerObject> customers = new List<CustomerObject>();

            customers.Add(new CustomerObject("Erkki", "Liikanen", bankObject.CreateNewAccount()));
            customers.Add(new CustomerObject("Sirkka", "Hämäläinen", bankObject.CreateNewAccount()));
            customers.Add(new CustomerObject("Rolf", "Kullberg", bankObject.CreateNewAccount()));

            var account1 = new AccountObject(customers[0].Accountnumber);
            account1.CreateNewAccountActivity(new DateTime(2016, 6, 3), new TimeSpan(9, 10, 3), 1000300);

            var account2 = new AccountObject(customers[1].Accountnumber);
            account2.CreateNewAccountActivity(new DateTime(2016, 7, 2), new TimeSpan(19, 20, 14), 2000100);

            var account3 = new AccountObject(customers[2].Accountnumber);
            account3.CreateNewAccountActivity(new DateTime(2016, 8, 1), new TimeSpan(5, 50, 45), 3000200);

            Console.WriteLine("Customer 1, " + customers[0].ToString() + " Balance: " + account1.Balance);
            Console.WriteLine("Customer 2, " + customers[1].ToString() + " Balance: " + account2.Balance);
            Console.WriteLine("Customer 3, " + customers[2].ToString() + " Balance: " + account3.Balance);

            account3.CreateNewAccountActivity(new DateTime(2016, 9, 9), new TimeSpan(6, 41, 45), -300200);
            account1.CreateNewAccountActivity(new DateTime(2016, 8, 12), new TimeSpan(4, 20, 4), -7300);
            account2.CreateNewAccountActivity(new DateTime(2017, 1, 12), new TimeSpan(7, 15, 4), -20700);
            account2.CreateNewAccountActivity(new DateTime(2017, 2, 24), new TimeSpan(19, 30, 0), -11300);

            account3.CreateNewAccountActivity(new DateTime(2016, 10, 21), new TimeSpan(16, 11, 45), -10240);
            account1.CreateNewAccountActivity(new DateTime(2017, 1, 19), new TimeSpan(14, 21, 14), -2300);
            account2.CreateNewAccountActivity(new DateTime(2017, 3, 1), new TimeSpan(17, 43, 24), -704);
            account2.CreateNewAccountActivity(new DateTime(2017, 2, 24), new TimeSpan(22, 32, 6), -1300);
            account1.CreateNewAccountActivity(new DateTime(2016, 11, 12), new TimeSpan(11, 11, 14), -12300);

            //bankObject.Account.ElementAt(0).Balance = bankObject.Account.ElementAt(0).CreateNewAccountActivity(new DateTime(2017, 6, 3), new TimeSpan(9, 10, 4), 1000300);
            Console.WriteLine("\nCustomer 1, " + customers[0].ToString() + " Balance: " + account1.Balance);
            Console.WriteLine("Customer 2, " + customers[1].ToString() + " Balance: " + account2.Balance);
            Console.WriteLine("Customer 3, " + customers[2].ToString() + " Balance: " + account3.Balance);

            Console.WriteLine("\nCustomer 1 " + customers[0]);
            for (int i = 0; i < account1.AccountActivity.Count; i++)
            {
                Console.WriteLine(account1.AccountActivity[i]);

            }
            Console.WriteLine("\nCustomer 2 " + customers[1]);
            for (int i = 0; i < account2.AccountActivity.Count; i++)
            {
                Console.WriteLine(account2.AccountActivity[i]);

            }
            Console.WriteLine("\nCustomer 2 timeintervall 1-3 months " + customers[1]);
            for (int i = 0; i < account2.AccountActivity.Count; i++)
            {
                if (account2.AccountActivity[i].Date.Month>(1) && account2.AccountActivity[i].Date.Month < (3) )
                {

                    Console.WriteLine(account2.AccountActivity[i]);
                }
            }
            Console.WriteLine("\nCustomer 3 " + customers[2]);
            for (int i = 0; i < account3.AccountActivity.Count; i++)
            {
                Console.WriteLine(account3.AccountActivity[i]);

            }


            /*
            Console.WriteLine("\ncustomer,{0} balance: " + account1.Balance, customers[0]);
            Console.WriteLine("account01, activity: " + account1.AccountActivity[0]);
            Console.WriteLine(" OK! account: " + customers.ElementAt(0).Accountnumber);

            Console.WriteLine("\n     customer02, balance: " + account2.Balance);
            Console.WriteLine("    account02, activity: " + account2.AccountActivity[0]);
            Console.WriteLine("      OK! account: " + customers[1].Accountnumber);

            Console.WriteLine("\ncustomer,{0} balance: " + account3.Balance, customers[2]);
            Console.WriteLine("    account02, activity: " + account3.AccountActivity[0]);

            */
            // poistuvaa koodia :
            /*
            var customer01 = new CustomerObject("Erkki", "Liikanen", bankObject.CreateNewAccount());
            var customer02 = new CustomerObject("Sirkka", "Hämäläinen", bankObject.CreateNewAccount());
            var customer03 = new CustomerObject("Rolf", "Kullberg", bankObject.CreateNewAccount());
            customer03.Accountnumber = bankObject.CreateNewAccount();
            customer02.Accountnumber = bankObject.CreateNewAccount();
            customer01.Accountnumber = bankObject.CreateNewAccount();
            */
            /*

            Console.WriteLine("customer03: " + customer03.Firstname);
            Console.WriteLine("customer03, account: "+ customer03.Accountnumber);

            Console.WriteLine("customer02: " + customer02.Firstname);
            Console.WriteLine("customer02, account: " + customer02.Accountnumber);

            Console.WriteLine("customer01: " + customer01.Firstname);
            Console.WriteLine("customer01, account: " + customer01.Accountnumber);
            */

            /* var accountObject01 = new AccountObject(customer01.Accountnumber);

             accountObject01.Balance = accountObject01.CreateNewAccountActivity(new DateTime(2017, 6, 3), new TimeSpan(9, 10, 4), 1000300);
             Console.WriteLine("customer01, balance: " + accountObject01.Balance);



             var accountObject02 = new AccountObject(customer02.Accountnumber);
             accountObject02.Balance = accountObject02.CreateNewAccountActivity(new DateTime(2017, 6, 3), new TimeSpan(9, 10, 4), 2000100);
             Console.WriteLine("customer02, balance: " + accountObject02.Balance);

             var accountObject03 = new AccountObject(customer03.Accountnumber); // or putting accountnumber into the naming accountobjectXX
             accountObject03.Balance = accountObject03.CreateNewAccountActivity(new DateTime(2017, 6, 3), new TimeSpan(9, 10, 4), 3000200);
             Console.WriteLine("customer03, balance: " + accountObject03.Balance);

             Console.Write(customer01);
             Console.WriteLine(", balance: " + accountObject01.Balance);
             Console.Write(customer02);
             Console.WriteLine(", balance: " + accountObject02.Balance);
             Console.Write(customer03);
             Console.WriteLine(", balance: " + accountObject03.Balance);
             Console.WriteLine("\n");

     */
            // TODO!!! connect new activity with timestamps
            /*
            accountObject01.Balance = accountObject01.CreateNewAccountActivity(new DateTime(2017, 6, 3), new TimeSpan(9, 10, 4) , - 10300);

            var includeTimestamp02 = new AccountActivityObject(new DateTime(2017, 2, 1), new TimeSpan(10, 30, 0),  -10300);

            Console.WriteLine("Account activity 02: "+ includeTimestamp02);

            accountObject02.Balance = accountObject02.CreateNewAccountActivity(new DateTime(2017, 6, 3), new TimeSpan(9, 10, 4) , - 20700);
            var includeTimestamp03 = new AccountActivityObject(new DateTime(2017, 6, 3), new TimeSpan(9, 10, 4), -20700);

            account3.Balance = account3.CreateNewAccountActivity(new DateTime(2017, 6, 3), new TimeSpan(9, 10, 4) , - 200300);
            var includeTimestamp04 = new AccountActivityObject(new DateTime(2017, 5, 2), new TimeSpan(19, 30, 0), -200300);

            accountObject01.Balance = accountObject01.CreateNewAccountActivity(new DateTime(2017, 6, 3), new TimeSpan(9, 10, 4) ,- 7300);
            var includeTimestamp05 = new AccountActivityObject(new DateTime(2017, 3, 1), new TimeSpan(7, 20, 10), -7300);

            accountObject02.Balance = accountObject02.CreateNewAccountActivity(new DateTime(2017, 6, 3), new TimeSpan(9, 10, 4) ,- 11300);
            var includeTimestamp06 = new AccountActivityObject(new DateTime(2017, 2, 5), new TimeSpan(6, 10, 0), -11300);


            Console.Write(customer01);
            Console.WriteLine(", balance: " + accountObject01.Balance);
            Console.Write(customer02);
            Console.WriteLine(", balance: " + accountObject02.Balance);
            Console.Write(customer03);
            Console.WriteLine(", balance: " + accountObject03.Balance);
            */
            // bankObject.addtrasaction(customers[X500DistinguishedName], accountnumber,
            //   new DesignerTransactionCloseEventArgs(sutomer, new DateTime(year, month, day)));
            PrintTransactions(account1.AccountActivity, customers[0]);

            var endTime = DateTime.Today;
            var time = new TimeSpan(24 * 30 * 6, 0, 0);
            var startTime = endTime.Date - time;
            Console.WriteLine("\nTilitapahtumat viimeisen kuuden kuukauden ajalta:");
            PrintTransactions(account1.PrintOutActivityOnTimeIntervall(startTime, endTime), customers[0]);
            PrintTransactions(account2.PrintOutActivityOnTimeIntervall(startTime, endTime), customers[1]);
            PrintTransactions(account3.PrintOutActivityOnTimeIntervall(startTime, endTime), customers[2]);

            Console.ReadKey();
        }

        static void PrintTransactions(List<AccountActivityObject> AccountActivity, CustomerObject customer)
        {
            Console.WriteLine("\nTilitapahtumat ({0} {1}):", customer.Firstname, customer.Lastname);
            for (int i = 0; i < AccountActivity.Count(); i++)
            {
                Console.WriteLine("{0}\t{1}\t{2}{3:0.00}", AccountActivity[i].Date.ToShortDateString(), AccountActivity[i].Time, AccountActivity[i].Sum >= 0 ? "+" : "", AccountActivity[i].Sum);
            }
            //Console.WriteLine("Balance on the timeinterval: ");
            Console.WriteLine("\n");
        }
    }
}
