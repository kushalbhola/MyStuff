using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice.Leetcode
{
    class TicTacToe
    {
        public int[,] addToken(int[,] Board, int i, int j, int value)
        {
            //check later to see if i j empty
            Board[i, j] = value;
            return Board;
        }
        public static void printBoard(int[,] Board)
        {
            int len = Board.GetLength(0);
            int width = Board.GetLength(1);
            for (int i = 0; i < len; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (Board[i, j] == 1 && j == width - 1)
                        Console.Write(Board[i, j] + "|");
                    else if (Board[i, j] == 1 && j != width - 1)
                        Console.Write(Board[i, j]);
                    else
                    {
                        if (j != width - 1)
                            Console.Write("-" + "|");
                        else
                            Console.Write("-");

                    }
                        
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
        public bool isFull()
        {
            return false;
        }

        public static void Main(String[] args)
        {
            int[,] Board = new int[3,3];
            printBoard(Board);
        }
    }
}

