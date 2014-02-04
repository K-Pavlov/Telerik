using System;

class Bit_Exchange
{
    static void Main(string[] args)
    {
        Console.WriteLine("Pls give a quite big positive int");
        uint i = uint.Parse(Console.ReadLine()); 
        int num = 3;
        uint bit1, bit2,changer;
        while (num <= 5)
        {
            bit1 = ((uint)1 << num & i)>>num; 
            bit2 = ((uint)1 << (num - 3) & i)>>num-3;
            changer = bit1;
            bit1 = bit2;
            bit2 = changer;
            i = bit1 == 1 ? i | (bit1 << num): i & (bit1<<num);
            i = bit2 == 1 ? i | (bit2 << num-3) : i & (bit2 << num-3);
            num++;            
        }
        Console.WriteLine("Now i is " + i);
    }
}

