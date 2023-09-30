// 4. Write a program that prompts the user for a number (that may be a fraction). The program reads in the input and print the following: the input as a double, the input as an int and finally the input as a char. e.g. if the input is 65.790, then the output will be 65.790, 65, and A. //

using System;

namespace a2q4 {
    class question4 {
        static void Main(string[] args) {
            Console.WriteLine($"Enter any number. If using a fraction instead of a decimal value, use / to denote the fraction and add a single space to denote a mixed fraction: ");
            string input = Console.ReadLine();
            string fractionString = "";
            string wholeNum = "";
            string numerator = "";
            string denominator = "";
            double valueDouble = 0;
            double wholeNumDouble = 0;

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
                valueDouble = wholeNumDouble + (Convert.ToDouble(numerator))/(Convert.ToDouble(denominator));
            } else { // if the value is a decimal, it converts it directly to a double // 
                valueDouble = Convert.ToDouble(input);
            }

            // This converts the double to an int and char //
            int valueInt = (int)valueDouble;

            // Program would not run when using whole string or double value, so first character was used instead //
            char valueChar = Convert.ToChar(input.ElementAt(0));

            // Final response //
            Console.WriteLine($"If the input is {input}, then the output will be {valueDouble} as a double, {valueInt} as an int, and {valueChar} as a char.");
        }
    }
}