using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialOfNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter an integer value: ");
            int input = Convert.ToInt32(Console.ReadLine()), sum = 1;
            for(int i = 1; i <= input; i++)
            {
                sum *= i;
            }
            Console.WriteLine(string.Format("The factorial of {0} is {1}.", input, sum));
        }
    }
}
