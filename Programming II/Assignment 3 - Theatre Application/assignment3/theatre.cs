// Completed by Yaatu Adem, COMP123//

using System;

namespace assignment3 {
    public partial class Theatre {
        private List<Show> Shows = new List<Show>();
        public string Name { get; }

        public Theatre (string name) {
            // This is the public constructor that takes the name of the theater. This constructor does the following:
                // a. Assigns the argument to the appropriate property.
                // b. Initialize the Shows property to a new list of show
            Name = name;
        }

        public void AddShow (Show show) {
            // This public method takes a show object and adds it to the collection of shows.
            Shows.Add(show);
        }

        // All of the following overloaded methods below will display the following:
            // • Name of the theater.
            // • The value of the filter, the first method has no filter, so instead display "All shows".
            // • A numbered list of the movies displayed.

        public void PrintShows() {
            // This public method does not take any argument neither does it return a value. It displays all the shows that is available in the shows collection.
            Console.WriteLine("\nAll Shows Playing at " + Name + " Theatre:");
            
            for (int i = 0; i < Shows.Count; i++) {
                Console.WriteLine((i+1) + ". " + Shows[i]);
            }
            Console.WriteLine("\n");
        }

        public void PrintShows(Genre genre) {
            // This public method takes a genre as an argument and display all the shows that contains the flag of this genre. Use the instance method HasFlags().
            Console.WriteLine("\nAll Shows Playing at " + Name + " Theatre from the Genre(s) " + (string.Join(", ", genre)) + ":");

            int count = 1;
            for (int i = 0; i < Shows.Count; i++) {
                if (Shows[i].Movie.Genre.HasFlag(genre)) {
                    Console.WriteLine(count + ". " + Shows[i]);
                    count++;
                }
            }
            Console.WriteLine("\n");
        }

        public void PrintShows(Day day) {
            // This public method takes a day object as an argument and display all the shows matching this day object.
            Console.WriteLine("\nAll Shows Playing at " + Name + " Theatre Playing on " + day + ":");

            int count = 1;
            for (int i = 0; i < Shows.Count; i++) {
                if (Shows[i].Day == day) {
                    Console.WriteLine(count + ". " + Shows[i]);
                    count++;
                }
            }
            Console.WriteLine("\n");
        }

        public void PrintShows(Time time) {
            // This public method takes a time object as an argument and display all the shows matching the hour value of this time object. This will only work correctly if the == operator is implemented correctly in the Time class. The Time object that is associated with a show is not the same as the Time object that will be passed as the argument, therefore comparison with the usual == operator will not work because the object reference are not the same. Hence you have to supply a custom == operator that compares the numeric values of the fields of the two objects must be compared.

            // Note that the instructions under the instructions in the Time class, the method that controls the == operator has the instructions "method will return true if the difference between the two arguments is less than 15 minutes, otherwise it returns false" so these instructions were used instead of the show matching the hour value.
 
            Console.WriteLine("\nAll Shows Playing at " + Name + " Theatre Playing Any Day at " + time + ":");

            int count = 1;
            for (int i = 0; i < Shows.Count; i++) {
                if (Shows[i].Time == time) {
                    Console.WriteLine(count + ". " + Shows[i]);
                    count++;
                }
            }
            Console.WriteLine("\n");
        }

        public void PrintShows(string actor) {
            // This public method takes a string representing the name of an actor as an argument and display all the shows that this actor appears in. Remember that all the actors are stored as a List<string>, so you will have to use the instance method Contains() to check for the presence of an actor.
            Console.WriteLine("\nAll Shows Playing at " + Name + " Theatre with " + actor + ":");

            int count = 1;
            for (int i = 0; i < Shows.Count; i++) {
                if (Shows[i].Movie.Cast.Contains(actor)) {
                    Console.WriteLine(count + ". " + Shows[i]);
                    count++;
                }
            }
            Console.WriteLine("\n");
        }

        public void PrintShows(Day day, Time time) {
            // This public method takes a day value and a time value as arguments and display all the shows matching the day and the time value The Time object that is associated with a show is not the same as the Time object that will be passed as the argument, therefore the numeric values of the fields of the two objects must be compared.
            Console.WriteLine("\nAll Shows Playing at " + Name + " Theatre Playing on " + day + " at " + time + ":");

            int count = 1;
            for (int i = 0; i < Shows.Count; i++) {
                if (Shows[i].Time == time && Shows[i].Day == day) {
                    Console.WriteLine(count + ". " + Shows[i]);
                    count++;
                }
            }
            Console.WriteLine("\n");
        }

    }
}

    