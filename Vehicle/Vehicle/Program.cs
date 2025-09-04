namespace Vehicle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car c = new Car();
            c.Model = "Honda City";
            c.RentPerDay = 1500;
            c.Seats = 5;
            c.FuelType = "Petrol";
            c.Show();
        }
    }
}
