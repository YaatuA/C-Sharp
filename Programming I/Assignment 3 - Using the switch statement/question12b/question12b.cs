// b.	To the Lawn application you created in Exercise 12a, add a prompt that asks the user whether the customer wants to pay (1) once, (2) twice, or (3) 20 times per year. If the user enters 1 for once, the fee for the season is simply the seasonal total. If the customer requests two payments, each payment is half the seasonal fee plus a $5 service charge. If the user requests 20 separate payments, add a $3 service charge per week. Display the number of payments the customer must make, each payment amount, and the total for the season 
//

using System;
using System.Globalization;

namespace question12b {
    class a3q12b {
        static void Main(string[] args) {
            //Prompts the user for input
            Console.Write("Enter the length of the lawn: ");
            double length = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the width of the lawn: ");
            double width = Convert.ToDouble(Console.ReadLine());

            //Calculates the area of the lawn
            double area = length * width;

            //Calculates pricing based on square feet of lawn
            double sqftPrice = 0;
            if (area >= 600) {
                sqftPrice = 50;
            } else if (area < 600 && area >= 400) {
                sqftPrice = 35;
            } else {
                sqftPrice = 25;
            } 

            //Cost output
            Console.WriteLine($"For a lawn with an area of {area.ToString("F", CultureInfo.InvariantCulture)} square feet, the cost per week is {sqftPrice.ToString("C", CultureInfo.CurrentCulture)}, and the total fee for a 20-week season is {(sqftPrice * 20).ToString("C", CultureInfo.CurrentCulture)}.");

            Console.WriteLine("\nHere are your payment options:");
            Console.WriteLine($"1. Pay the entire amount of {(sqftPrice * 20).ToString("C", CultureInfo.CurrentCulture)} once per year");
            Console.WriteLine($"2. Pay in two installments of {(sqftPrice * 10).ToString("C", CultureInfo.CurrentCulture)} per year ($5 service charge applies per payment)");
            Console.WriteLine($"3. Pay in 20 installments of {sqftPrice.ToString("C", CultureInfo.CurrentCulture)} per year ($3 service charge applies per payment)");

            Console.Write("\nHow many payments would you like to make: ");
            int paymentSchedule = Convert.ToInt32(Console.ReadLine());
            double paymentAmount = 0;

            int stop = 0;
            while (stop == 0) {
                if (paymentSchedule == 1 || paymentSchedule == 2 || paymentSchedule == 20) { 
                Console.WriteLine("\nPayment Summary:");
                Console.WriteLine($"Number of payments: {paymentSchedule.ToString("F", CultureInfo.InvariantCulture)}");
                if (paymentSchedule == 2) {
                    paymentAmount = (sqftPrice * 10) + 5;
                } else if (paymentSchedule == 20) {
                    paymentAmount = sqftPrice + 3;
                } else if (paymentSchedule == 1) {
                    paymentAmount = sqftPrice * 20;
                }
                Console.WriteLine($"Each payment amount: {paymentAmount.ToString("C", CultureInfo.CurrentCulture)}");
                Console.WriteLine($"Total for the season: {(paymentAmount * paymentSchedule).ToString("C", CultureInfo.CurrentCulture)}");
                stop++;
                } else {
                    Console.WriteLine("\nInvalid payment schedule amount. Please try again or enter 0 to quit.");
                    Console.Write("\nHow many payments would you like to make: ");
                    paymentSchedule = Convert.ToInt32(Console.ReadLine());
                    if (paymentAmount == 0) {
                        stop++;
                    }
                }
            }

            
        }   
    } 
}