using System;

class Third_Digit
{
    static void Main(string[] args)
    {
        Console.WriteLine("Pls give int");
        int i = int.Parse(Console.ReadLine());
        Console.WriteLine((i % 1000)/100 == 7 ? "Third digit is 7":"Third digit is not 7");
    }
}

