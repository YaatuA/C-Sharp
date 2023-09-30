// 2. Write a program to ask the user about the validity of a simple statement. The program should accept the response then display the statement as well as the response. The response should be true or false. For this question, you must use a variable of type bool. It is useful to know that Convert.ToBoolean() can work with true, True, tRue, TRUE etc //

using System;

namespace a2q2 {
    class question2 {
        static void Main(string[] args) {
            Console.WriteLine($"Answer true or false to the following statement: The CN Tower is in Toronto ");

            // Directly converts input to boolean response //
            bool input = Convert.ToBoolean(Console.ReadLine());
            bool answer = true;
            Console.WriteLine($"Your response was: {input}");

            // Answer is dependent on whether the answer to the statement was correct //
            if (input == answer) {
                Console.WriteLine($"The CN Tower is in Toronto, so your response was correct.");
            } else {
                Console.WriteLine($"The CN Tower is in Toronto, so your response was incorrect.");
            }
        }
    }
}