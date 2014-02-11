using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericMatrix
{
    class Test
    {
        public static void Main()
        {
            Matrix<int> matrix1 = new Matrix<int>(3, 3);
            Matrix<int> matrix2 = new Matrix<int>(3, 3);

            // Fill with random numbers
            Random randomGenerator = new Random();
            for (int i = 0; i < matrix1.Rows; i++)
            {
                for (int j = 0; j < matrix1.Cols; j++)
                {
                    matrix1[i, j] = randomGenerator.Next(20);
                    matrix2[i, j] = randomGenerator.Next(20);
                }
            }

            Console.WriteLine("Matrix 1");
            Console.WriteLine(matrix1);

            Console.WriteLine("Matrix 2");
            Console.WriteLine(matrix2);

            Console.WriteLine("Matrix 1 + Matrix 2");
            Console.WriteLine(matrix1 + matrix2);

            Console.WriteLine("Matrix 1 - Matrix 2");
            Console.WriteLine(matrix1 - matrix2);

            Console.WriteLine("Matrix 1 * Matrix 2");
            Console.WriteLine(matrix1 * matrix2);

            Console.WriteLine(matrix1 ? "Not empty" : "Empty");

            Matrix<int> matrix3 = new Matrix<int>(3, 5);
            Console.WriteLine(matrix3 ? "Not empty" : "Empty");
        }
    }
}
