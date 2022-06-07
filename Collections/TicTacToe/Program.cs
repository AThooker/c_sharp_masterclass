using System;

namespace TicTacToe
{
    class Program
    {
        //the playfield
        static char[,] playField =
        {
            {'1','2','3'},
            {'4','5','6'},
            {'7','8','9'},

        };
        static int turns = 0;
        static void Main(string[] args)
        {
            int player = 2; //player 1 starts
            int input = 0;
            bool inputCorrect = true;
            //SetField();

            do
            {
                if (player == 2)
                {
                    player = 1;
                    XorO('O', input);
                }
                else if (player == 1)
                {
                    player = 2;
                    XorO('X', input);
                }
                SetField();
                #region CheckForWinner
                //check winning conditions
                char[] playerChars = { 'X', 'O' };
                foreach (char playerChar in playerChars)
                {
                    for (int i = 0; i < playField.GetLength(0); i++)
                    {
                        if ((playField[i, 0] == playField[i, 1] && playField[i, 2] == playField[i, 0] && playField[i, 0] == playerChar) ||
                            (playField[0, i] == playField[1, i] && playField[0, i] == playField[2, i] && playField[0, i] == playerChar) || (playField[0, 0] == playField[1, 1] && playField[0, 0] == playField[2, 2] && playField[0, 0] == playerChar) || (playField[0, 2] == playField[1, 1] && playField[2, 0] == playField[0, 2] && playField[0, 2] == playerChar))
                        {
                            if (playerChar == 'X')
                            {
                                Console.WriteLine("\n Player 2 has won!");
                            }
                            else if (playerChar == 'O')
                            {
                                Console.WriteLine("\n Player 1 has won!");
                            }
                            Console.WriteLine("\nPress any key to reset the game!");
                            Console.ReadKey();
                            //reset field
                            ResetField();
                            break;
                        }
                        else if (turns == 10)
                        {
                            Console.WriteLine("DRAW!!!");
                            Console.WriteLine("Please press any key to reset the game");
                            Console.ReadKey();
                            ResetField();
                            break;
                        }
                    }
                }
                #endregion
                #region TestFieldTaken
                do
                {
                    Console.Write($"\nPlayer {player}: choose your field: ");
                    try
                    {
                        input = Int32.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Please enter a number!");
                    }
                    if ((input == 1) && (playField[0, 0] == '1'))
                        inputCorrect = true;
                    else if ((input == 2) && (playField[0, 1] == '2'))
                        inputCorrect = true;
                    else if ((input == 3) && (playField[0, 2] == '3'))
                        inputCorrect = true;
                    else if ((input == 4) && (playField[1, 0] == '4'))
                        inputCorrect = true;
                    else if ((input == 5) && (playField[1, 1] == '5'))
                        inputCorrect = true;
                    else if ((input == 6) && (playField[1, 2] == '6'))
                        inputCorrect = true;
                    else if ((input == 7) && (playField[2, 0] == '7'))
                        inputCorrect = true;
                    else if ((input == 8) && (playField[2, 1] == '8'))
                        inputCorrect = true;
                    else if ((input == 9) && (playField[2, 2] == '9'))
                        inputCorrect = true;
                    else
                    {
                        Console.WriteLine("\n Incorrect input, please use another field");
                        inputCorrect = false;
                    }
                } while (!inputCorrect);
            } while (true);
            #endregion
        }

        public static void ResetField()
        {
            char[,] playFieldReset =
            {
                {'1','2','3'},
                {'4','5','6'},
                {'7','8','9'},
            };

            playField = playFieldReset;
            SetField();
            turns = 0;
        }

        public static void SetField()
        {
            Console.Clear();
            Console.WriteLine("       |       |       ");
            //replace numbers with variables
            Console.WriteLine("   {0}   |   {1}   |  {2}  ", playField[0, 0], playField[0, 1], playField[0, 2]);
            Console.WriteLine("_______|_______|_______");
            Console.WriteLine("       |       |       ");
            //replace numbers with variables
            Console.WriteLine("   {0}   |   {1}   |  {2}  ", playField[1, 0], playField[1, 1], playField[1, 2]);
            Console.WriteLine("_______|_______|_______");
            Console.WriteLine("       |       |       ");
            //replace numbers with variables
            Console.WriteLine("   {0}   |   {1}   |  {2}  ", playField[2, 0], playField[2, 1], playField[2, 2]);
            Console.WriteLine("_______|_______|_______");
            Console.WriteLine("       |       |       ");
            turns++;

        }
        public static void XorO(char playerSign, int input)
        {
            //char playerSign = ' ';
            //if (player == 1)
            //    playerSign = 'X';
            //else if (player == 2)
            //    playerSign = 'O';
            switch (input)
            {
                case 1: playField[0, 0] = playerSign; break;
                case 2: playField[0, 1] = playerSign; break;
                case 3: playField[0, 2] = playerSign; break;
                case 4: playField[1, 0] = playerSign; break;
                case 5: playField[1, 1] = playerSign; break;
                case 6: playField[1, 2] = playerSign; break;
                case 7: playField[2, 0] = playerSign; break;
                case 8: playField[2, 1] = playerSign; break;
                case 9: playField[2, 2] = playerSign; break;
            }
        }
    }

}
