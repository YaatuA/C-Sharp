// Completed by Yaatu Adem, COMP123//

using System;

namespace assignment2 {
    public partial class Tweet {
        private static int CURRENT_ID = 1;
        public string From { get; }
        public string To { get; }
        public string Body { get; }
        public string Tag { get; }
        public string ID { get; }

        public Tweet(string from, string to, string body, string tag) {
            From = from;
            To = to;
            Body = body;
            Tag = tag;
            ID = Convert.ToString(CURRENT_ID);
            CURRENT_ID++;
        }

        public Tweet(string from, string to, string body, string tag, string id){
            From = from;
            To = to;
            Body = body;
            Tag = tag;
            ID = id;
        }

        public override string ToString(){
            return $"ID: {ID}| @{From} to @{To}: {Body} #{Tag}";
        }

        public static Tweet Parse(string line){
            string[] values = line.Split('\t'); //splits the values from the line after each tab into a string array
            string tag = values[0];
            string from = values[1];
            string to = values[2];
            string body = values[3];
            string id = values[4];
            Tweet tweet = new Tweet(from, to, body, tag, id); //creates a tweet from the values 
            return tweet;
        }

    }
}

    