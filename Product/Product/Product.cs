using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    class Product
    {
        public string Name;
        public double Price;
    }

    class ElectronicProduct : Product
    {
        public string Brand, Warranty;
    }

    class Smartphone : ElectronicProduct
    {
        public string OS;
        public int Storage;

        public void Show()
        {
            Console.WriteLine(Name + ", " + Brand + ", Price: " + Price + ", OS: " + OS + ", Storage: " + Storage + "GB");
        }
    }
}
