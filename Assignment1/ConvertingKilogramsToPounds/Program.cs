using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertingKilogramsToPounds
{
    class Program
    {
        public static void Main(string[] args)
        {
            int value1 = 10, value2 = 50, value3 = 100;
            const double pounds = 0.454;
            Console.WriteLine("value1" + " kilograms is " + (value1 / pounds) + " pounds.");
            Console.WriteLine("value2" + " kilograms is " + (value2 / pounds) + " pounds.");
            Console.WriteLine("value3" + " kilograms is " + (value3 / pounds) + " pounds.");
            Console.ReadLine();

        }
    }
}
