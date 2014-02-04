using System;
using System.Collections.Generic;

namespace Ex01FillMatrix
{
    class FillMatrix
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = i + 1 + n * (j);
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            int number = 1;
            for (int col = 0; col < n; col++)
            {
                if (col % 2 == 1)
                {
                    for (int row = n - 1; row >= 0; row--)
                    {
                        matrix[row, col] = number;
                        number++;
                    }
                }

                if (col % 2 == 0)
                {
                    for (int row = 0; row < n; row++)
                    {
                        matrix[row, col] = number;
                        number++;
                    }
                }

            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            number = 1;
            for (int row = 0; row <= n - 1; row++)
            {
                for (int col = 0; col <= row; col++)
                {
                    matrix[n - row + col - 1, col] = number;
                    number++;
                }
            }

            for (int row = n - 2; row >= 0; row--)
            {
                for (int col = row; col >= 0; col--)
                {
                    matrix[row - col, n - col - 1] = number;
                    number++;
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}