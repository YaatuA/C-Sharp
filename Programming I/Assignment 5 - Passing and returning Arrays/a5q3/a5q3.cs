// 3. In your main method use the method in question 1 to display the letters array, then use the Array.Reverse() method to reverse the letters array and then again call the appropriate method to print it //

using System;

namespace question3 {
    class a5q3 {
        static void Main(string[] args) {
            char[] letters = "the quick brown fox jumps over the lazy dog".ToCharArray();
            int[] numbers = {0, 2, 3, 5, 7, 1, 1, 2, 5, 6, 7, 2, 5, 2};
            string[] poem = "mary had a little lamb its fleece was white as snow".Split();
            
            letters = singleLinePrint(letters);
            Array.Reverse(letters);
            Console.WriteLine(""); //creates line break between original array and reversed array
            letters = singleLinePrint(letters);
        }

        static char[] singleLinePrint (char[] charArray) {
            foreach(char ch in charArray){
                Console.Write($"{ch}");
            }
            return(charArray);
        }
    }
}