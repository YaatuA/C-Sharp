// Completed by Yaatu Adem, COMP123//

using System;

namespace assignment2 {
    public partial class Tweet { //links Tweet class from separate file
        
    }

    public partial class TweetManager { //links TweetManager class from separate file
        
    }

    class assignment2 {
        static void Main(string[] args) {
            Console.WriteLine("Here are all of the tweets from the file: ");
            TweetManager.ShowAll();
            Console.WriteLine("\nHere are all the tweets from the file filtered using the hashtag #Raptors as the tag:");
            TweetManager.ShowAll("Raptors");
            TweetManager.Initialize();
            Console.WriteLine("\nHere are all of the sample tweets from the Initialize() method: ");
            TweetManager.ShowAll();
            Console.WriteLine("\nHere are all the tweets from the Initialize() method filtered using the hashtag #WeTheNorth as the tag:");
            TweetManager.ShowAll("WeTheNorth");
        }
    }
}