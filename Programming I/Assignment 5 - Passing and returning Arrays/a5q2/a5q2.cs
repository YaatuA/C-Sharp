// 2. Write a method that takes an argument (a string array) and print each item on a single line separated by a space. From your main, call this method with poem as argument //

using System;

namespace question2 {
    class a5q2 {
        static void Main(string[] args) {
            char[] letters = "the quick brown fox jumps over the lazy dog".ToCharArray();
            int[] numbers = {0, 2, 3, 5, 7, 1, 1, 2, 5, 6, 7, 2, 5, 2};
            string[] poem = "mary had a little lamb its fleece was white as snow".Split();
            
            poem = singleLinePrint(poem);
        }

        static string[] singleLinePrint (string[] stringArray) {
            foreach(string str in stringArray){
                Console.Write($"{str} ");
            }
            return(stringArray);
        }
    }
}