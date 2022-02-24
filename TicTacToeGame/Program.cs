using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeGame
{
    class Program
    {
       
       
        static char[,] playField = { {'1','2','3' }, //Row 0
                               {'4', '5','6'}, //   Row 1
                                {'7','8','9'} }; //Row 2
        static void Main(string[] args)
        {
            bool inputCorrect = true;
            int player = 2;
            int input = 0;
            //DrawBoard();
            do
            {
                if (player == 2)
                {
                    player = 1;
                    EnterXorO(player, input);
                }
                else if (player == 1)
                {
                    player = 2;
                    EnterXorO(player, input);
                }
                DrawBoard();
                #region
                //To check the winning condition.
                char[] playerChar = { 'X', 'O' };
                foreach (var item in playerChar)
                {
                    if ((playField[0, 0] == item) && (playField[0, 1] == item) && (playField[0, 2] == item) ||
                        (playField[1, 0] == item) && (playField[1, 1] == item) && (playField[1, 2] == item) ||
                        (playField[2, 0] == item) && (playField[2, 1] == item) && (playField[2, 2] == item) ||
                        (playField[0, 0] == item) && (playField[1, 0] == item) && (playField[2, 0] == item) ||
                        (playField[0, 1] == item) && (playField[1, 1] == item) && (playField[2, 1] == item) ||
                        (playField[0, 2] == item) && (playField[1, 2] == item) && (playField[2, 2] == item) ||
                        (playField[0, 0] == item) && (playField[1, 1] == item) && (playField[2, 2] == item) ||
                        (playField[0, 2] == item) && (playField[1, 1] == item) && (playField[2, 0] == item))
                    {
                        if (item == 'X')
                        {
                            Console.WriteLine("Player 1 has won");
                            Console.WriteLine("Thank You visit again the game");
                        }
                        else if (item == 'O')
                        {
                            Console.WriteLine("Player 2 has won");
                            Console.WriteLine("Thank You visit again the game");
                            do
                            {
                                Console.WriteLine("Press 1 to Continue");
                               // Console.WriteLine("Enter username:");

                                // Create a string variable and get user input from the keyboard and store it in the variable
                                int option = Convert.ToInt32(Console.ReadLine());

                                // Print the value of the variable (userName), which will display the input value
                               // Console.WriteLine("Option is: " + option);

                                switch(option)
                                {
                                    case 1:
                                        //Console.Clear();
                                        //EnterXorO(player, input);
                                        DrawBoard();

                                        break;
                                        // default: Console.WriteLine("Press only  1 to continue");
                                       // break;

                                }

                            } while (true);
                        }
                        break;


                    }
                }
                #endregion
                #region
                //This region is to check that this field is occupied or not

                do
                {
                    Console.WriteLine("\n Player {0}: Choose the Field", player);

                    try
                    {
                        input = Convert.ToInt32(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Hey! Please enter the number 1 - 9");
                        //throw;
                    }
                    //Checking for the input field is filled/occupied or not
                    if ((input == 1) && (playField[0, 0] == '1'))
                    {
                        inputCorrect = true;
                    }
                    else if ((input == 2) && (playField[0, 1] == '2'))
                    {
                        inputCorrect = true;
                    }
                    else if ((input == 3) && (playField[0, 2] == '3'))
                    {
                        inputCorrect = true;
                    }
                    else if ((input == 4) && (playField[1, 0] == '4'))
                    {
                        inputCorrect = true;
                    }
                    else if ((input == 5) && (playField[1, 1] == '5'))
                    {
                        inputCorrect = true;
                    }
                    else if ((input == 6) && (playField[1, 2] == '6'))
                    {
                        inputCorrect = true;
                    }
                    else if ((input == 7) && (playField[2, 0] == '7'))
                    {
                        inputCorrect = true;
                    }
                    else if ((input == 8) && (playField[2, 1] == '8'))
                    {
                        inputCorrect = true;
                    }
                    else if ((input == 9) && (playField[2, 2] == '9'))
                    {
                        inputCorrect = true;
                    }
                    else
                    {
                        Console.WriteLine("Please use another Field");
                        inputCorrect = false;

                    }
                } while (!inputCorrect);
                #endregion
                EnterXorO(player, input);
            } while (true);
            Console.WriteLine("Thank you!");

            Console.ReadLine();

        }

        private static void EnterXorO(int player,int input)
        {
            char playerSign = ' ';
            if (player == 1)
                playerSign = 'X';
            else if (player == 2)
                playerSign = 'O';
           
                
                //Player 1 or 2  Turn
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
                            default:
                                break;
                        }
                       

                

        }

        private static void DrawBoard()
        {
            //This is a method to draw 3*3 Board
            Console.Clear();
            Console.WriteLine("   |   |   ");
            Console.WriteLine(" {0} | {1} | {2}  ", playField[0, 0], playField[0, 1], playField[0, 2]);
            Console.WriteLine("___|___|___");
            Console.WriteLine("   |   |   ");
            Console.WriteLine(" {0} | {1} | {2}  ", playField[1, 0], playField[1, 1], playField[1, 2]);
            Console.WriteLine("___|___|___");
            Console.WriteLine("   |   |   ");
            Console.WriteLine(" {0} | {1} | {2}  ", playField[2, 0], playField[2, 1], playField[2, 2]);
            Console.WriteLine("   |   |   ");

        }
        
    }
}
