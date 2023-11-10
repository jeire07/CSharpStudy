using System;
using static System.Console;

namespace CSharpStudy
{
    public class Game01TicTacToe
    {
        private string[] _mark = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        private int _count = 1;
        private int _player = 0;
        private int _userNum = 0;
        private int _whoWin = 0;

        public void PlayTicTacToe()
        {
            while(true)
            {
                Clear();
                WriteLine();
                WriteLine(" Two players compete to make line");
                WriteLine(" If a player gets three in a row, that player wins.");
                
                DisplayBoard();

                while (_whoWin == 0)
                {
                    _player = ((_count % 2) == 1) ? 1 : 2;

                    Write(" player{0} pick : ", _player);
                    _userNum = GetInput(1, 9, _player);

                    Clear();
                    DisplayBoard();

                    _whoWin = CheckWin(_player);
                }

                if ((_whoWin == 1) || (_whoWin == 2))
                {
                    WriteLine("player{0} wins!", _whoWin);
                }
                else
                {
                    WriteLine("tie!");
                }

                Write(" Play one more time? (y/n): ");
                string userInput = ReadLine();

                if (userInput.ToLower() == "y")
                {
                    for (int i = 0; i < 10; i++)
                    {
                        _mark[i] = i.ToString();
                        _count = 1;
                        _whoWin = 0;
                        _player = 0;
                        _userNum = 0;
                    }
                }
                else
                {
                    break;
                }
            }
        }

        private void DisplayBoard()
        {
            WriteLine();
            for (int i = 0; i < 9; i++)
            {
                if (((i % 3) == 0) || (i == 8))
                {
                    WriteLine("      |     |     ");
                }
                else if ((i % 3) == 1)
                {
                    WriteLine("   {0}  |  {1}  |  {2}  "
                        , _mark[i], _mark[i+1], _mark[i+2]);
                }
                else
                {
                    WriteLine(" _____|_____|_____");
                }
            }
            WriteLine();
        }

        private int GetInput(int minimum, int maximum, int player)
        {
            string userInput;
            int validInput = 0;

            while (validInput != 1)
            {
                //get user's input
                userInput = ReadLine();

                //exception by using tryParse
                validInput = int.TryParse(userInput, out _userNum) ? 1 : 0;

                /*
                //check user's input is integer
                try
                {
                    userNum = int.Parse(userInput);
                    validInput = 1;
                }
                catch
                {
                    WriteLine(" you can input integer only");
                }
                */

                //check user's input is between 1 and 9
                if (validInput == 0)
                {
                    WriteLine(" you can input integer only");
                    WriteLine();
                    Write(" player{0} pick : ", player);
                }
                else if ((_userNum > maximum) || (_userNum < minimum))
                {
                    WriteLine(" that number is out of range");
                    Write(" choose another number ");
                    WriteLine("between 1 to 9");
                    WriteLine();
                    Write(" player{0} pick : ", player);
                    validInput = 0;
                }
                else
                {
                    if ((_mark[_userNum] == "X") || (_mark[_userNum] == "O"))
                    {
                        WriteLine("you cannot select that point, select another point");
                        WriteLine();
                        Write(" player{0} pick : ", player);
                    }
                    else
                    {
                        if (player % 2 == 0)
                        {
                            _mark[_userNum] = "O";
                        }
                        else
                        {
                            _mark[_userNum] = "X";
                        }
                        _count++;
                        break;
                    }
                    WriteLine();
                }
            }
            return _userNum;
        }

        private int CheckWin(int player)
        {
            int[] owner = new int[9] { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            int[] line = new int[8] { 0, 0, 0, 0, 0, 0, 0, 0 };

            //Verify ownership for each cell
            for (int i = 1; i < 10; i++)
            {
                if (_mark[i] == "X")
                {
                    owner[i-1] = 1;
                }
                else if (_mark[i] == "O")
                {
                    owner[i-1] = -1;
                }
                else
                {
                    owner[i-1] = 0;
                }
            }

            //calculate ownership for each line
            for (int j = 0; j < 3; j++)
            {
                for (int k = 0; k < 3; k++)
                {
                    line[j] += owner[3 * j + k];
                    line[3+k] += owner[3 * j + k];
                }
            }
            line[6] = owner[0] + owner[4] + owner[8];
            line[7] = owner[2] + owner[4] + owner[6];

            //if you want to see Console Write for CheckWin, uncomment below codes.
            //for (int i = 0; i < owner.Length; i++)
            //{
            //    Console.Write(owner[i] + " ");
            //}
            //Console.WriteLine();

            //for (int i = 0; i < line.Length; i++)
            //{
            //    Console.Write(line[i] + " ");
            //}
            //Console.WriteLine();

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
                    if (_count == 10)
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
