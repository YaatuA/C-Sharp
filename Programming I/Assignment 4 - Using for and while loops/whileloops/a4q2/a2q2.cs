// 2.	Write a program that displays a conversion table from Fahrenheit to Celsius. The program must request the starting Fahrenheit value, the ending Fahrenheit value, and the increment. Thus, instead of the condition checking for a fixed count, the condition checks for the ending Fahrenheit value. Your table must look professional! //

using System;
using System.Globalization;

namespace question2 {
    class a4q2whileloop {
        static void Main(string[] args) {
            //Gathering user input for table data
            Console.Write("Please enter a starting Farenheit value: ");
            double startingFarenheit = Convert.ToDouble(Console.ReadLine());

            Console.Write("Please enter an ending Farenheit value: ");
            double endingFarenheit = Convert.ToDouble(Console.ReadLine());

            Console.Write("Please enter the increment between values to output: ");
            double increment = Convert.ToDouble(Console.ReadLine());

            //Displays Table Header
            Console.WriteLine("{0,-12} {1,-12}", "Farenheit", "Celsius");

            //Prints table data based on user input
            while (startingFarenheit <= endingFarenheit) {
                Console.WriteLine("{0,-12} {1,-12}", $"{startingFarenheit.ToString("F", CultureInfo.InvariantCulture)}", $"{((startingFarenheit - 32)/ 1.8).ToString("F", CultureInfo.InvariantCulture)}");
                startingFarenheit = startingFarenheit + increment;
            }
        }
    }
}