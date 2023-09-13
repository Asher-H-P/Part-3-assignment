using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_3_assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            int age, year;
            double num1, num2, num3;
            Console.WriteLine("Please put in your name, age, and current year.");
            name = Console.ReadLine();
            age = Convert.ToInt32(Console.ReadLine());
            year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Hello {name}! If you're {age} and the year is {year}, than you were born in either {year - age} or {year - age - 1}.");
            Console.WriteLine("Pick 3 numbers.");
            num1 = Convert.ToDouble(Console.ReadLine());
            num2 = Convert.ToDouble(Console.ReadLine());
            num3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("");

            Console.ReadLine();
        }
    }
}
