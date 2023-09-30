// 5.	In your main method use the method in question 2 to display the numbers array, then use the Array.Binarysearch() method to try to find the position of 3 in the numbers array. What is your answer? Now repeat the same steps after you have sorted the array and printed the sorted array //

using System;

namespace question5 {
    class a5q5 {
        static void Main(string[] args) {
            char[] letters = "the quick brown fox jumps over the lazy dog".ToCharArray();
            int[] numbers = {0, 2, 3, 5, 7, 1, 1, 2, 5, 6, 7, 2, 5, 2};
            string[] poem = "mary had a little lamb its fleece was white as snow".Split();
            
            numbers = singleLinePrint(numbers);
            Console.WriteLine(""); //creates line break between original array and reversed array
            Console.WriteLine($"Position of 3: {Array.BinarySearch(numbers, 3)}"); //displays incorrect number (negative value) as values are not sorted
            Array.Sort(numbers);
            numbers = singleLinePrint(numbers);
            Console.WriteLine(""); //creates line break between original array and reversed array
            Console.WriteLine($"Position of 3: {Array.BinarySearch(numbers, 3)}");

        }

        static int[] singleLinePrint (int[] numArray) {
            foreach(int i in numArray){
                Console.Write($"{i} ");
            }
            return(numArray);
        }
    }
}

