using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace testing
{
    public class RetirementAccount : SavingsAccount
    {
        public RetirementAccount(string name, double balance, double interest) : base(name, balance, interest)
        {
        }

        //public override bool ToString()
        //{
        //    MessageBox.Show("Cannot withdraw from a retirement account.");
        //    return false;

        //}
        public new bool Withdraw(double amount)
        {
            MessageBox.Show("Cannot withdraw from a retirement account.");
            return false;
        }
    }
}
