using System;

class Bit3
{
    static void Main(string[] args)
    {
        Console.WriteLine("Pls give int");
        int i = int.Parse(Console.ReadLine());
        //Turbo ugly expression
        Console.WriteLine( ( (1 << 3 & i) >> 3) == 1 ? "3 bit is 1" : "3 bit is 0"); 
    }
}

