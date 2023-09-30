// 5. Adult ticket cost $3.75 and child ticket cost $2.25. Write a program to prompt the user for the amount of adult and child ticket that she needs. The program will display a user-friendly message of the number of tickets brought as well as the total cost. (Use the "C" format-string for currency). //

using System;
using System.Globalization;

namespace a2q5 {
    class question5 {
        static void Main(string[] args) {
            Console.WriteLine($"How many adult tickets do you need? : ");
            int adultTickets = Convert.ToInt32(Console.ReadLine()); // Directly converts input to int
            Console.WriteLine($"How many child tickets do you need? : ");
            int childTickets = Convert.ToInt32(Console.ReadLine()); // Directly converts second input to int

            // Calculates the cost of the child and adult tickets separately, and then the final total //
            double childPrice = childTickets * 2.25;
            double adultPrice = adultTickets * 3.75;
            double totalPrice = childPrice + adultPrice;

            // Final receipt to customer //
            Console.WriteLine($"\nHere is your order:");
            Console.WriteLine($"Number of adult tickets: {adultTickets}");
            Console.WriteLine($"Number of child tickets: {childTickets}");
            Console.WriteLine($"\nHere is your total:");
            Console.WriteLine($"Cost of adult tickets: {adultPrice.ToString("C", CultureInfo.CurrentCulture)}");
            Console.WriteLine($"Cost of child tickets: {childPrice.ToString("C", CultureInfo.CurrentCulture)}");
            Console.WriteLine($"Total cost: {totalPrice.ToString("C", CultureInfo.CurrentCulture)}");
        }
    }
}