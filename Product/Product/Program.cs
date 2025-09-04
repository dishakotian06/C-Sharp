namespace Product
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Smartphone s = new Smartphone();
            s.Name = "Galaxy S23";
            s.Price = 75000;
            s.Brand = "Samsung";
            s.Warranty = "1 Year";
            s.OS = "Android";
            s.Storage = 256;
            s.Show();
        }
    }
}
