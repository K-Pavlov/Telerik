using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ElementSearch
{
    static int Main(string[] args)
    {
        Console.WriteLine(
            "Pls give the matrix size");
        int N = int.Parse(Console.ReadLine());
        int M = int.Parse(Console.ReadLine());
        Console.WriteLine(
            "Pls give matrix elements");
        string[,] elements = new string[M, N];
        int counter = 0;
        for (int j = 0; j < N; j++)
        {
            counter = 0;
            string[] line = Console.ReadLine().Split(' ');
            foreach (string s in line)
            {
                elements[j, counter] = s;
                counter++;
            }

        }
        int currCount = 1;
        int maxCount = 1;
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < M - 1; j++)
            {
                if (elements[i, j] == elements[i, j + 1])
                {
                    currCount++;
                }
                else
                {
                    if (currCount > maxCount)
                    {
                        maxCount = currCount;
                    }
                    currCount = 1;
                }
            }
        }
        
        for (int i = 0; i < M - 1; i++)
        {
            for (int j = 0; j < N ; j++)
            {
                if (elements[i, j] == elements[i+1,j])
                {
                    currCount++;
                }
                else
                {
                    if (currCount > maxCount)
                    {
                        maxCount = currCount;
                    }
                    currCount = 1;
                }
            }
        }

        int elementCount = N - 1;
        int copy = 0;
        for(int i = 0; i < M-1; i++)
        {
            copy = i;
            for (int j = 0; j < elementCount; j++)
            {
                if (elements[copy, j] == elements[copy + 1, j+1])
                {
                    currCount++;
                }
                else
                {
                    if (currCount > maxCount)
                    {
                        maxCount = currCount;
                    }
                    currCount = 1;
                }
                if (copy == M - 2)
                {
                    if (currCount > maxCount)
                    {
                        maxCount = currCount;
                    }
                    currCount = 1;
                }
                copy++;                
            }
            elementCount--;
        }

        elementCount = N - 1;
        for (int i = M-1; i > 0; i--)
        {
            copy = i;
            for (int j = N-1; j > 0; j--)
            {
                if (elements[copy, j] == elements[copy -1, j - 1])
                {
                    currCount++;
                }
                else
                {
                    if (currCount > maxCount)
                    {
                        maxCount = currCount;
                    }
                    currCount = 1;
                }
                if (copy == 1)
                {
                    
                    if (currCount > maxCount)
                    {
                        maxCount = currCount;
                    }
                    currCount = 1;
                }
                copy--;
                if (copy - 1 < 0)
                {
                    break;
                }
            }
            elementCount--;
        }    
        Console.WriteLine(
            "Max seq is: {0}", maxCount);
        return 0;
    }
}


