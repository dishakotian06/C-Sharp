namespace Payment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CreditCardPayment cc = new CreditCardPayment();
            cc.Amount = 5000;
            cc.CardHolder = "John Doe";
            cc.Process();

            UpiPayment upi = new UpiPayment();
            upi.Amount = 2000;
            upi.UpiId = "john@upi";
            upi.Process();
        }
    }
}
