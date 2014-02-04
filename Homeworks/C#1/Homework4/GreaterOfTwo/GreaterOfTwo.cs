using System;

class GreaterOfTwo
{
    static void Main(string[] args)
    {
        Console.WriteLine("Pls give two numbers");
        int num1 = int.Parse(Console.ReadLine()), num2 = int.Parse(Console.ReadLine());
        Console.WriteLine("The bigger one is {0}", Math.Max(num1,num2));
    }
}

