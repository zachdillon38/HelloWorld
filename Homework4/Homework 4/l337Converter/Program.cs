using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l337Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            //Zach Dillon

            //Prompt for user input, convert to upper

            Console.WriteLine("Please enter a sentence...");
            String sentence = Console.ReadLine().ToUpper();

            //Perform replacements

            sentence = sentence.Replace("A", "@").Replace("E", "3").Replace("H", "|-|").Replace("S", "$").Replace("T", "7").Replace("U", "|_|");

            //Insert ! if necessary

            if (sentence.EndsWith("!"))
            {
                Console.WriteLine(sentence);

            }
            else

            {
                Console.WriteLine(sentence + "!");
            }

            Console.ReadKey();
        }
    }
}
