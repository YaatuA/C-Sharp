// 2.	Write a program that allows the user to enter two integers and a character If the character is A, add the two integers If it is S, subtract the second integer from the first else multiply the integers Display the results of the arithmetic//

using System;

namespace question2 {
    class a3q2 {
        static void Main(string[] args) {
            //Prompts the user for input and collects appropriate values
            Console.Write("Enter the first integer: ");
            int input1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second integer: ");
            int input2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a character for the arithmetic to be performed (a for addition, s for subtraction, any other character for multiplication): ");
            char charChoice = Convert.ToChar(Console.ReadLine());

            int answer;

            // Determines what to do based on user input
            if (char.ToLower(charChoice) == 'a') { // when the user inputs a or A
                answer = input1 + input2;
                Console.WriteLine(input1 + " + " + input2 + " = " + answer);
            } else if (char.ToLower(charChoice) == 's') { // when the user inputs s or S
                answer = input1 - input2;
                Console.WriteLine(input1 + " - " + input2 + " = " + answer);
            } else { // when the user inputs anything else
                answer = input1 * input2;
                Console.WriteLine(input1 + " * " + input2 + " = " + answer);
            } 
        }
    } 
}