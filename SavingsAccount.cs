using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testing
{
    public class SavingsAccount : BankAccount
    {
        private double _interest;

        public SavingsAccount(string name, double balance, double interest) : base(name, balance)
        {
            _interest = interest;
        }

        public double Interest
        {
            get { return _interest; }
            set { _interest = value; }
        }

        public override bool Deposit(double amount)
        {
            if (base.Deposit(amount))
            {
                Balance += Balance * _interest;
                return true;
            }

            return false;
        }

        public override string ToString()
        {
            return $"{base.ToString()} - Interest: {_interest:P}";
        }
    }
}
