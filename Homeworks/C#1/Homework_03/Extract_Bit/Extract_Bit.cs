using System;

class Extract_Bit
{
    static void Main(string[] args)
    {
        Console.WriteLine("Pls give number and bit");
        int n = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int bit = (1 << b & n) >> b;
        Console.WriteLine("Bit " +b+ " is " +bit );
    }
}

