using System;
using System.Linq;

namespace CodingChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is a Palindrome checker");
            Console.WriteLine("");
            Console.WriteLine("A palindrome is a word or phrase that is identical if read from");
            Console.WriteLine("left to right or right to left");
            Console.WriteLine("");
            Console.WriteLine("Please input a line to check");
            string input = Console.ReadLine();

            validatePalin(input);

            Console.ReadLine();
        }
        static void validatePalin(string input)
        {
            input.Trim();
            char[] inputOrginalArray = input.ToCharArray();
            char[] inputInverse = input.ToCharArray(); 
            Array.Reverse(inputInverse);
            Console.WriteLine("");
            Console.WriteLine(inputOrginalArray);
            Console.WriteLine(inputInverse);
            Console.WriteLine("");
            if(inputOrginalArray.SequenceEqual(inputInverse))
            {
                Console.WriteLine("The input ", inputOrginalArray , " is a Palindrome");
            }
            else
            {
                Console.WriteLine("The input " + " is NOT a Palindrome");
            }
        }
    }
}
