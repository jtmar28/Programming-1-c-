using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoPasswords
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter your password: ");
            string pass1 = Console.ReadLine();
            Console.WriteLine("Please repeat your password: ");
            string pass2 = Console.ReadLine();
            Boolean match = pass1.Equals(pass2);
            Console.WriteLine(match ? "You are now registered as a new user." : "Sorry, there is a typo in your password.");
            Console.ReadLine();
        }
    }
}
