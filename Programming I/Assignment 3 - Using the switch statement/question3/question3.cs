// 3.	Write a program that prompts the user for the number of courses and residency status (domestic or international) and calculates tuition cost. Cost is calculated based on the table below. Domestic = $325 per course; International = $1375 per course; You decide how you want the user to enter her/his residency status and prompt accordingly, also you should use named constants for the cost per course//

using System;

namespace question3 {
    class a3q3 {
        static void Main(string[] args) {
            // Constants for course costs
            const int domesticCost = 325;
            const int internationalCost = 1375;

            // Prompts the user for input
            Console.Write("To calculate the cost of your tuition, how many courses are you taking? : ");
            int courseInput = Convert.ToInt32(Console.ReadLine());
            Console.Write("Are you an international student or a domestic student? Enter I for international or D for domestic: ");
            char studentStatus = Convert.ToChar(Console.ReadLine());

            int tuitionCost; // int value for final cost

            if (char.ToLower(studentStatus) == 'd') { //calculates tuition costs for domestic students
                tuitionCost = courseInput * domesticCost;
                Console.WriteLine("For a domestic student taking " + courseInput + " course(s), the total tuition cost is $" + tuitionCost);
            } else if (char.ToLower(studentStatus) == 'i'){ //calculates tuition costs for domestic students
                tuitionCost = courseInput * internationalCost;
                Console.WriteLine("For an international student taking " + courseInput + " course(s), the total tuition cost is $" + tuitionCost);
            } else { // in the event that the program cannot detect a correct char input
                Console.WriteLine("Sorry, something went wrong. Please try again later.");
            }
        }   
    } 
}