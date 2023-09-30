// Completed by Yaatu Adem, COMP123//

using System;

namespace assignment3 {
    public partial class Movie {
        public int Length { get; }
        public int Year { get; }
        public string Title { get; }
        public Genre Genre { get; private set; }
        public List<string> Cast { get; private set; }

        public Movie (string name, int year, int length) {
            //This public constructor takes one string and two int parameters. It does the following:
                //a. Assigns the arguments to the appropriate properties.
                //b. Initialize the Cast property to an empty list of string.

            Title = name;
            Year = year;
            Length = length;
            Cast = new List<string>();
            Genre = Genre.Unrated;
        }

        public void AddActor(string actor) {
            //This public method takes a single string argument and adds it to the collection of actors (Cast).
            Cast.Add(actor);
        }

        public void SetGenre(Genre genre) {
            //This public method takes a single enum argument and assigns it to the property of the same name. This argument maybe a combination of multiple genres.
            Genre = genre;
        }

        public override string ToString() {
            //This method overrides the same method of the Object class. It does not take any parameter but return a string representation of itself. You will need to show all the properties of this object.
            //To show the actors, you need to build a single string comprising all of the elements in this movie. Use the string.Join(", ", Cast). You decide on the format for the output.
            
            return $"{Title} ({Year}) Starring: {string.Join(", ", Cast)} | {Length} minute runtime | Genre: {Genre.ToString()}";
        }

    }
}

    