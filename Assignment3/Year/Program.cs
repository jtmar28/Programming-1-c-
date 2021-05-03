using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Year
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter a 2-digit or 4 digit year: ");
            string year = Console.ReadLine();
            int result = 0;
            if(year.Length == 2)
            {
                result = Convert.ToInt32(year) + 2000;
            }else if(year.Length == 4)
            {
                result = Convert.ToInt32(year);
            }
            else
            {
                Console.WriteLine("Year not valid");
                Environment.Exit(0);
            }
            Console.WriteLine(string.Format("The year entered is {0}."), result);
        }
    }
}
