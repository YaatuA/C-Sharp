// 5. Print the decimal, octal, and hexadecimal values of all characters between the start and stop characters entered by a user. For example, if the user enters an a and a z, the program should print all the characters between a and z and their respective numerical values. Make sure that the second character entered by the user occurs later in the alphabet than the first character. If it does not, write a loop that repeatedly asks the user for a valid second character until one is entered. //

using System;
using System.Globalization;

namespace question5 {
    class a4q5whileloop {
        static void Main(string[] args) {
            //User prompt for first and second characters
            Console.Write("Please enter a character to start with: ");
            char startingChar = Convert.ToChar(Console.ReadLine());
            Console.Write("Please enter a character to stop with: ");
            char endingChar = Convert.ToChar(Console.ReadLine());

            //Converts char to int
            int startingNum = Convert.ToInt32(startingChar);
            int endingNum = Convert.ToInt32(endingChar);

            //Checks to ensure if ending value is greater than starting value
            int check = 0;
            while (check == 0) { //loop will prompt for cx to retry with valid ending char if invalid
                if (endingNum < startingNum) {
                    Console.WriteLine("Invalid second character entered. Please ensure that the second character is a larger value than the first.");
                    Console.Write("Please enter a character to stop with: ");
                    endingChar = Convert.ToChar(Console.ReadLine());
                    endingNum = Convert.ToInt32(endingChar);
                } else {
                    break;
                }

            }

            //Displays Table Header
            Console.WriteLine("{0,10} {1,10} {2,10} {3,10}", "Char", "Decimal", "Octal", "Hex");
            
            //Loop prints table from starting value to ending value
            while (startingChar <= endingChar) {
                Console.WriteLine("{0,10} {1,10} {2,10} {3,10}", startingChar, (Convert.ToInt32(startingChar)), Convert.ToString((Convert.ToInt32(startingChar)), 8), Convert.ToString((Convert.ToInt32(startingChar)), 16));
                startingChar++;
            }
            
        }
    }
}