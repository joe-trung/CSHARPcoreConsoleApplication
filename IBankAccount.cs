using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coreConsoleApplication
{
    internal interface IManageBankAccount
    {
        void openAccount();
        void closeAccount();
    }
    internal interface IBankAccount
    {
        void deposit();
        void withdraw();
        void balance();

    }
    public class SavingAcc : IBankAccount, IManageBankAccount
    {
        public void balance()
        {
            Console.WriteLine("Balance in Saving Account");
        }

        public void closeAccount()
        {
            Console.WriteLine("Closing Saving Account");
        }

        public void deposit()
        {
            Console.WriteLine("Deposit in Saving Account");
        }

        public void openAccount()
        {
            Console.WriteLine("Opening Saving Account");
        }

        public void withdraw()
        {
            Console.WriteLine("Withdraw from Saving Account");
        }
    }
}
