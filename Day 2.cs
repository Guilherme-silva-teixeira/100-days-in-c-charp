//this is a example of tic-tac-toe game

using System;

namespace _100_days_c_
{
    public class project2
    {
        public static void Main(string[] args)
        {
            string[,] arr = new string[2, 2];
            string playerX = "X";
            string playerY = "O";
            int row, col;
            string atualplayer = playerX;
            while (true)
            {
                Console.WriteLine("Insert the row here: ");
                row = int.Parse(Console.ReadLine());
                Console.WriteLine("Insert thr column here: ");
                col = int.Parse(Console.ReadLine());
                if (atualplayer == playerX)
                {
                    atualplayer = playerY;
                }
                else
                {
                    atualplayer = playerX;
                }
                arr[row, col] = atualplayer;
                for (int i = 0 ; i<=2; i++)
                { 
                    for (int j = 0 ; j<=2; j++)
                    {
                        Console.WriteLine(arr[i, j]);
                    }
                    Console.WriteLine("\n");
                }
            }
        }
    }
}
