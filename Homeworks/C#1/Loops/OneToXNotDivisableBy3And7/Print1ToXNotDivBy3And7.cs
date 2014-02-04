using System;

class Print1ToXNotDivBy3And7
{
    static void Main(string[] args)
    {
        Console.WriteLine("Pls give an int number");
        int num = int.Parse(Console.ReadLine());
        Console.WriteLine("The numbers from 1 to {0},not divideable by 3 and 7 are :", num);
        for (int i = 1; i <= num; i++)
        {
            if (i % 3 != 0)
            {             
                Console.WriteLine(i);
            }
            else
            {
                if (i % 7 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}

