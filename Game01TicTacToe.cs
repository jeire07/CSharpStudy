using static System.Console;

namespace CSharpStudy
{
    public class Game01TicTacToe
    {
        static string[] Mark = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        static int[,] Owner = new int[9, 3];
        static int count = 1;
        static int player = 0;
        static int userNum = 0;
        static int whoWin = 0;

        static void InitOwner()
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 1; j > -2; j--)
                {
                    Owner[i, 0] = (i % 3) - 1;
                    Owner[i, 1] = (-i / 3) + 1;
                    Owner[i, 2] = 0;
                }
            }
        }

        static void WriteOwner()
        {
            Console.Write("{");
            for (int i = 0; i < 9; i++)
            {
                Console.Write("{");
                for (int j = 0; j < 3; j++)
                {
                    if (j == 2)
                    {
                        Console.Write(Owner[i, j]);
                    }
                    else
                    {
                        Console.Write(Owner[i, j] + ", ");
                    }
                }
                if (i == 8)
                {
                    Console.Write("}");
                }
                else
                {
                    Console.Write("}, ");
                }
            }
            Console.WriteLine("}");
            Console.WriteLine();
        }

        static void PlayTicTacToe()
        {
            Console.Clear();
            InitOwner();
            WriteOwner();

            Console.WriteLine(" Two players compete to make line");
            Console.WriteLine(" If a player gets three in a row, that player wins.");
            Console.WriteLine();
            DisplayBoard();


            while (whoWin == 0)
            {
                player = ((count % 2) == 1) ? 1 : 2;

                Console.Write(" player{0} pick : ", player);
                userNum = GetInput(1, 9, player);

                Console.Clear();
                WriteOwner();
                DisplayBoard();

                whoWin = CheckWin(player);
            }

            if ((whoWin == 1) || (whoWin == 2))
            {
                Console.WriteLine("player{0} wins!", whoWin);
            }
            else
            {
                Console.WriteLine("tie!");
            }
        }

        static void DisplayBoard()
        {
            for (int i = 0; i < 9; i++)
            {
                if (((i % 3) == 0) || (i == 8))
                {
                    Console.WriteLine("     |     |     ");
                }
                else if ((i % 3) == 1)
                {
                    Console.WriteLine("  {0}  |  {1}  |  {2}  ", Mark[i], Mark[i+1], Mark[i+2]);
                }
                else
                {
                    Console.WriteLine("_____|_____|_____");
                }
            }
            Console.WriteLine();
        }

        static int GetInput(int minimum, int maximum, int player)
        {
            string userInput;
            int validInput = 0;

            while (validInput != 1)
            {
                //get user's input
                userInput = Console.ReadLine();

                //exception by using tryParse
                validInput = int.TryParse(userInput, out userNum) ? 1 : 0;

                /*
                //check user's input is integer
                try
                {
                    userNum = int.Parse(userInput);
                    validInput = 1;
                }
                catch
                {
                    Console.WriteLine(" you can input integer only");
                }
                */

                //check user's input is between 1 and 9
                if (validInput == 0)
                {
                    Console.WriteLine(" you can input integer only");
                    Console.WriteLine();
                    Console.Write(" player{0} pick : ", player);
                }
                else if ((userNum > maximum) || (userNum < minimum))
                {
                    Console.WriteLine(" that number is out of range");
                    Console.Write(" choose another number ");
                    Console.WriteLine("between 1 to 9");
                    Console.WriteLine();
                    Console.Write(" player{0} pick : ", player);
                    validInput = 0;
                }
                else
                {
                    if ((Mark[userNum] == "X") || (Mark[userNum] == "O"))
                    {
                        Console.WriteLine("you cannot select that point, select another point");
                        Console.WriteLine();
                        Console.Write(" player{0} pick : ", player);
                    }
                    else
                    {
                        if (player % 2 == 0)
                        {
                            Mark[userNum] = "O";
                            Owner[userNum - 1, 2] = -1;
                        }
                        else
                        {
                            Mark[userNum] = "X";
                            Owner[userNum - 1, 2] = 1;
                        }
                        count++;
                        break;
                    }
                    Console.WriteLine();
                }
            }
            return userNum;
        }

        static int CheckWin(int player)
        {
            int[] line = new int[8] { 0, 0, 0, 0, 0, 0, 0, 0 };

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    line[i] += Owner[3 * i + j, 2];
                    line[3+j] += Owner[3 * i + j, 2];
                }
            }
            line[6] = Owner[0, 2] + Owner[4, 2] + Owner[8, 2];
            line[7] = Owner[2, 2] + Owner[4, 2] + Owner[6, 2];

            for (int i = 0; i < 8; i++)
            {

                if (line[i] == 3)
                {
                    return 1;
                }
                else if (line[i] == -3)
                {
                    return 2;
                }
                else
                {
                    if (count == 9)
                    {
                        return 3;
                    }
                    continue;
                }
            }
            return 0;
        }
    }
}
