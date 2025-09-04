using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defaultconstructor
{
    public class Student
    {
        public string name;

        public Student() // Default constructor
        {
            name = "Bob";
        }

        public void Show()
        {
            Console.WriteLine("Name: " + name);
        }

    }
}