using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    class Vehicle
    {
        public string Model;
        public double RentPerDay;
    }

    class Car : Vehicle
    {
        public int Seats;
        public string FuelType;

        public void Show()
        {
            Console.WriteLine(Model + ", Rent: " + RentPerDay + ", Seats: " + Seats + ", Fuel: " + FuelType);
        }
    }
}
