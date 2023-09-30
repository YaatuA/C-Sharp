// 4.	Write a program that prompts the user for a day of the week. The program will display a message based on the following table:
// Choice	Message
//Sun	"Home"
//Mon	"Work"
//Tue	"Work"
//Wed	"Home"
//Thu	"Work"
//Fri	"Work"
//Sat	"Work"
//

using System;

namespace question4 {
    class a3q4 {
        static void Main(string[] args) {
            // Prompts the user for input
            Console.Write("Enter a day of the week: ");
            String input = Console.ReadLine();
            input = input.ToLower(); //makes the user input all lowercase to be processed by next statements easier

            // contains function is used in the event that entire word is spelled out or longer shorthand is used; ie. Tuesday can be written as Tue, Tues, or Tuesday in uppercase or lowercase and still be accepted by program
            if (input.Contains("sun")) {
                Console.WriteLine("Home");
            } else if (input.Contains("mon")) {
                Console.WriteLine("Work");
            } else if (input.Contains("tue")) {
                Console.WriteLine("Work");
            } else if (input.Contains("wed")) {
                Console.WriteLine("Home");
            } else if (input.Contains("thu")) {
                Console.WriteLine("Work");
            } else if (input.Contains("fri")) {
                Console.WriteLine("Work");
            } else if (input.Contains("sat")) {
                Console.WriteLine("Work");
            } else { // in the event that an invalid input is entered
                Console.WriteLine("Invalid Entry");
            }
        }   
    } 
}