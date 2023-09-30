// 6.	Write a program to calculate the roots of a quadratic equation.  //

using System;
using System.Globalization;

namespace question6 {
    class a3q6 {
        static void Main(string[] args) {
            // Prompts the user for input
            Console.Write("To calculate the roots of the quadratic equation, enter a value for a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter a value for b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter a value for c: ");
            double c = Convert.ToDouble(Console.ReadLine());
            
            //Determines if the a value is valid
            if (a == 0) {
                Console.WriteLine("Invalid input for a.");
            } else { //continues calculations if a is valid
                double p = (b * -1) / (2 * a);
                double d = (b * b) - (4 * a * c);

                if (d >= 0) { //if the roots are real numbers, the following calculations are performed and outputted
                    double q = Math.Sqrt(d)/(2 * a);
                    Console.WriteLine($"The roots of the quadratic equation are about {(p + q).ToString("F", CultureInfo.InvariantCulture)} and {(p - q).ToString("F", CultureInfo.InvariantCulture)}.");
                } else { //if the roots are imaginary numbers, the following calculations are performed and outputted
                    double q = Math.Sqrt(d * -1)/(2 * a);
                    Console.WriteLine($"The roots of the quadratic equation are about {(p + q).ToString("F", CultureInfo.InvariantCulture)}i and {(p - q).ToString("F", CultureInfo.InvariantCulture)}i.");
                }
            }
        }   
    } 
}