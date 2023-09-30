// 7.	Write another method that creates and return an array of ints. The method takes a single argument that represents the number of items in the resulting array and does the following:
// •	Declare an array of the required type.
// •	Allocate memory for the intended number of items.
// •	Using any looping structure, assign to each element a random integer in the range 100 to 200. 
// •	Return the array.
// You will need the following statement in global scope.
// static Random rand = new Random();
// The following statement will give you a random letter
// rand.Next(100, 200);
// Exercise this method in a similar fashion as you did for question 6 . //

using System;

namespace question7 {
    class a5q7 {
        static void Main(string[] args) {
            char[] letters = "the quick brown fox jumps over the lazy dog".ToCharArray();
            int[] numbers = {0, 2, 3, 5, 7, 1, 1, 2, 5, 6, 7, 2, 5, 2};
            string[] poem = "mary had a little lamb its fleece was white as snow".Split();
            
            //Prompts user for length of the array to be created
            Console.Write($"Enter the length of the array: ");
            int length = Convert.ToInt32(Console.ReadLine());

            //calls method to create array
            int[] numArray = createIntArray(length);
            
            //displays array
            Console.Write($"The resulting array is: ");
            foreach(int i in numArray) {
                Console.Write($"{i} ");
            }

        }

        static int[] createIntArray (int arrayLength) {
            int[] numArray = new int[arrayLength];
            Random rand = new Random();

            for (int i = 0; i < arrayLength; i++) { // for loop will add appropriate # of ints to array
                numArray[i] = rand.Next(100, 200);
            }

            return numArray;
        }
    }
}

