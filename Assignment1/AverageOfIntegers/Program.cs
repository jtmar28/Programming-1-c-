using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageOfIntegers
{
    class Program
    {
        public static void Main(string[] args)
        {
            int value1 = 1, value2 = 7, value3 = 9, value4 = 34,
                average = (value1 + value2 + value3 + value4 / 4);
            Console.WriteLine("The average of values "
                + value1 + ", "
                + value2 + ", "
                + value3 + ", "
                + value4 + " is "
                + average + ".");
            Console.ReadLine();
        }
    }
}
