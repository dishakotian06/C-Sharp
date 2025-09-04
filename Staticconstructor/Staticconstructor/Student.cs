using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Staticconstructor
{
    public class Student
    {
        static int count;

        static Student() // Static constructor
        {
            count = 100;
            Console.WriteLine("Static constructor called.");
        }

        public static void ShowCount()
        {
            Console.WriteLine("Count: " + count);
        }

    }
}