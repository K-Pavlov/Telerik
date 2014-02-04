using System;
using System.Numerics;

class QuadronacciRectangle
{
    static BigInteger iP()
    {
        return BigInteger.Parse(Console.ReadLine());
    }

    static int Main(string[] args)
    {
        BigInteger[] numbers = new BigInteger[401];
        for(int i = 0; i < 4; i++)
        {
            numbers[i] = iP();
        }
        int rows = int.Parse(Console.ReadLine());
        int cols = int.Parse(Console.ReadLine());
        if (cols < 4)
        {
            return 0;
        }
        for (int i = 1; i <= rows; i++)
        {
            for (int j = cols*i - cols; j < cols*i; j++)
            {
                numbers[j+4] = numbers[j+3] + numbers[j+2] + numbers[j + 1] + numbers[j];
                Console.Write("{0}", numbers[j]);
                if (j != cols * i - cols - 1)
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
        return 0;
    }

}
