// 3. Write a program to calculate the area of a circle. The user will enter the radius of the circle and the program will calculate and display the area according to the formula (area = 3.14 * radius * radius). You must accept fractions as the input. If the user enters 1.2 for the radius then the area will be 4.52. (Use the "F" format-specifier for floating point values). //

using System;
using System.Globalization;

namespace a2q3 {
    class question3 {
        static void Main(string[] args) {
            Console.WriteLine($"Enter the radius of a circle to calculate the area. If using a fraction instead of a decimal value, use / to denote the fraction and add a single space to denote a mixed fraction: ");
            string input = Console.ReadLine();
            string fractionString = "";
            string wholeNum = "";
            string numerator = "";
            string denominator = "";
            double radius = 0;
            double wholeNumDouble = 0;
            double area = 0;


            // This section checks to see if input is a fraction, and if it is, it converts it to a double. If it is not, it converts the original input to a double without conversions. //
            int isFraction = input.IndexOf('/');
            if (isFraction != -1) { 
                fractionString = input;
                // Checks to see if fraction is a mix with a whole number and isolates the whole number //
                int isMixed = input.IndexOf(' ');
                if (isMixed != -1) {
                    wholeNum = input.Substring(0,isMixed);
                    wholeNumDouble = Convert.ToDouble(wholeNum); // converts the 
                     fractionString = input.Substring(isMixed + 1);
                }
                isFraction = fractionString.IndexOf('/');
                // Separates the numerator from the denominator in order to divide the two and create a usable double //
                numerator = fractionString.Substring(0, isFraction);
                denominator = fractionString.Substring(isFraction + 1);
                radius = wholeNumDouble + (Convert.ToDouble(numerator))/(Convert.ToDouble(denominator));
            } else { // if the value is a decimal, it converts it directly to a double // 
                radius = Convert.ToDouble(input);
            }

            // Area calculation //
            area = 3.14 * radius * radius;

            // Final statement //
            Console.WriteLine($"The area of a circle with the radius {input} is {area.ToString("F", CultureInfo.InvariantCulture)}.");
        }
    }
}