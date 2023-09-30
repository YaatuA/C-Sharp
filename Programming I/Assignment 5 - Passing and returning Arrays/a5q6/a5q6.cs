// 6.	Write a method that creates and return an array of ints. The method takes a single int argument that represents the how many items will be in the resulting array and does the following:
// •	Declare an array of the required type.
// •	Allocate memory for the intended number of items.
// •	Using any looping structure, prompt the user for a number and then assign to each element. 
// •	Return the array after the loop.
// In your main method do the following: 
// (a) call this method (you will need to supply an argument), assign the resulting value to at suitable variable and then 
// (b) display this variable.  //

using System;

namespace question6 {
    class a5q6 {
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

            for (int i = 0; i < arrayLength; i++) { //for loop will add appropriate # of ints to array
                Console.Write($"Enter a number for array position {i}: ");
                numArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            return numArray;
        }
    }
}

