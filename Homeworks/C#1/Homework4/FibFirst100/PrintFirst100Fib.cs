using System;
using System.Numerics;
class PrintFirst100Fib
{
    static void Main(string[] args)
    {
        Console.WriteLine("Gonna print 100 fibs");
        System.Threading.Thread.Sleep(4000);
        BigInteger[] fib = new BigInteger[101];
        fib[0] = 0;
        fib[1] = 1;
        fib[2] = 1;
        Console.WriteLine("{0}\n{1}\n{2}", fib[0], fib[1], fib[2]);
        for (int i = 3; i <= 100; i++)
        {
            Console.WriteLine( fib[i] = fib[i-1] + fib[i-2] );
        }
    }
}

