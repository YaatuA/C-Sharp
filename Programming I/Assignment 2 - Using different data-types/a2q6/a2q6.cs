// 6. Write a program to calculate and display the potential difference between the ends of a wire. The program will prompt the user for the current flowing and the resistance of the wire. Potential difference is the product of the current and the resistance of the wire and may include a fractional part. (Again, use the "F" format-specifier for floating point values).//

using System;
using System.Globalization;

namespace a2q6 {
    class question6 {
        static void Main(string[] args) {
            Console.WriteLine($"Enter the current flowing through the wire: ");
            double wireCurrent = Convert.ToDouble(Console.ReadLine()); // Directly converts input to double
            Console.WriteLine($"Enter the resistance of the wire: ");
            double wireResistance = Convert.ToDouble(Console.ReadLine()); // Directly converts input to double

            // Calculates the potential difference between the ends of the wire //
            double potentialDifference = wireCurrent * wireResistance;

            // Final response //
            Console.WriteLine($"The potential difference between the ends of a wire with a current of {wireCurrent.ToString("F", CultureInfo.InvariantCulture)} flowing through it and a resistance of {wireResistance.ToString("F", CultureInfo.InvariantCulture)} is approximately {potentialDifference.ToString("F", CultureInfo.InvariantCulture)}.");
        }
    }
}