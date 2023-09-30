// 4.	In your main method use the method in question 3 to display the poem array, then use the Array.Sort() method to sort the poem array and then again call the appropriate method to print it //

using System;

namespace question4 {
    class a5q4 {
        static void Main(string[] args) {
            char[] letters = "the quick brown fox jumps over the lazy dog".ToCharArray();
            int[] numbers = {0, 2, 3, 5, 7, 1, 1, 2, 5, 6, 7, 2, 5, 2};
            string[] poem = "mary had a little lamb its fleece was white as snow".Split();
            
            poem = singleLinePrint(poem);
            Array.Sort(poem);
            Console.WriteLine(""); //creates line break between original array and reversed array
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