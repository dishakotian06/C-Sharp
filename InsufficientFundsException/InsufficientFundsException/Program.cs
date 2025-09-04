namespace InsufficientFundsException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount(1000);

            try
            {
                account.DisplayBalance();
                Console.Write("Enter amount to withdraw: ");
                double w = Convert.ToDouble(Console.ReadLine());
                account.Withdraw(w);
                account.DisplayBalance();
            }
            catch (InsufficientFundsException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

        }
    }
}
