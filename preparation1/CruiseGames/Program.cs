using System;

namespace Darts_Tournament
{
    class Program
    {
        static void Main(string[] args)
        {
            string playerName = Console.ReadLine();
            int countgame = int.Parse(Console.ReadLine());


            double countVolleyball = 0;
            double pointsVolleyball = 0;

            double countTenis = 0;
            double pointsTenis = 0;

            double countBadminton = 0;
            double pointsBadminton = 0;

            for (int i = 1; i <= countgame; i++)
            {
                string gameName = Console.ReadLine();
                int points = int.Parse(Console.ReadLine());

                if (gameName == "volleyball")
                {
                    countVolleyball++;
                    double currentPoints = 1.07 * points;
                    pointsVolleyball += currentPoints;
                }
                else if (gameName == "tennis")
                {
                    countTenis++;
                    double currentPoints = points + 0.05 * points;
                    pointsTenis += currentPoints;
                }
                else if (gameName == "badminton")
                {
                    countBadminton++;
                    double currentPoints = points + 0.02 * points;
                    pointsBadminton += currentPoints;
                }
            }


            double averageVolleyball = pointsVolleyball / countVolleyball;
            double averageTenis = pointsTenis / countTenis;
            double averageBadminton = pointsBadminton / countBadminton;
            double totalPoints = Math.Floor(pointsVolleyball + pointsTenis + pointsBadminton);

            if (averageVolleyball >= 75 && averageTenis >= 75 && averageBadminton >= 75)
            {


                Console.WriteLine($"Congratulations, {playerName}! You won the cruise games with {totalPoints} points.");

            }
            else
            {
                Console.WriteLine($"Sorry, {playerName}, you lost. Your points are only {totalPoints}.");
            }
        }

    }
}