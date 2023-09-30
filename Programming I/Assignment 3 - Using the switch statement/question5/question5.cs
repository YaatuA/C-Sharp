// 5.	Write a program for a furniture company. Ask the user to choose Pine, Oak or Mahogany. Show the price of a table manufactured with the chosen wood Pine tables cost $100, Oak tables cost $225, and Mahogany tables cost $310. You must use named constants and switch. Also you must be able to accept any variation on the case. E.g. Pine, pine PINE, pinE, Pine … should give $100. //

using System;

namespace question5 {
    class a3q5 {
        static void Main(string[] args) {
            //Price constants:
            const int pine = 100;
            const int oak = 225;
            const int mahogany = 310;

            //Prompts the user for input
            Console.Write("Type your selection: Pine, Oak, or Mahogany: ");
            String input = Console.ReadLine();
            input = input.ToLower();

            Console.Write("A table manufactured with " + input + " wood costs $");

            switch (input) {
                case "pine":
                    Console.WriteLine(pine);
                    break;
                case "oak":
                    Console.WriteLine(oak);
                    break;
                case "mahogany":
                    Console.WriteLine(mahogany);
                    break;
                default:
                    Console.WriteLine("(No Value Found)");
                    break;
            }
        }   
    } 
}