// Completed by Yaatu Adem, COMP123//

using System;

namespace assignment3 {
    public partial class Show {
        public double Price { get; }
        public Day Day { get; }
        public Movie Movie { get; }
        public Time Time { get; }

        public Show (Movie movie, Day day, double price, Time time) {
            //This is the public constructor that takes four arguments and assigns them to the appropriate properties.
            Movie = movie;
            Day = day;
            Price = price;
            Time = time;
        }

        public override string ToString() {
            //This is the public method overrides the method of the same name in the object class to return a meaningful description of this object.
            return $"{Movie} | {Day} @ {Time} | ${string.Format("{0:0.00}", Price)}";
        }

    }
}

    