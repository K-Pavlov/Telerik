using System;
using System.Numerics;

class FibTo100
{
    static void Main(string[] args)
    {
        Console.WriteLine("How many fibs do you want");
        int N = int.Parse(Console.ReadLine());
        BigInteger[] fib = new BigInteger[N+1];
        fib[0] = 0;
        fib[1] = 1;
        Console.WriteLine("{0}\n{1}", fib[0], fib[1]);
        Console.WriteLine(Console.BufferWidth);
        for (int i = 1; i < N; i++)
        {
            Console.WriteLine(fib[i+1] = fib[i] + fib[i - 1]);
        }
    }
}

