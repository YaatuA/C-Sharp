The assignment did not specify whether or not the program should loop until the user selected 0 to exit, so the program does not currently loop. A simple solution would be to add a while loop so that the code would look like:

int exit = 1;

while (exit > 0) {
            Console.WriteLine("Program Menu:");
            Console.WriteLine("1: Calculate area");
            Console.WriteLine("2: Calculate volume");
            Console.WriteLine("3: Calculate surface area");
            Console.WriteLine("0: Exit the program");
            Console.Write("Select an option from the menu by entering a value from 0-3: ");
            
            int input = Convert.ToInt32(Console.ReadLine());

            if (input == 1) {
                Console.WriteLine("Calculate area");
            } else if (input == 2) {
                Console.WriteLine("Calulate volume");
            } else if (input == 3) {
                Console.WriteLine("Calculate surface area");
            } else if (input == 0) {
                Console.WriteLine("Goodbye!");
		exit = 0;
            } else {
                Console.WriteLine("ERROR: Invalid Choice");
            } 
}  



