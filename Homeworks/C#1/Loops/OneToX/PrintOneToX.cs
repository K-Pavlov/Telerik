using System;

class PrintOneToX
{
    static void Main(string[] args)
    {
        Console.WriteLine("Pls give an int number");
        int num = int.Parse(Console.ReadLine());
        Console.WriteLine("The numbers from 1 to {0} are :", num);
        for (int i = 1; i <= num; i++)
        {
            Console.WriteLine(i);
        }
    }
}

