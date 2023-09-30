// Completed by Yaatu Adem, COMP123//

using System;

namespace assignment2 {
    public partial class TweetManager {
        private static List<Tweet> TWEETS = new List<Tweet>();
        private static string FILENAME = "Assignment_02_TweetFile.txt"; 
        static int count = 0; //to keep count of how many items are added to the lsit
        static TweetManager(){
            TWEETS = new List<Tweet>(); //resets the list
            count = 0; //resets the count for the # of items in list
            TextReader reader = new StreamReader(FILENAME); //declares and initializes a text reader for the tweet file
            string line = reader.ReadLine(); //reads the first line
            while (line!= null) { //reads lines in text file until null is detected, indicating the end of the file
                TWEETS.Add(Tweet.Parse(line));
                count++;
                line = reader.ReadLine();
            }
            reader.Close();
        }
        
        public static void Initialize(){
            TWEETS = new List<Tweet>();
            count = 0;
            Tweet sampleTweet1 = new Tweet("Tory" , "Drake", "Go Raptors!", "WeTheNorth"); //sample tweet for development
            TWEETS.Add(sampleTweet1); //adds sample tweet to list
            count++;
            //above is repeated to create 4 more sample tweets
            Tweet sampleTweet2 = new Tweet("Drake" , "Tory", "Go Raptors!", "Raptors"); 
            TWEETS.Add(sampleTweet2); 
            count++;
            Tweet sampleTweet3 = new Tweet("Tory" , "Bieber", "Go Leafs!", "Leafs"); 
            TWEETS.Add(sampleTweet3); 
            count++;
            Tweet sampleTweet4 = new Tweet("Trudeau" , "Obama", "Toronto joins cities around the world to celebrate International Day Against Homophobia & Transphobia", "WeTheNorth"); 
            TWEETS.Add(sampleTweet4); 
            count++;
            Tweet sampleTweet5 = new Tweet("Drake" , "Obama", "Toronto is the greatest city!", "TorontoStrong"); 
            TWEETS.Add(sampleTweet5); 
            count++;
        }

        public static void ShowAll(){
            for (int i = 0; i < count; i++) { //increments and prints all of the tweets in the list
                Console.WriteLine(TWEETS[i].ToString());
            }
        }

        public static void ShowAll(string tag){
            for (int i = 0; i < count; i++) { //increments and prints all of the tweets in the list if their tags match the argument
                if(TWEETS[i].Tag == tag) {
                    Console.WriteLine(TWEETS[i].ToString());
                }
            }
        }
    }
}

    