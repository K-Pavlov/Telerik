using System;

class Division
{
    static void Main(string[] args)
    {
        Console.WriteLine("Pls give integer");
        int i = int.Parse(Console.ReadLine());
        Console.WriteLine((i%5 == 0 && i%7 == 0)? true : false);
    }
}

