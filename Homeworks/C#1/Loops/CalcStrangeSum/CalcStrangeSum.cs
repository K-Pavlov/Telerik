using System;

class CalcStrangeSum
{
    static int factorial(int num)
    {
        int quotient = 1;
        for (int i = 1; i <= num; i++)
        {
            quotient *= i;
        }
        return quotient;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("First give N then X");
        int N = int.Parse(Console.ReadLine()),
            X = int.Parse(Console.ReadLine()),
            sum = 1, temp;
        for (int i = 1; i <= N; i++)
        {
            temp = 1;
            for(int k = 0 ; k <= i; k++)
            {
                temp *= X;
            }
            sum += factorial(i) / temp;
        }
        Console.WriteLine("The result is {0}",sum);
    }
}

