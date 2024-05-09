using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coreObjectOrientedConcepts
{
    interface IBankAccount
    {
        void deposit();
        void withdraw();
        void balance();
    }
    interface IManageAccount
    {
        void openAcc();
        void closeAcc();

    }
    public class SavingAcc:IBankAccount, IManageAccount
    {
        public void deposit() {
            Console.WriteLine("Deposit in Saving Account.");
        }
        public void withdraw() {
            Console.WriteLine("Withdraw in Saving Account.");
        }
        public void balance() {
            Console.WriteLine("Balance in Saving Account.");
        }

        public void openAcc()
        {
            Console.WriteLine("Open Saving Account.");

        }

        public void closeAcc()
        {
            Console.WriteLine("Closing Saving Account.");

        }
    }
}
