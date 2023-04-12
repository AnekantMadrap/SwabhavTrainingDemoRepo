using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigDiceGame
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Let's Play PIG!\n");
            Console.WriteLine("* See how many turns it takes you to get to 20.");
            Console.WriteLine("* Turn ends when you hold or roll a 1.");
            Console.WriteLine("* If you roll a 1, you lose all points for the turn.");
            Console.WriteLine("* If you hold, you save all points for the turn.\n");

            int totalScore = 0;
            int turnScore = 0;
            // int turnCount = 1;
            bool gameOver = false;
            bool turn1 = true;
            int turnno = 1;
            Random rnd = new Random();
            while (turn1)
            {
                //Console.WriteLine($"TURN {turnno}:\n");

                while (!gameOver)
                {
                    Console.WriteLine();
                    Console.WriteLine($"TURN {turnno}:\n");
                    Console.Write("Enter 'r' to roll again, 'h' to hold.\n");
                    string choice = Console.ReadLine().ToLower();
                    if (choice == "r")
                    {

                        int roll = rnd.Next(1, 7);

                        if (roll == 1)
                        {
                            Console.WriteLine($"You rolled: {roll}");
                            Console.WriteLine($"Turn over. No Score\n");
                            turnScore = 0;
                            turnno++;
                        }
                        else
                        {

                            turnScore += roll;
                            Console.WriteLine($"You rolled: {roll}");
                            Console.WriteLine($"Your turn score is {turnScore} and your total score is {totalScore}");


                            if (totalScore + turnScore >= 20)
                            {
                                Console.WriteLine($"Your turn score is {turnScore} and your total score is {totalScore + turnScore}");
                                Console.WriteLine($"You Win! You finished in {turnno} turns!\n");
                                gameOver = true;
                                break;
                                //turnCount = 21;
                            }

                            Console.Write("If you hold, you will have ");
                            Console.WriteLine($"{totalScore + turnScore} points.");




                            //continue;
                        }
                    }

                    else
                    {
                        if (choice == "h")
                        {
                            totalScore += turnScore;
                            Console.WriteLine($"\nYour turn score is {totalScore} and your total score is {totalScore}\n");
                            turnScore = 0;
                            turnno++;
                        }
                    }



                }
                if (gameOver == true)
                {
                    turn1 = false;
                    break;
                }
                else
                {
                    turnno++;
                }

            }
        }
    }
}


/*static void RolledIn()
{
    Random random = new Random();
    int returnvalue = random.Next(1, 7);
    //TotalScore ts = new TotalScore();
    //int z = 0;
    int lastscore;
    if (returnvalue == 1)
    {
        Console.WriteLine("Turn over. No Score");
        Points(0);

    } 
    else
    {
        Console.WriteLine($"You rolled:{returnvalue}");
        //ts.SetScore(returnvalue);

        Console.WriteLine($"Your turn score is {TrueScore(returnvalue,lastscore)} and your total score is {TotalScorer(returnvalue)}");
        int point = TrueScore(returnvalue,lastscore) + TotalScorer(returnvalue);
        int point1=Points(point);
        Console.WriteLine($"If you hold, you will have {point1} points.");
        lastscore = returnvalue;
        //TrueScore(returnvalue, lastscore);

    }
}
static void RolledOut()
{
    Console.WriteLine("Your turn score is 10 and your total score is 10");


}

static int lastscore(int score)
{
    return score;
}
private static int TrueScore(int score)
{
    return score+lastscore();
}
static int TotalScorer(int score) 
{
    int score1 = 0;
    return score1+score;
}
static int TotalScorerh(int score)
{
    int score1 = 0;
    return score1 + score;
}
static int Points(int point)
{
    if(point == 0)
    {
        point= 0;
    }
    //else
    //{
    //    point= point;
    //}
    return point;
}*/



