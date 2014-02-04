using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
//Files are in bin/debug
class FilesAndMatrixes
{
    static void Main(string[] args)
    {
        string[] lines  = File.ReadAllLines("Matrix.txt");
        int matrixSize = int.Parse(lines[0]);
        int[,] matrix = new int[matrixSize, matrixSize];
        string[] numberByNumber = new string[matrixSize];
        for (int i = 0; i < matrixSize; i++)
        {
            string[] s = lines[i + 1].Split(' ');
            for (int z = 0; z < s.Length; z++)
            {
                matrix[i, z] = int.Parse(s[z]);
            }
        }
        int sum = 0;
        int currentSum = 0;
        for (int i = 0; i < matrixSize - 1; i++)
        {
            for (int z = 0; z < matrixSize - 1; z++)
            {
                currentSum = matrix[i, z] + matrix[i, z + 1] + matrix[i + 1, z] + matrix[i + 1, z + 1];
                if (currentSum > sum)
                {
                    sum = currentSum;
                }
            }
        }
        StreamWriter writer =
            new StreamWriter("TheFile.txt");
        using (writer)
        {
            writer.WriteLine(sum);
        }
        Process.Start("TheFile.txt");
    }
}


