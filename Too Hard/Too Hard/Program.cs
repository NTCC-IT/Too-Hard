using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Too_Hard
{
    internal class Program
    {
        // The Main Function
        static void Main(string[] args)
        {
            // Prompts the User for a phrase to be reversed
            Console.WriteLine("Input a phrase such as rock:");

            // Reads the input and stores
            string input = Console.ReadLine();

            // Tests if the string stored is valid, errors if none
            if (input == null || string.IsNullOrEmpty(input))
            {
                Console.WriteLine("No input given rerun program.");
            };

            // Stores the result of the reversed input
            string result = ReverseString(input);

            // Prints the result to console
            Console.WriteLine(result);
        }
        // Create a function to reverse a string that can be called on in the Main function
        static string ReverseString(string str)
        {
            // Creates an string array
            char[] charArray = str.ToCharArray();

            // Uses the method Reverse to reverse the array
            Array.Reverse(charArray);

            // Return the output or results of the function to the Main()
            return new string(charArray);
        }

    }
}
