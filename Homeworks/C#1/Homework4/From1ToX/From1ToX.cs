using System;

class From1ToX
{
    static void Main(string[] args)
    {
        Console.WriteLine("Pls give integer number and i prints from 1 to number");
        int num = int.Parse(Console.ReadLine());
        for(int i = 1; i <= num; i++)
        {
            Console.WriteLine(i);
        }
    }
}

