// 6.	Write a program to compute the (x, y) pairs for the equation y = 2x2 –x  - 6 for x in the range 1 to 5 in 0.5 increments. //

using System;
using System.Globalization;

namespace question6 {
    class a4q6whileloop {
        static void Main(string[] args) {
            //Displays Table Header
            Console.WriteLine("{0,-5} {1,-5} {2,-5} {3,-5} {4,-5}", "x", "2x^2", "-x", "-6", "y");

            //Prints table data based on user input
            double x = 1.0;
            while (x <= 5) {
                Console.WriteLine("{0,-5} {1,-5} {2,-5} {3,-5} {4,-5}", $"{x.ToString("F1", CultureInfo.InvariantCulture)}", $"{(2*x*x).ToString("F1", CultureInfo.InvariantCulture)}", $"{(-x).ToString("F1", CultureInfo.InvariantCulture)}", -6, $"{((2*x*x) - x - 6).ToString("F1", CultureInfo.InvariantCulture)}");
                x = x + 0.5;
            }
        }
    }
}