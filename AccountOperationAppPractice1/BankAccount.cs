using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountOperationAppPractice1
{
    class BankAccount
    {
        public double accountNumber;
        public string customerName;
        public double amount;
        public double balance;

        public bool Diposit()
        {
            balance = balance + amount;
            return true;
        }

        public bool Withdraw()
        {
            balance = balance - amount;
            return true;
        }

        public string GetReport()
        {
            string message = customerName+", " + "your account number: " + accountNumber +" "+ "and its balance: " + balance;
            return (message);
        }


    }
}
