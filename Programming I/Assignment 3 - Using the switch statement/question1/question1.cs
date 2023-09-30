// 1.	Write a program that prompts the user for a menu choice. The program will display a message based on the following table: 1=Calculate Area, 2=Calculate volume, 3=Calculate surface area, 0=Exit program, other input=ERROR: Invalid choice //

using System;

namespace question1 {
    class a3q1 {
        static void Main(string[] args) {
            //Program menu:
            Console.WriteLine("Program Menu:");
            Console.WriteLine("1: Calculate area");
            Console.WriteLine("2: Calculate volume");
            Console.WriteLine("3: Calculate surface area");
            Console.WriteLine("0: Exit the program");
            Console.Write("Select an option from the menu by entering a value from 0-3: ");
            
            //Accepts user input
            int input = Convert.ToInt32(Console.ReadLine());

            // Determines what to do based on user input
            if (input == 1) { // when the user inputs 1
                Console.WriteLine("Calculate area");
            } else if (input == 2) { // when the user inputs 2
                Console.WriteLine("Calulate volume");
            } else if (input == 3) { // when the user inputs 3
                Console.WriteLine("Calculate surface area");
            } else if (input == 0) { // when the user inputs 0
                Console.WriteLine("Goodbye!");
            } else { // when the user inputs anything else
                Console.WriteLine("ERROR: Invalid Choice");
            } 
        }
    } 
}