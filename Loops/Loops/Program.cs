using System;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ForLoopsTests();
            //DoWhileLoopTest();
            //WhileLoopPractice();
            //ForLoopBreakContinue();
            //WhileLoopChallenge();
            CalculateAverageScore();
        }

        //for loop
        // (start value, condition, increment)
        public static void ForLoopTests()
        {
            for (int i = 0; i <= 20; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        public static void ForLoopBreakContinue()
        {
            for (int counter = 0; counter < 10; counter++)
            {
                if (counter == 3)
                {
                    //Console.WriteLine("At 3 we are done");
                    //break;
                    //Console.WriteLine("skip 3");
                    continue;
                }
                Console.WriteLine(counter);
            }
        }
        //while loop
        public static void WhileLoopPractice()
        {
            int counter = 1;
            Console.WriteLine("Please press enter to count each person: ");
            string enteredText = "";
            while (enteredText.Equals(""))
            {
                enteredText = Console.ReadLine();
                Console.WriteLine(counter);
                counter++;
            }
            Console.WriteLine($"{counter} people are here today");
        }
        public static void WhileLoopChallenge()
        {
            int i = -10;
            while (true)
            {
                // TODO
                if (i % 3 == 0)
                {
                    i++;
                    continue;
                }
                Console.WriteLine(i);
                if (i == 10)
                {
                    break;
                }
                i++;
            }
        }

        //do while loop
        public static void DoWhileLoopTest()
        {
            //int counter = 0;
            int lengthOfInput;
            do
            {
                Console.WriteLine("Please enter someone's name");
                lengthOfInput = Console.ReadLine().Length;
            } while (lengthOfInput < 7);
        }

        //loop challenge, average scores for class, handle if teacher enters incorrect value
        //should stop if -1 is entered
        public static void CalculateAverageScore()
        {
            Console.WriteLine("Please begin entering the scores for your class (0-20), when you are done, enter -1 to see the average score: \n");
            string score = "";
            int totalscore = 0;
            int numberOfScores = 0;
            do
            {
                Console.WriteLine("Enter the score: ");
                score = Console.ReadLine();
                if (int.TryParse(score, out int newScore) && newScore < 20 && newScore > 0)
                {
                    numberOfScores++;
                    totalscore += newScore;
                }
                else
                {
                    Console.WriteLine("Please try to enter a score between 0 and 20");
                    continue;
                }
            } while (!score.Equals("-1"));
            double average = (double)totalscore / numberOfScores;
            Console.WriteLine($"The total score was: {totalscore} \n" +
                $"The number of scores are: {numberOfScores} \n" +
                $"The average score for the class is : {average}");

        }
    }
}
