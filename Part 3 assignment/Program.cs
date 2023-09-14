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
            Random generator = new Random();

            string name;
            int age, year;
            double num1, num2, num3, lndnBrg, gldnGtBrg, brklnBrg, triSide1, triSide2;
            lndnBrg = 2.4;
            gldnGtBrg = 27.37;
            brklnBrg = 18.34;
            triSide1 = generator.Next(1, 101);
            triSide2 = generator.Next(1, 101);
            Console.WriteLine("Please put in your name, age, and current year.");
            name = Console.ReadLine();
            age = Convert.ToInt32(Console.ReadLine());
            year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Hello {name}! If you're {age} and the year is {year}, than you were born in either {year - age} or {year - age - 1}.");
            Console.WriteLine();
            Console.WriteLine("Pick 3 numbers.");
            num1 = Convert.ToDouble(Console.ReadLine());
            num2 = Convert.ToDouble(Console.ReadLine());
            num3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Added together those equal {num1 + num2 + num3}. Subtracted they equal {num1 - num2 - num3}. Multiplied it equals {num1 * num2 * num3}. Divided they equal {num1 / num2 / num3}.");
            Console.WriteLine();
            Console.WriteLine($"If the London bridge is {lndnBrg * 100}M long, the Golden gate bridge is {gldnGtBrg * 100}M long, and the Brooklyn bridge is {brklnBrg * 100}M long, than the average length of those bridges is {(int)(lndnBrg + gldnGtBrg + brklnBrg) / 3}KM long.");
            Console.WriteLine();
            Console.WriteLine($"In a right angle triangle, if side A = {triSide1} and side B = {triSide2}, than the hypotenuse on the triangle equals {Math.Sqrt((triSide1 * triSide1) + (triSide2 * triSide2))}");

            Console.ReadLine();
        }
    }
}
