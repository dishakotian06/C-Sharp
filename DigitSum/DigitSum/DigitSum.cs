using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digitsum
{
    public class Digitsum
    {
        public void Read()
        {
            int number = 1234; // Fixed number
            int sum = 0;

            while (number != 0)
            {
                int digit = number % 10;
                sum += digit;
                number = number / 10;
            }

            Console.WriteLine("Sum of digits = " + sum);
        }

    }
}