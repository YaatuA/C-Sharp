// a.	Write an application for a lawn-mowing service. The lawn-mowing season lasts 20 weeks. The weekly fee for mowing a lot under 400 square feet is $25. The fee for a lot that is 400 square feet or more, but under 600 square feet, is $35 per week. The fee for a lot that is 600 square feet or over is $50 per week. Prompt the user for the length and width of a lawn, and then print the weekly mowing fee, as well as the total fee for the 20-week season
//

using System;
using System.Globalization;

namespace question12a {
    class a3q12a {
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

            //Output
            Console.WriteLine($"For a lawn with an area of {area.ToString("F", CultureInfo.InvariantCulture)} square feet, the cost per week is {sqftPrice.ToString("C", CultureInfo.CurrentCulture)}, and the total fee for a 20-week season is {(sqftPrice * 20).ToString("C", CultureInfo.CurrentCulture)}.");
        }   
    } 
}