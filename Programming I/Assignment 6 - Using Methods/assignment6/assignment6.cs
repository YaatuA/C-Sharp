using System;

namespace assignment6 {
    class a6 {
        static void Main(string[] args) {
            int choice = -1;
            int output = 0;
            double average = 0;
            int numOfInputs = 0;

            do {
                DisplayMenu();
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice) {
                    case 3: // From the assignment: You will invoke this method with argument 5 and then display the resulting value from the method
                        output = CalculateSum(5); 
                        Console.WriteLine("The total sum is: " + output + "\n");
                        break;
                    case 4: // From the assignment: you will prompt the user for the number of inputs that she will be working with. You will invoke this method with this value and display the resulting value.
                        Console.Write("Enter the number of inputs: ");
                        numOfInputs = Convert.ToInt32(Console.ReadLine());
                        output = CalculateSumOfSquares(numOfInputs); 
                        Console.WriteLine("The total sum of squares is: " + output + "\n");
                        break;
                    case 5: // From the assignment: you will invoke this method and display the resulting value
                        output = CalculateSumOfCubes(); 
                        Console.WriteLine("The total sum of cubes is: " + output + "\n");
                        break;

                    case 6: // From the assignment: you will invoke this method and display the resulting value
                        average = CalculateAverage(); 
                        Console.WriteLine("The average of all the numbers is: " + average + "\n");
                        break;

                    case 0:
                        Console.WriteLine("Goodbye!");
                        break;
                    
                    default:
                        
                        break;
                    
                }
            } while (choice != 0);
        }

        public static void DisplayMenu(int number, char letter = 'A') { //display the following menu choice on the screen
            Console.WriteLine(number);
        }

        static int CalculateSum(int numOfInputs) { //prompt and accepts inputs (as many as specified by the argument), and sum them, Finally the method will return the sum of all the inputs (the sum)
            int sum = 0;
            int newNum = 0;

            for (int i = 0; i < numOfInputs; i++) {
                Console.Write("Please enter a number to be added to the total sum: ");
                newNum = Convert.ToInt32(Console.ReadLine());
                sum = sum + newNum;
            }
            return sum;
        }

        static int CalculateSumOfSquares(int numOfInputs) { //prompt the user for inputs and accumulates the sum of the squares of the input. This is repeated as specified by the argument. Returns the final sum 
            int sum = 0;
            int newNum = 0;

            for (int i = 0; i < numOfInputs; i++) {
                Console.Write("Please enter a number to be added to the total sum: ");
                newNum = Convert.ToInt32(Console.ReadLine());
                sum = sum + (newNum*newNum);
            }
            return sum;
        }

        static int CalculateSumOfCubes() { // prompt the user for the number of inputs that they will be working with, read in the user input, Prompts the user for their input, Accumulates the sum of the cubes input, Repeat the above two steps are many times as required, Returns the final sum 

            Console.Write("Enter the number of inputs: ");
            int numOfInputs = Convert.ToInt32(Console.ReadLine());

            int sum = 0;
            int newNum = 0;

            for (int i = 0; i < numOfInputs; i++) {
                Console.Write("Please enter a number to be added to the total sum: ");
                newNum = Convert.ToInt32(Console.ReadLine());
                sum = sum + (newNum*newNum*newNum);
            }
            return sum;
        }

        static double CalculateAverage() { //prompt and accept for the number of inputs that she will be working with. Prompts the user for the required number of inputs. Calculate and return the average of the inputs. 
            Console.Write("Enter the number of inputs: ");
            int numOfInputs = Convert.ToInt32(Console.ReadLine());
            double newNum = 0;
            double sum = 0;
            double average = 0;

            for (int i = 0; i < numOfInputs; i++) {
                Console.Write("Please enter a number to be included in the average: ");
                newNum = Convert.ToDouble(Console.ReadLine());
                sum = sum + newNum;
            }

            average = sum / numOfInputs;

            return average;
        }
    }
}

