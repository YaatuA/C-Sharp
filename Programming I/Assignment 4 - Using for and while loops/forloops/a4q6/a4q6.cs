// 6.	Write a program to compute the (x, y) pairs for the equation y = 2x2 –x  - 6 for x in the range 1 to 5 in 0.5 increments. //

using System;
using System.Globalization;

namespace question6 {
    class a4q6forloop {
        static void Main(string[] args) {
            //Displays Table Header
            Console.WriteLine("{0,-5} {1,-5} {2,-5} {3,-5} {4,-5}", "x", "2x^2", "-x", "-6", "y");

            //Prints table data based on user input
            for (double i = 1; i <= 5; i = i + 0.5) {
                Console.WriteLine("{0,-5} {1,-5} {2,-5} {3,-5} {4,-5}", $"{i.ToString("F1", CultureInfo.InvariantCulture)}", $"{(2*i*i).ToString("F1", CultureInfo.InvariantCulture)}", $"{(-i).ToString("F1", CultureInfo.InvariantCulture)}", -6, $"{((2*i*i) - i - 6).ToString("F1", CultureInfo.InvariantCulture)}");
            }
        }
    }
}