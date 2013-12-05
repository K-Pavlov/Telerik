using System;
using System.Collections.Generic;
using System.Linq;


class IvoTheGod
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        int wid = 3 * N + 1;
        int hei = 2*N;
        int[,] matrix = new int[hei,wid];
        int currentHei = 0;
        int currentWid = 0;
        while (true)
        {
            matrix[currentHei, currentWid] = 0;
            if (currentHei == 0 || currentHei == hei - 1)
            {
                if (currentWid > N && currentWid < wid-N - 1)
                {
                    matrix[currentHei, currentWid] = 1;
                }
            }
            if(currentHei == N/2 + N/2 - 1 || currentHei == N/2 + N/2 )
            {
                if (currentWid > 1 && currentWid < wid - 2)
                {
                    if (currentHei % 2 == 0)
                    {
                        if (currentWid % 2 != 0)
                        {
                            matrix[currentHei, currentWid] = 2;
                        }
                    }
                    else
                    {
                        if (currentWid % 2 == 0)
                        {
                            matrix[currentHei, currentWid] = 2;
                        }
                    }
                }
                if(currentWid == 1 || currentWid == wid - 2)
                {                    
                    matrix[currentHei, currentWid] = 1;
                }
            }

            if (N * 2 > 4)
            {
                if ( currentHei > 0 && currentHei < N / 2 + N / 2 - 1)
                {
                    if (currentWid == N - (currentHei == 1 ? currentHei : currentHei + 1) || currentWid == wid - N + (currentHei == 1 ? currentHei : currentHei + 1) - 1)
                    {
                        matrix[currentHei, currentWid] = 1;
                    }
                }
                else if (currentHei > N / 2 + N / 2 && currentHei < hei - 1)
                {
                    
                    if (currentWid == Math.Abs(N - (currentHei == hei - 2 ? currentHei + 1 : currentHei)) )
                    {
                        matrix[currentHei, currentWid] = 1;
                    }
                    if (currentHei != hei - 2)
                    {
                        if (currentWid == wid - Math.Abs(N - currentHei) - 1)
                        {
                            matrix[currentHei, currentWid] = 1;
                        }
                    }
                    else
                    {
                        if (currentWid == wid - Math.Abs(N - currentHei) - 2)
                        {
                            matrix[currentHei, currentWid] = 1;
                        }
                    }
                }
            }
            
            currentWid++;

            if (currentWid == wid - 1)
            {
                currentHei++;             
            }            
            if (currentHei == hei - 1)
            {
                for (int i = 0; i < wid - 1; i++)
                {
                    if (i > N && i < wid - N - 1)
                    {
                        matrix[currentHei, i] = 1;
                    }
                }
            }

            if (currentWid == wid - 1)
            {
                currentWid = 0;
            }
            
            if (currentHei == hei - 1)
            {
                break;
            }
        }

        for (int i = 0; i < hei; i++)
        {
            for (int j = 0; j < wid; j++)
            {
                if (matrix[i, j] == 0)
                {
                    Console.Write(".");
                }
                if (matrix[i, j] == 1)
                {
                    Console.Write("*");
                }
                if (matrix[i, j] == 2)
                {
                    Console.Write("@");
                }
            }
            Console.WriteLine();
        }
    }
}

