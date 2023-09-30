// Completed by Yaatu Adem, COMP123//

using System;

namespace assignment3 {
    public partial class Time {
        public int Hours { get; private set; } //both Hours and Second had absent setters on page 1 of the assignment but page 3 indicated it was private setter, so that was used for the assignment
        public int Minutes { get; private set; }

         public int Seconds { get; }
        // The Seconds variable was listed on the first page of the assignment, but was not listed on page 3. As the code to be copied into the test harness uses a third value for Time, the Seconds variable was kept

        public Time (int hours, int minutes, int seconds = 0) {
            // This public constructor takes *three* int parameters and assigns them to the appropriate properties. The *third* parameter is optional
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }

        public override string ToString() {
            //This method overrides the same method of the Object class. It does not take any parameter but return a string representation of itself. You decide on the format for the output.
            return $"{Hours}:{Minutes.ToString("00")}"; // I chose not to include the second variable as they are not traditionally used when listing movie times in real life, and all values in the test harness are set to 0 anyways
        }
        
        public static bool operator == (Time lhs, Time rhs) {
            // This method overrides the equality operator. This method will return true if the difference between the two arguments is less than 15 minutes, otherwise it returns false. This method is used in the PrintShows(Time time) method of the Theater class. If you cannot figure out the 15 minutes difference, then check for equality of the fields hours and minutes. One way of figuring out the 15 minutes difference is to convert the hours and minutes fields to just a minute value. If you do the same to both objects, you can determine how close the two objects are.
            bool isTrue = false;

            int lhsMinutes = ((lhs.Hours) * 60) + lhs.Minutes;
            int rhsMinutes = ((rhs.Hours) * 60) + rhs.Minutes;

            if ((lhsMinutes - rhsMinutes) < 15 && (lhsMinutes - rhsMinutes) > -15) {
                isTrue = true;
                //Console.WriteLine("\n" + (lhsMinutes - rhsMinutes) + " , " + isTrue + "\n");

            }
            return isTrue;
        }

        public static bool operator!= (Time lhs, Time rhs) {
            // This method overrides the not equality operator. This method is required by the compiler when the above method is implemented. It does the reverse of the above. This method is not used directly be any class.
            bool isTrue = false;

            int lhsMinutes = ((lhs.Hours) * 60) + lhs.Minutes;
            int rhsMinutes = ((rhs.Hours) * 60) + rhs.Minutes;

            if ((lhsMinutes - rhsMinutes) >= 15 && (lhsMinutes - rhsMinutes) <= -15) {
                isTrue = true;
                //Console.WriteLine("\n" + (lhsMinutes - rhsMinutes) + " , " + isTrue + "\n");

            }
            return isTrue;
        }
    }
}

    