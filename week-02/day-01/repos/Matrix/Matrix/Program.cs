using System;

namespace DiagonalMatrix
{
    class Program
    {
        // - Create (dynamically) a two dimensional array
        //   with the following matrix. Use a loop!
        //
        //   1 0 0 0
        //   0 1 0 0
        //   0 0 1 0
        //   0 0 0 1
        //
        // - Print this two dimensional array to the output

        static void Main(string[] args)
        {
            int[,] diagonalMatrix = new int[4, 4];

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (i == j)
                    {
                        diagonalMatrix[i, j] = 1;
                    }
                    else
                    {
                        diagonalMatrix[i, j] = 0;
                    }
                    Console.Write(diagonalMatrix[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}