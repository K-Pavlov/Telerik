using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MaxSumOfElements
{
    static int Main(string[] args)
    {
        Console.WriteLine(
            "Pls give the matrix size");
        int N = int.Parse(Console.ReadLine());
        int M = int.Parse(Console.ReadLine());
        if (N < 3 || M < 3)
        {
            Console.WriteLine(
                "Bad parameters");
            return 1;
        }
        Console.WriteLine(
            "Pls give matrix elements");
        int[,] elements = new int[M,N];
        int counter = 0;
        for (int j = 0; j < N; j++)
        {
            counter = 0;
            string[] line = Console.ReadLine().Split(' ');
            foreach(string s in line)
			{
                elements[j, counter] = int.Parse(s);
                counter++;
                if (counter > M)
                {
                    Console.WriteLine(
                        "Wtf elements man");
                    return 1;
                }
			}
        }
        int[] maxSum = new int[N*M];
        int i = 0,
            k = 0;
        while (i + 2 < N)
        {
            while(k + 2 < M)
            {
                maxSum[k] = elements[i, k] + elements[i + 1, k] + elements[i + 2, k] + elements[i, k + 1] + elements[i, k + 2] + elements[i + 1, k + 1] + elements[i + 1, k + 2] + elements[i + 2, k + 1] + elements[i + 2, k + 2];
                k++;
            }
            i++;
        }
        Array.Sort(maxSum);
        Console.WriteLine(maxSum[maxSum.Length - 1]);
        return 0;
    }
}

