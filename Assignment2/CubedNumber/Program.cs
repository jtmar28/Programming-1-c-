using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubedNumber
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter a value to be cubed:");
            double number = Convert.ToDouble(Console.ReadLine());
            double cubed = Math.Pow(number, 3);
            Console.WriteLine(string.Format("The cubed value of {0} is {1}", number, cubed));
            Console.ReadLine();
        }
    }
}
