// 1.	Write a program to prompt the user to enter a single character. The program should display a message like “Your response was y”. For this question, you must use a variable of type char. //

using System;

namespace a2q1 {
    class question1 {
        static void Main(string[] args) {
            Console.WriteLine($"Enter a single character: ");
            char input = Convert.ToChar(Console.ReadLine()); // Directly converts input to char
            Console.WriteLine($"Your response was {input}.");
        }
    }
}