// 8.	Write a program that prompts a user for an hourly pay rate. If the value entered is less than $5 65 or greater than $49 99, display an error message //

using System;
using System.Globalization;

namespace question8 {
    class a3q8 {
        static void Main(string[] args) {
            //Prompts the user for input
            Console.Write("Enter an hourly pay rate (number values only, do not include $ sign): ");
            double payRate = Convert.ToDouble(Console.ReadLine());

            if (payRate > 5.65 && payRate < 49.99) { //if input is valid, then inputted hourly rate is displayed
                Console.WriteLine($"The hourly pay rate is: {payRate.ToString("C", CultureInfo.CurrentCulture)}/hour");
            } else { //if input is invalid
                Console.WriteLine("ERROR: Invalid hourly payrate.");
            }
        }   
    } 
}