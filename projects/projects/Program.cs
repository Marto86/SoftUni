using System;

namespace projects
{
    class Program
    {
        static void Main(string[] args)
        {

            // starts with 100 credits
            // choose level 1,2,3,4
            // x2 row try to match 1 of 5 number between 1 and 5
            // x5 row try to match 2 of 5 numbers between 1 and 5
            // x10 row try to match 3 of 5 numbers between 1 and 5
            // x100 row try to match 5 of 5 numbers between 1 and 5

            Console.WriteLine("Hello u r now playing ConsoleCasino by e o ");
            Console.WriteLine("First write down your name!");
            string playerName = Console.ReadLine();
            Console.WriteLine("The computer generates 5 numbers each in range [1;3]   EXAMPLE : 2 3 1 1 2 ");
            Console.WriteLine("U have to choose also  5 numbers each in range [1;3]   EXAMPLE : 2 1 1 3 2   3/5 matches ");
            Console.WriteLine("More matches u get bigger price u win! But there are also 4 rooms ");
            Console.WriteLine("ROOM 1 : bet x2   if u match 2/5 ");
            Console.WriteLine("ROOM 2 : bet x5   if u match 3/5 ");
            Console.WriteLine("ROOM 3 : bet x10  if u match 4/5 ");
            Console.WriteLine("ROOM 4 : bet x100 if u match 5/5 ");
            Console.WriteLine();
            Console.WriteLine("Your goal is to make it to 1000 credits!");
            Console.WriteLine("   WARNING!   if u want to change rooms during the game wait until you choose your bet! ");
            Console.WriteLine("   WARNING!   Then type 0 as your bet and it will take you to 'Choose ROOM' code !!");
            Console.WriteLine();
            Console.WriteLine("You start with 100 credits! ");
            start:
            Console.WriteLine("Type 'start' to begin");
            string gamestarter = Console.ReadLine();
            lostRestart:
            double playerCredits = 100;

            if (gamestarter == "start")
            {
                Console.WriteLine("Current credits: 100 ");
                ChooseRoom:
                Console.WriteLine($"Choose ROOM to play 1 / 2 / 3 / 4");
                int roomNumber = int.Parse(Console.ReadLine());
                if (roomNumber == 1 || roomNumber == 2 || roomNumber == 3 || roomNumber == 4)
                {
                    restart: Random random = new Random();
                    int randNum1 = random.Next(1, 4);
                    int randNum2 = random.Next(1, 4);
                    int randNum3 = random.Next(1, 4);
                    int randNum4 = random.Next(1, 4);
                    int randNum5 = random.Next(1, 4);
                    Console.Write($"You r playing in ROOM {roomNumber}  ");
                    if (roomNumber == 1) { Console.WriteLine($"bet x 2   , goal 2/5 "); }
                    if (roomNumber == 2) { Console.WriteLine($"bet x 5   , goal 3/5 "); }
                    if (roomNumber == 3) { Console.WriteLine($"bet x 10  , goal 4/5 "); }
                    if (roomNumber == 4) { Console.WriteLine($"bet x 100 , goal 5/5 "); }
                    int matchNum1 = 0;
                    int matchNum2 = 0;
                    int matchNum3 = 0;
                    int matchNum4 = 0;
                    int matchNum5 = 0;
                    int matchSum = 0;
                    Console.WriteLine($"Current credits                   : {playerCredits} ");
                    Console.Write($"Make your bet (must be integer !) : ");

                    REBET1: int playerBET = int.Parse(Console.ReadLine());
                    Console.WriteLine($"                                                                                 {playerName} credits: {playerCredits - playerBET}");
                    if (playerBET > playerCredits || playerBET < 0) { Console.WriteLine($"Invalid bet! Choose between 1 and {playerCredits} !"); goto REBET1; }
                    if (playerBET == 0) { goto ChooseRoom; }
                    playerCredits = playerCredits - playerBET;

                    Console.WriteLine("Now write down 5 numbers each between [1;3] ");
                    NUMBER1: Console.Write("Firts  number: ");
                    int playerNum1 = int.Parse(Console.ReadLine()); if (playerNum1 < 1 || playerNum1 > 3) { Console.WriteLine("1 2 or 3 !"); goto NUMBER1; }
                    NUMBER2: Console.Write("Second number: ");
                    int playerNum2 = int.Parse(Console.ReadLine()); if (playerNum2 < 1 || playerNum2 > 3) { Console.WriteLine("1 2 or 3 !"); goto NUMBER2; }
                    NUMBER3: Console.Write("Third  number: ");
                    int playerNum3 = int.Parse(Console.ReadLine()); if (playerNum3 < 1 || playerNum3 > 3) { Console.WriteLine("1 2 or 3 !"); goto NUMBER3; }
                    NUMBER4: Console.Write("Fourth number: ");
                    int playerNum4 = int.Parse(Console.ReadLine()); if (playerNum4 < 1 || playerNum4 > 3) { Console.WriteLine("1 2 or 3 !"); goto NUMBER4; }
                    NUMBER5: Console.Write("Fifth  number: ");
                    int playerNum5 = int.Parse(Console.ReadLine()); if (playerNum5 < 1 || playerNum5 > 3) { Console.WriteLine("1 2 or 3 !"); goto NUMBER5; }
                    Console.WriteLine($"Your numbers   : {playerNum1}  {playerNum2}  {playerNum3}  {playerNum4}  {playerNum5} ");
                    Console.WriteLine($"Random numbers : {randNum1}  {randNum2}  {randNum3}  {randNum4}  {randNum5} ");

                    if (playerNum1 == randNum1) { matchNum1 = 1; }
                    if (playerNum2 == randNum2) { matchNum2 = 1; }
                    if (playerNum3 == randNum3) { matchNum3 = 1; }
                    if (playerNum4 == randNum4) { matchNum4 = 1; }
                    if (playerNum5 == randNum5) { matchNum5 = 1; }
                    matchSum = matchNum1 + matchNum2 + matchNum3 + matchNum4 + matchNum5;
                    //Console.WriteLine($"You have {matchSum} matches!");
                    Console.Write($"Your bet was {playerBET}                ");
                    switch (roomNumber)
                    {
                        case 1:
                            if (matchSum >= 2)
                            {
                                playerCredits = playerCredits + 2 * playerBET;
                                Console.Write($"You have {matchSum}/2 matches!   ");
                                Console.WriteLine($"Your win is your bet {playerBET} x 2 = {playerBET * 2} ");
                                Console.WriteLine($"Your credits are now {playerCredits} ");
                            }
                            else
                            {
                                Console.WriteLine($"You have {matchSum} matches but you need atleast 2 matches!");
                                Console.WriteLine($"Your credits are {playerCredits} ");
                            }
                            break;
                        case 2:
                            if (matchSum >= 3)
                            {
                                playerCredits = playerCredits + 5 * playerBET;
                                Console.Write($"You have {matchSum}/3 matches!   ");
                                Console.WriteLine($"Your win is your bet {playerBET} x 5 = {playerBET * 5} ");
                                Console.WriteLine($"Your credits are now {playerCredits} ");
                            }
                            else
                            {
                                Console.WriteLine($"You have {matchSum} matches but you need atleast 3 matches!");
                                Console.WriteLine($"Your credits are {playerCredits} ");
                            }
                            break;
                        case 3:
                            if (matchSum >= 4)
                            {
                                playerCredits = playerCredits + 10 * playerBET;
                                Console.Write($"You have {matchSum}/4 matches!   ");
                                Console.WriteLine($"Your win is your bet {playerBET} x 10 = {playerBET * 10} ");
                                Console.WriteLine($"Your credits are now {playerCredits} ");
                            }
                            else
                            {
                                Console.WriteLine($"You have {matchSum} matches but you need atleast 4 matches!");
                                Console.WriteLine($"Your credits are {playerCredits} ");
                            }
                            break;
                        case 4:
                            if (matchSum >= 5)
                            {
                                playerCredits = playerCredits + 100 * playerBET;
                                Console.Write($"You have {matchSum}/5 matches!   ");
                                Console.WriteLine($"Your win is your bet {playerBET} x 100 = {playerBET * 100}                  WELL DONE !");
                                Console.WriteLine($"Your credits are now {playerCredits} ");
                            }
                            else
                            {
                                Console.WriteLine($"You have {matchSum} matches but you need atleast 5 matches!");
                                Console.WriteLine($"Your credits are {playerCredits} ");
                            }
                            break;
                    }
                    if (playerCredits <= 0)
                    {
                        Console.Write("You lost ! ");
                        PLAYAGAINAFTERWIN:
                        Console.WriteLine("play again?    yes/no : ");
                        YESORNO:
                        string youLost = Console.ReadLine();
                        if (youLost == "yes")
                        {
                            goto lostRestart;
                        }
                        else if (youLost == "no")
                        {
                            Console.WriteLine("have a good day!");
                            goto DARKEND;
                        }
                        else
                        {
                            Console.WriteLine(" 'yes' or 'no' please !");
                            goto YESORNO;
                        }

                    }
                    if (playerCredits > 1000)
                    {
                        Console.WriteLine("NICE MAN!");
                        Console.WriteLine($"{playerCredits} / 1000!");
                        Console.WriteLine("U THE CHAMP U THE GOD U BEAT THE ALGORITHM !");
                        goto DARKEND;
                    }

                    goto restart;
                }
                else
                {
                    Console.WriteLine("Pick 1 2 3 or 4 !"); goto ChooseRoom;
                }
            }
            else
            {
                goto start;
            }

            DARKEND:;
        }
    }
}
