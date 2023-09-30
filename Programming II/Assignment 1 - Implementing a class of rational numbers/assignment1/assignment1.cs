// Completed by Yaatu Adem, COMP123//

using System;

namespace assignment1 {
    class Rational {
        public int denominator { get; private set; }
        public int numerator { get; private set; }
         public Rational(int numerator = 0, int denominator = 1) {
            this.numerator = numerator;
            this.denominator = denominator;
        }

        public override string ToString() {
            return $"{numerator}/{denominator}";
        }

        public void IncreaseBy(Rational other) {
            // Giving both values common denominators so they can be added
            this.numerator = this.numerator * other.denominator;
            other.numerator = other.numerator * this.denominator;
            this.denominator = this.denominator * other.denominator;
            // other.denominator is not calculated as it is the same as this.denominator and not necessary for calculations

            //Adding the numerators
            this.numerator = this.numerator + other.numerator;
        }

        public void DecreaseBy(Rational other) {
            // Giving both values common denominators so they can be subtracted
            this.numerator = this.numerator * other.denominator;
            other.numerator = other.numerator * this.denominator;
            this.denominator = this.denominator * other.denominator;

            //Subtracting the numerators
            this.numerator = this.numerator - other.numerator;
        }
    }
    class assignment1 {
        static void Main(string[] args) {
            // Testing Part 1: 4 Rational objects are created using 0, 1, and 2 arguments
            Rational noArguments = new Rational();
            Rational oneArgument = new Rational(5);
            Rational twoArguments = new Rational(3, 4);
            Rational twoArgumentsAgain = new Rational(4, 9);

            // Testing Part 2: Using IncreasedBy
            Console.WriteLine("The first rational number is: " + noArguments);
            Console.WriteLine("The second rational number is: " + oneArgument);
            Console.WriteLine("We will increase " + noArguments + " by " + oneArgument);
            noArguments.IncreaseBy(oneArgument);
            Console.WriteLine("This operation will give us the value: " + noArguments + "\n");

            // Testing Part 3
            // Testing Part 2: Using IncreasedBy
            Console.WriteLine("The third rational number is: " + twoArguments);
            Console.WriteLine("The fourth rational number is: " + twoArgumentsAgain);
            Console.WriteLine("We will decrease " + twoArguments + " by " + twoArgumentsAgain);
            twoArguments.DecreaseBy(twoArgumentsAgain);
            Console.WriteLine("This operation will give us the value: " + twoArguments);
        }
    }
}