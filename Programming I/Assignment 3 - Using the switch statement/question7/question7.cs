// 7.	Write a program that prompts the user or an hourly pay rate. If the value entered is less than $5 65, display an error message//

using System;
using System.Globalization;

namespace question7 {
    class a3q7 {
        static void Main(string[] args) {
            //Prompts the user for input
            Console.Write("Enter an hourly pay rate (number values only, do not include $ sign): ");
            double payRate = Convert.ToDouble(Console.ReadLine());

            if (payRate > 5.65) { //if input is valid, then inputted hourly rate is displayed
                Console.WriteLine($"The hourly pay rate is: {payRate.ToString("C", CultureInfo.CurrentCulture)}/hour");
            } else { //if input is invalid
                Console.WriteLine("ERROR: Invalid hourly payrate.");
            }
        }   
    } 
}