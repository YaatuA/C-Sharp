// 1.	Write a program to produce a table of numbers from 10 to 1, with their squares and cubes. Again, your table must look professional! //

using System;

namespace question1 {
    class a4q1whileloop {
        static void Main(string[] args) {
            //Prints header of Table
            Console.WriteLine("{0,-10} {1,-10} {2,-10}", "Number", "Square", "Cube");

            int i = 0;
            while (i <= 10) { //While loop prints numbers with their squares and cubes between 1-10
                Console.WriteLine("{0,-10} {1,-10} {2,-10}", (i), (i*i), (i*i*i));
                i = i + 1;
            }
        }
    }
}