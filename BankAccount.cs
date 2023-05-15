using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testing
{
    public class BankAccount
    {
        private static readonly Random random = new Random();

        public string Name { get; set; }
        public int AccountNumber { get; }
        public double Balance { get; protected set; }

        public BankAccount(string name, double balance)
        {
            Name = name;
            Balance = balance;
            AccountNumber = random.Next(100000000, 999999999);
        }

        public virtual bool Deposit(double amount)
        {
            if (amount >= 0)
            {
                Balance += amount;
                return true;
            }
            else
            {
                return false;
            }
        }

        public virtual bool Withdraw(double amount)
        {
            if (amount >= 0 && Balance - amount >= 0)
            {
                Balance -= amount;
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            return $"{GetType().Name} - {Name} - Account Number: {AccountNumber} - Balance: {Balance:C}";
        }
    }
}
