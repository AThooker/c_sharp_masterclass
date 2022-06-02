using System;

namespace SwitchStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GameScoring(1550, "Tim");
        }

        //Switch Statement Challenge

        //create an app with a score, highscore, and a highscorePlayer
        //create method with two params, one for score and one for name
        //check the score against the current highscore, if new score is higher, print player name
        //if new score is less, print current high score with player name
        static int highScore = 1500;
        static string highScorePlayer = "Ted";

        public static void GameScoring(int score, string playerName)
        {
            if(score > highScore)
            {
                Console.WriteLine("New highscore is: " + score);
                highScore = score;
                Console.WriteLine("New highscore holder is " + playerName);
                highScorePlayer = playerName;
            }
            else
            {
                Console.WriteLine($"The old highscore of {highScore} is still held by {highScorePlayer}");
            }
        }

            //int age = 25;
            //switch (age)
            //{
            //    case 15:
            //        Console.WriteLine("too young for this place");
            //        break;
            //    case 25:
            //        Console.WriteLine("Come on in");
            //        break;
            //    default:
            //        Console.WriteLine("Don't know your age?");
            //        break;
            //}
            //if(age == 15)
            //{
            //    Console.WriteLine("too young");
            //}
            //else if(age == 25)
            //{
            //    Console.WriteLine("come on in");
            //}
            //else
            //{
            //    Console.WriteLine("dont know your age?");
            //}
            //string username = "Denis";
            //switch(username)
            //{
            //    case "Denis":
            //        Console.WriteLine("User permitted");
            //        break;
            //    case "Austin":
            //        Console.WriteLine("User authorized");
            //        break;
            //    default:
            //        Console.WriteLine("user access denied");
            //        break;
            //}
    }
}
