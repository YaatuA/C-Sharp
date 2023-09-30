// 11.	Write a program that prompts the user for an hourly pay rate and hours worked. Compute gross pay (hours times pay rate), withholding tax, and net pay (gross pay minus withholding tax) Withholding tax is computed as a percentage of gross pay based on the following
//Gross Pay                     Withholding Percentage 
//Up to and including 300.00    10% 
//300.01 and up                 12% 
//

using System;
using System.Globalization;

namespace question11 {
    class a3q11 {
        static void Main(string[] args) {
            //Prompts the user for input
            Console.Write("Enter your hourly pay rate (numerical values only please): ");
            double payRate = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the hours worked: ");
            double hoursWorked = Convert.ToDouble(Console.ReadLine());

            double grossPay = payRate * hoursWorked;
            double withholdingTax;
            if (grossPay >= 300) { //tax is dependent on gross pay, so this if/else statement reflects that
                withholdingTax = 0.12 * grossPay;
            } else {
                withholdingTax = 0.10 * grossPay;
            }
            double netPay = grossPay - withholdingTax;

            //Outputted statements with gross pay, taxes paid, and net pay
            Console.WriteLine($"The hourly pay rate is: {payRate.ToString("C", CultureInfo.CurrentCulture)}/hour");
            Console.WriteLine($"The hours worked are: {hoursWorked.ToString("F", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"The gross pay is: {grossPay.ToString("C", CultureInfo.CurrentCulture)}");
            Console.WriteLine($"The total taxes paid are: {withholdingTax.ToString("C", CultureInfo.CurrentCulture)}");
            Console.WriteLine($"The net pay is therefore: {netPay.ToString("C", CultureInfo.CurrentCulture)}");
        }   
    } 
}