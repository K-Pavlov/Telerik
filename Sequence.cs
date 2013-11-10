using System;

class Program
{
    static void Main(string[] args)
    {
        int i = 2;
        while (i < 12)
        {
            Console.WriteLine(i % 2 == 0 ? i : -i);
            i++;
        }
    }
}

