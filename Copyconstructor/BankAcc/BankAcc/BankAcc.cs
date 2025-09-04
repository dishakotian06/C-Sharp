using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAcc
{
    class BankAcc
    {
        public double Balance;

        public void Deposit(double amt)
        {
            Balance += amt;
            Console.WriteLine("Deposited: " + amt);
        }

        public void Withdraw(double amt)
        {
            if (amt <= Balance)
            {
                Balance -= amt;
                Console.WriteLine("Withdrawn: " + amt);
            }
            else
                Console.WriteLine("Not enough balance");
        }
    }

    class SavingAcc : BankAcc
    {
        public double InterestRate;

        public void CalculateInterest()
        {
            Console.WriteLine("Interest: " + (Balance * InterestRate / 100));
        }
    }
}
