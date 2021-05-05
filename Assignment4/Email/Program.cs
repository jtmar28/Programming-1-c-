using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Email
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter your email address: ");
            string input = Console.ReadLine();
            int count = 0;
            for(int i = 0; i <= input.Length - 1; i++)
            {
                if(input[i] == '@')
                {
                    count++;
                }
            }
            Console.WriteLine(string.Format("The email address entered is {0}."), count == 1 ? "valid" : "not valid");
            Console.ReadLine();
        }
    }
}
