using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircumferenceOfACircle
{
    class Program
    {
        public static void Main(string[] args)
        {
            const double PI = 3.14;
            double radius = 3.2;
            Console.WriteLine("The circumference of a circle with a radius of "
            + radius + " is " + (radius * 2 * PI) + ".");
        }
    }
}
