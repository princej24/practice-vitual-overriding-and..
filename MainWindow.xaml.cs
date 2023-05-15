using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace testing
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
   public partial class MainWindow : Window
    {
        private List<BankAccount> accounts;

        public MainWindow()
        {
            InitializeComponent();

            accounts = new List<BankAccount>();

          
            CheckingAccount checkingAccount = new CheckingAccount("prince jeff", 1000, 35);
            SavingsAccount savingsAccount = new SavingsAccount("Jostin diaz", 2000, 5);
            RetirementAccount retirementAccount = new RetirementAccount("Bob muturi", 5000, 10);

           
            accounts.Add(checkingAccount);
            accounts.Add(savingsAccount);
            accounts.Add(retirementAccount);


            //foreach (RetirementAccount account in )
            //{
            //    MessageBox.Show("Cannot withdraw from a retirement account.");

            //}
            foreach (BankAccount account in accounts)
            {
                account.Deposit(500);
            }

            
            foreach (BankAccount account in accounts)
            {
                account.Deposit(-50000);
            }

            
            foreach (BankAccount account in accounts)
            {
                account.Withdraw(200);
            }

            foreach (BankAccount account in accounts)
            {
                account.Withdraw(-200000);
            }

            
            foreach (BankAccount account in accounts)
            {
                if (account is CheckingAccount checking)
                {
                    checking.Withdraw(account.Balance + checking.OverdraftFee);
                }
                else
                {
                    account.Withdraw(account.Balance + 1);
                }
            }


            foreach (BankAccount account in accounts)
            {
                MessageBox.Show(account.ToString());


            }


        }
    }
}
