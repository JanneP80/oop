﻿using System;
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

            Console.ReadKey();
        }
    }
}
