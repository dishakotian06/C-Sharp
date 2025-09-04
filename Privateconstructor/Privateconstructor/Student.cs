using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Privateconstructor
{
    public class Student
    {
        private static Student instance;

        private Student() // Private constructor
        {
            Console.WriteLine("Private constructor called.");
        }

        public static Student GetInstance()
        {
            if (instance == null)
                instance = new Student();

            return instance;
        }


    }
}