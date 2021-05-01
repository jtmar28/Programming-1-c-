using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfCircle
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter a value for the radius of a circle in centimeters: ");

            double radius = Convert.ToDouble(Console.ReadLine());
            const double pi = Math.PI;
            double area = pi * Math.Pow(radius, 2);
            double circumference = 2 * pi * radius;

            Console.WriteLine(string.Format("The circumference of a circle with a radius of {0} is {1:0.00} cm.", radius, circumference));
            Console.WriteLine(string.Format("The area of a circle with a radius of {0} is {1:0.00} cm\u00b2.", radius, area));
            Console.ReadLine();
        }
    }
}
