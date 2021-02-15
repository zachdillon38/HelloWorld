using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VowelsandConsonants
{
    class Program
    {
        static void Main(string[] args)
        {
            //Zach Dillon

            //Declare variables to hold counting of vowels and consonants

            int Consonants = 0;
            int Vowels = 0;
            int i;

            //Ask for the user to input the sentence

            Console.WriteLine("Please enter a sentence...");
            String input = Console.ReadLine().ToLower();

            //Declare integer length to count the length of the sentence

            int Length = input.Length;



            //Begin For statement to count the length


            for (i = 0; i < Length; i++)
            {
                //Declare character value to identify with input

                Char x = input[i];

                if (Char.IsLetter(x))
                {
                    if (x == 'a' || x == 'e' || x == 'i' || x == 'o' || x == 'u')
                    {
                        Vowels++;

                    }


                    else if (x != 'a' || x != 'e' || x != 'i' || x != 'o' || x != 'u')
                    {
                        Consonants++;
                    }
                }
            }
            Console.WriteLine("There were " + Vowels + " vowels in your sentence.");
            Console.WriteLine("There were " + Consonants + " consonants in your sentence");

            Console.ReadKey();

        }
    }
}
