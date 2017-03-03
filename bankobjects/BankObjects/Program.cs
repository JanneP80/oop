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

            // 5. Adding first deposits on everybodys account:
            var account1 = new AccountObject(customers[0].Accountnumber);
            account1.CreateNewAccountActivity(new DateTime(2016, 6, 3), new TimeSpan(9, 10, 3), 1000300);

            var account2 = new AccountObject(customers[1].Accountnumber);
            account2.CreateNewAccountActivity(new DateTime(2016, 7, 2), new TimeSpan(19, 20, 14), 2000100);

            var account3 = new AccountObject(customers[2].Accountnumber);
            account3.CreateNewAccountActivity(new DateTime(2016, 8, 1), new TimeSpan(5, 50, 45), 3000200);

            // 6. Printing all balances with to string:
            Console.WriteLine("\nPrinting every customers balance after first deposit: ");
            Console.WriteLine("Customer 1, " + customers[0].ToString() + " Balance: " + account1.Balance);
            Console.WriteLine("Customer 2, " + customers[1].ToString() + " Balance: " + account2.Balance);
            Console.WriteLine("Customer 3, " + customers[2].ToString() + " Balance: " + account3.Balance);

            // 7. Creating new withdraws on accounts
            account3.CreateNewAccountActivity(new DateTime(2016, 9, 9), new TimeSpan(6, 41, 45), -300200);
            account1.CreateNewAccountActivity(new DateTime(2016, 8, 12), new TimeSpan(4, 20, 4), -7300);
            account2.CreateNewAccountActivity(new DateTime(2017, 1, 12), new TimeSpan(7, 15, 4), -20700);
            account2.CreateNewAccountActivity(new DateTime(2017, 2, 24), new TimeSpan(19, 30, 0), -11300);

            account3.CreateNewAccountActivity(new DateTime(2016, 10, 21), new TimeSpan(16, 11, 45), -10240);
            account1.CreateNewAccountActivity(new DateTime(2017, 1, 19), new TimeSpan(14, 21, 14), -2300);
            account2.CreateNewAccountActivity(new DateTime(2017, 3, 1), new TimeSpan(17, 43, 24), -704);
            account2.CreateNewAccountActivity(new DateTime(2017, 2, 24), new TimeSpan(22, 32, 6), -1300);
            account1.CreateNewAccountActivity(new DateTime(2016, 11, 12), new TimeSpan(11, 11, 14), -12300);

            Console.WriteLine("\nPrinting every customers all transactions: ");
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

            Console.WriteLine("\nCustomer 3 " + customers[2]);
            for (int i = 0; i < account3.AccountActivity.Count; i++)
            {
                Console.WriteLine(account3.AccountActivity[i]);
            }

            Console.WriteLine("\nPrinting every customers balance at the end: "); // checking balance
            Console.WriteLine("\nCustomer 1, " + customers[0] + " Balance: " + account1.Balance);
            Console.WriteLine("Customer 2, " + customers[1] + " Balance: " + account2.Balance);
            Console.WriteLine("Customer 3, " + customers[2] + " Balance: " + account3.Balance);

            Console.WriteLine("\nCustomer 2 timeintervall 1-3 months " + customers[1]);
            for (int i = 0; i < account2.AccountActivity.Count; i++)
            {
                if (account2.AccountActivity[i].Date.Month > (1) && account2.AccountActivity[i].Date.Month < (3))
                {
                    Console.WriteLine(account2.AccountActivity[i]);
                }
            }

            PrintTransactions(account1.AccountActivity, customers[0]);

            var endTime = DateTime.Today;
            var time = new TimeSpan(24 * 30 * 6, 0, 0); // hours * days * 6 = 6 months
            var startTime = endTime.Date - time;
            Console.WriteLine("\nAll activity in the bank for the past 6 months: ");
            PrintTransactions(account1.PrintOutActivityOnTimeIntervall(startTime, endTime), customers[0]);
            PrintTransactions(account2.PrintOutActivityOnTimeIntervall(startTime, endTime), customers[1]);
            PrintTransactions(account3.PrintOutActivityOnTimeIntervall(startTime, endTime), customers[2]);

            Console.ReadKey();
        }

        static void PrintTransactions(List<AccountActivityObject> AccountActivity, CustomerObject customer)
        {
            Console.WriteLine("\nTransactions ({0} {1}):", customer.Firstname, customer.Lastname);
            for (int i = 0; i < AccountActivity.Count(); i++)
            {
                Console.WriteLine("{0}\t{1}\t{2}{3:0.00}", AccountActivity[i].Date.ToShortDateString(), AccountActivity[i].Time, AccountActivity[i].Sum >= 0 ? "+" : "", AccountActivity[i].Sum);
            }
            //Console.WriteLine("Balance on the timeinterval: ");
            Console.WriteLine("\n");
        }
    }
}
