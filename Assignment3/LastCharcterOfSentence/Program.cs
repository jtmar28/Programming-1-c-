using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastCharcterOfSentence
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter a sentence complete with punctuation: ");
            string punctuationType;
            string sentence = Console.ReadLine();
            int lastCharPlacement = sentence.Length - 1;
            char lastChar = sentence[lastCharPlacement];
            switch (lastChar)
            {
                case '.':
                    punctuationType = "declarative";
                    break;
                case '?':
                    punctuationType = "interrogative";
                    break;
                case '!':
                    punctuationType = "exlamatory";
                    break;
                default:
                    punctuationType = "other";
                    break;
            }
            Console.WriteLine(string.Format("{0}\nThe sentence is {1}.", sentence, punctuationType));
            Console.ReadLine();
        }
    }
}
