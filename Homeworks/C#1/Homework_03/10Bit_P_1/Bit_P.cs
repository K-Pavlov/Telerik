using System;

class Bit_P
{
    static void Main(string[] args)
    {
        Console.WriteLine("Pls give number and bit");
        int n = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        //Another ugly expression 
        Console.WriteLine(((1 << b & n) >> b) == 1 ? true : false); 
    }
}

