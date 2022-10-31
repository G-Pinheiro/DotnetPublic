using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardLogic
{
    public class Board
    {
        public int[] Grid
        {
            get;
            set;
        }

        public Board()
        {
            Grid = new int[9];
        }

        // Auxiliar functions
        // Print Grid function
        public void PrintBoard(int[] Grid)
        {
            Console.WriteLine();
            for (int i = 0; i < Grid.Length; i++)
            {
                switch (Grid[i])
                {
                    default:
                        break;
                    case 0:
                        Console.Write(".");
                        break;
                    case 1:
                        Console.Write("X");
                        break;
                    case 2:
                        Console.Write("O");
                        break;
                }

                if (i == 2 || i == 5 || i == 8)
                {
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
        }

        // Check if there is still available moves
        public bool AvailableMoves(int[] Grid)
        {
            for (int i = 0; i < Grid.Length; i++)
            {
                if (Grid[i] == 0)
                {
                    return true;
                }
            }
            Console.WriteLine("Withdraw: There are no moves left..");
            return false;
        }

        // Player turn function with input check.
        public void PlayerTurn(int[] Grid)
        {
            int Player;
            while (true)
            {
                Console.WriteLine("Enter a number to fill the Grid: ");
                //Accepts only numbers between 0 and 8
                if (!int.TryParse(Console.ReadLine(), out Player))
                {
                    Console.WriteLine("Type only numbers...");
                }
                else if (Player < 0 || Player > 8)
                {
                    Console.WriteLine("Type only numbers from 0 to 8...");
                }
                else
                {
                    if (Grid[Player] == 0)
                    {
                        Grid[Player] = 1;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Field already taken, choose another...");
                    }
                }
            }
        }

        // Pc turn function
        public bool PcTurn(int[] Grid)
        {
            Random rand = new Random();
            int Pc;
            while (true)
            {
                Pc = rand.Next(9);
                Console.WriteLine("Pc chosed " + Pc);
                if (Grid[Pc] == 0)
                {
                    Grid[Pc] = 2;
                    break;
                }
                else
                {
                    Console.WriteLine("Field already taken, choose another...");
                }
            }
            return true;
        }

        // Game rules to determine who won or when its finished.
        // Return true if there is no winner and false when there is a winner;
        public bool CheckMoves(int[] Grid)
        {
            // Vertical end game
            if ((Grid[0] == 1 || Grid[0] == 2) && Grid[0] == Grid[1] && Grid[1] == Grid[2])
            {
                WhoWon(Grid[0]);
                Console.WriteLine("Won 1");
                PrintBoard(Grid);
                return false;
            }
            else if ((Grid[3] == 1 || Grid[3] == 2) && Grid[3] == Grid[4] && Grid[4] == Grid[5])
            {
                WhoWon(Grid[3]);
                Console.WriteLine("Won 2");
                PrintBoard(Grid);
                return false;
            }
            else if ((Grid[6] == 1 || Grid[6] == 2) && Grid[6] == Grid[7] && Grid[7] == Grid[8])
            {
                WhoWon(Grid[6]);
                Console.WriteLine("Won 3");
                PrintBoard(Grid);
                return false;
            }
            // Horizontal end game
            if ((Grid[0] == 1 || Grid[0] == 2) && Grid[0] == Grid[3] && Grid[3] == Grid[6])
            {
                WhoWon(Grid[0]);
                Console.WriteLine("Won 4");
                PrintBoard(Grid);
                return false;
            }
            else if ((Grid[1] == 1 || Grid[1] == 2) && Grid[1] == Grid[4] && Grid[4] == Grid[7])
            {
                WhoWon(Grid[1]);
                Console.WriteLine("Won 5");
                PrintBoard(Grid);
                return false;
            }
            else if ((Grid[2] == 1 || Grid[2] == 2) && Grid[2] == Grid[5] && Grid[5] == Grid[8])
            {
                WhoWon(Grid[2]);
                Console.WriteLine("Won 6");
                PrintBoard(Grid);
                return false;
            }
            // Diagonal end game   
            if ((Grid[0] == 1 || Grid[0] == 2) && Grid[0] == Grid[4] && Grid[4] == Grid[8])
            {
                WhoWon(Grid[0]);
                Console.WriteLine("Won 7");
                PrintBoard(Grid);
                return false;
            }
            else if ((Grid[2] == 1 || Grid[2] == 2) && Grid[2] == Grid[4] && Grid[4] == Grid[6])
            {
                WhoWon(Grid[2]);
                Console.WriteLine("Won 8");
                PrintBoard(Grid);
                return false;
            }
            return true;
        }

        // Auxiliar CheckMoves function to show who won
        // 1 if player won, 2 if pc won, 0 if nobody won.
        public int WhoWon(int boardindex)
        {
            if (boardindex == 1)
            {
                Console.WriteLine("Player won!! Contragulations! ");
                return 1;
            }
            else if (boardindex == 2)
            {
                Console.WriteLine("Pc won!! Good luck next time! ");
                return 2;
            }
            return 0;
        }
    }
}
