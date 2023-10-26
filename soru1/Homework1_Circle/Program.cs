using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1_Circle
{
    internal class CircleCalcs
    {
        static void Main(string[] args)
        {
            Double PI = 3.14159;

            Console.Write("input radius: ");

            int radius = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("radius is        : " + radius);
            Console.WriteLine("diameter is      : " + 2 * radius);
            Console.WriteLine("circumference is : " + 2 * PI * radius);
            Console.WriteLine("area is          : " + PI * radius * radius);
            Console.ReadLine();
        }
    }

}
