// 3.	Write and run a C# program that calculates and displays the amount of money available in a bank account that initially has $1,000 deposited in it and that earns 8 percent interest a year. Your program should display the amount available at the end of each year for a period of ten years. Use the relationship that the money available at the end of each year equals the amount of money in the account at the start of the year plus .08 times the amount available at the start of the year. //

using System;
using System.Globalization;

namespace question3 {
    class a4q3whileloop {
        static void Main(string[] args) {
            //Displays Table Header
            Console.WriteLine("{0,-5} {1,-10}", "Year", "Balance");
            double balance = 1000;

            //Prints table data based on user input
            int i = 0;
            while (i <= 10) {
                Console.WriteLine("{0,-5} {1,-10}", (i) , $"{balance.ToString("C", CultureInfo.CurrentCulture)}");
                balance = balance * 1.08;
                i = i + 1;
            }
        }
    }
}