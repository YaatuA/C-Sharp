// Write a C program that continuously requests a grade. If the grade is less than 0 or greater than 100, your program should print an appropriate message informing the user that an invalid grade has been entered, else the grade should be added to a total. If the grade is 999, the program should exit the loop and display the sum, number of valid grades and the average of the valid grades entered. (You must NOT display an invalid message) P.S. The value 999 is use to terminate the cycle and should not be used in any of the calculation. You must not display an “Invalid grade” //

using System;
using System.Globalization;

namespace question4 {
    class a4q4whileloop {
        static void Main(string[] args) {
            double gradeSum = 0;
            double numOfGrades = 0;
            double currentGrade;
            //Loop for input
            int check = 0;
            while (check == 0) { //Valid grades will be added to sum, and loop will break if 999 is entered
                Console.Write("Please enter a grade between 0 and 100: ");
                currentGrade = Convert.ToDouble(Console.ReadLine());
                if (currentGrade == 999) {
                    break;
                } else if (currentGrade > 100 || currentGrade < 0) {
                    Console.WriteLine("Invalid grade entered. Please try again.");
                    continue;
                } else {
                    gradeSum = gradeSum + currentGrade;
                    numOfGrades = numOfGrades + 1;
                }
            }

            //Prints data
            Console.WriteLine("{0,-15} {1,-15} {2,-15}", "Sum of Grades", "# of Grades", "Grade Average");
            Console.WriteLine("{0,-15} {1,-15} {2,-15}", $"{gradeSum.ToString("F", CultureInfo.InvariantCulture)}", $"{numOfGrades.ToString("F", CultureInfo.InvariantCulture)}", $"{(gradeSum/numOfGrades).ToString("F", CultureInfo.InvariantCulture)}");
            
        }
    }
}