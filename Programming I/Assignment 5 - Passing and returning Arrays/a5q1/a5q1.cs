// 1. Write a method that takes an argument (an int array) and print each item on a single line separated by a space. From your main, call this method with numbers as argument //

using System;

namespace question1 {
    class a5q1 {
        static void Main(string[] args) {
            char[] letters = "the quick brown fox jumps over the lazy dog".ToCharArray();
            int[] numbers = {0, 2, 3, 5, 7, 1, 1, 2, 5, 6, 7, 2, 5, 2};
            string[] poem = "mary had a little lamb its fleece was white as snow".Split();
            
            numbers = singleLinePrint(numbers);
        }

        static int[] singleLinePrint (int[] numArray) {
            foreach(int i in numArray){
                Console.Write($"{i} ");
            }
            return(numArray);
        }
    }
}