using System;

class GCD
{
    static void Main()
    {
        Console.WriteLine("Give the two numbers");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        while (b != 0)
        {
            int t = b;
            b = a % b;
            a = t;
        }
        Console.WriteLine(a);
    }
}

