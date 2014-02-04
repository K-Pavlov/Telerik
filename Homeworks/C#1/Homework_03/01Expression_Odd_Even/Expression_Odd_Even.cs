using System;

class Odd_Even
{
    static void Main(string[] args)
    {
        int i;
        Console.WriteLine("Pls give integer");
        i = int.Parse(Console.ReadLine());
        Console.WriteLine(i % 2 == 0 ? "Integer is even" : "Integer is odd"); 
    }
}

