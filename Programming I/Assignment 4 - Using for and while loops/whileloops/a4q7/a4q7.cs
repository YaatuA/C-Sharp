//7.	Write a program to reverse the digits of a positive integer number. For example, if the number 8735 is entered, the number displayed should be 5378. (Hint: Use a do statement and continuously strip off and display the units digit of the number. If the variable num initially contains the number entered, the units digit is obtained as (num % 10). After a units digit is displayed, dividing the number by 10 sets up the number for the next iteration. Thus, (8735 % 10) is5and (8735 / 10) is 873. The do statement should continue as long as the remaining number is not zero).//

using System;
using System.Globalization;

namespace question7 {
    class a4q7whileloop {
        static void Main(string[] args) {
            //Prompts the user for input
            Console.Write("Please enter a positive integer to be reversed (greater than zero): ");
            int userNum = Convert.ToInt32(Console.ReadLine());

            //Checks that number is positive integer and prompts the user for correct input up to 1000 attempts
            int check = 0;
            while (check == 0) {
                if (userNum > 0) {
                    break;
                } else {
                    Console.WriteLine("Invalid input. Please try again.");
                    Console.Write("Please enter a positive integer to be reversed (greater than zero): ");
                    userNum = Convert.ToInt32(Console.ReadLine());
                }
            }

            int numOfDigits = (Convert.ToString(userNum).Length); //gathers number of digits to determine how many times to run for loop

            do { //loop displays the number in reverse one digit at a time
                Console.Write((userNum % 10));
                userNum = userNum / 10;
            } while (userNum > 0);

            Console.WriteLine(""); //creates new line after final number is displayed (used for formatting)
        }
    }
}