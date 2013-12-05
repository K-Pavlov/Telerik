using System;

class UKFlag
{
    static void Main()
    {
        int heiWid = int.Parse(Console.ReadLine());
        int[,] matrix = new int[heiWid, heiWid];
        int hei = 0;
        int wid = 0;
        int counter =0 ;
        while (true)
        {   
            matrix[hei, wid] = 1;
            if ((hei + wid) / 2 == heiWid / 2 && hei != heiWid / 2 && (hei + wid) % 2 == 0)
            {
                matrix[hei, wid] = 2;
            }
            if (heiWid - hei == heiWid - wid)
            {
                matrix[hei, wid] = 7;
            }
            if (wid == heiWid / 2)
            {
                matrix[hei, wid] = 4;
            }

            if (hei == heiWid / 2)
            {
                matrix[hei, wid] = 3;
            }
            if (hei == heiWid / 2 && wid == heiWid / 2)
            {
                matrix[hei, wid] = 5;
            }

            wid++;
            if (wid == heiWid)
            {
                hei++;
                wid = 0;
            }   

            if (hei == heiWid)
            {
                break;
            }                 
        }
        for (int i = 0; i < heiWid; i++)
        {
            for (int j = 0; j < heiWid; j++)
            {
                if (matrix[i, j] == 7)
                {
                    Console.Write("\\");
                }
                if (matrix[i, j] == 1)
                {
                    Console.Write(".");
                }
                if (matrix[i, j] == 2)
                {
                    Console.Write("/");
                }
                if (matrix[i, j] == 3)
                {
                    Console.Write("-");
                }
                if (matrix[i, j] == 4)
                {
                    Console.Write("|");
                }
                if (matrix[i, j] == 5)
                {
                    Console.Write("*");
                }
            }
            Console.WriteLine();
        }
    }
}

