// 9.	Write a program that prompts a user for an hourly pay rate. If the user enters values less than $5.65 or greater than $49 99, prompt the user again. If the user enters an invalid value again, display an appropriate error message. If the user enters a valid value on either the first or second attempt, display the pay rate as well as the weekly rate which calculated as 40 times the hourly rate  //

using System;
using System.Globalization;

namespace question9 {
    class a3q9 {
        static void Main(string[] args) {
            //Prompts the user for input
            Console.Write("Enter an hourly pay rate (number values only, do not include $ sign): ");
            double payRate = Convert.ToDouble(Console.ReadLine());

            if (payRate > 5.65 && payRate < 49.99) { //if input is valid, then inputted hourly rate is displayed
                Console.WriteLine($"The hourly pay rate is: {payRate.ToString("C", CultureInfo.CurrentCulture)}/hour");
                Console.WriteLine($"The weekly pay rate (at 40 hours/week) is: {(payRate * 40).ToString("C", CultureInfo.CurrentCulture)}/week");
            } else { //first input was invalid, so user prompted again for valid input
                Console.WriteLine("Invalid input. Please try again.");
                Console.Write("Enter an hourly pay rate (number values only, do not include $ sign): ");
                payRate = Convert.ToDouble(Console.ReadLine());

                if (payRate > 5.65 && payRate < 49.99) { //if input is valid, then inputted hourly rate is displayed
                    Console.WriteLine($"The hourly pay rate is: {payRate.ToString("C", CultureInfo.CurrentCulture)}/hour");
                    Console.WriteLine($"The weekly pay rate (at 40 hours/week) is: {(payRate * 40).ToString("C", CultureInfo.CurrentCulture)}/week");
                } else { //if input is invalid a second time, error message is displayed
                    Console.WriteLine("ERROR: Invalid hourly payrate.");
                }
            }
        }   
    } 
}