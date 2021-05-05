using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberOfWebsites
{
    class Program
    {
        public static void Main(string[] args)
        {
            Boolean stop = false;
            int result = 0;

            while (!stop)
            {
                Console.WriteLine("Please enter a website url (e.g www.rrc.ca) : ");
                string input = Console.ReadLine().ToLower();
                int lengthOfString = input.Length;

                Boolean isDomain = input[lengthOfString - 3] == '.' || input[lengthOfString - 4] == '.';
                if (input.Equals("stop"))
                {
                    if (isDomain)
                    {
                        result++;
                    }
                    stop = true;
                }
                else
                {
                    if (isDomain)
                    {
                        result++;
                    }
                }
            }
            Console.WriteLine(string.Format("There were {0} commercial websites entered.", result));
            Console.ReadLine();
        }
    }
}
