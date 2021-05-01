using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormattedTelephoneNumber
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter 10 digits");
            double tenDigitNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The supplied number formatted as a telephone number is {0:(###) ###-####}.", tenDigitNumber);
            Console.ReadLine();
        }
    }
}
