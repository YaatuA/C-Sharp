// 10.	Write a program for a college’s admissions office. The user enters a numeric high school grade point average (for example, 3 2) and an admission test score. Print the message “Accept” if the student meets either of the following requirements : A grade point average of 3.0 or higher and an admission test score of at least 60 ; A grade point average of less than 3.0 and an admission test score of at least 80 ; If the student does not meet either of the qualification criteria, print ‘Reject” //

using System;

namespace question10 {
    class a3q10 {
        static void Main(string[] args) {
            //Prompts the user for input
            Console.WriteLine("Welcome to the college admissions office. Please enter the following information to determine admission.");
            Console.Write("Enter your high school grade point average: ");
            double gradeAverage = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter your admission test score: ");
            double testScore = Convert.ToDouble(Console.ReadLine());

            if (gradeAverage >= 3.0 && testScore >= 60){ //Determines admission based on the first set of requirements
                Console.WriteLine("Accept");
            } else if (gradeAverage < 3.0 && testScore >= 80) { //Determines admission based on the second set of requirements
                Console.WriteLine("Accept");
            } else { //If above requirements are not met, then the student is rejected
                Console.WriteLine("Reject");
            }
        }   
    } 
}