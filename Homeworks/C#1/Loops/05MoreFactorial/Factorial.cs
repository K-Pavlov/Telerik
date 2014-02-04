using System;

class CalculateFactorialDivision
{
    static int intParser()
    {
        return int.Parse(Console.ReadLine());
    }

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
        Console.WriteLine(
            "Pls give two numbers, N first then K, for the factorial divison(ints pls)");
        Console.WriteLine("1<N<K");
        int N = 0, K = 0;
        do
        {
            N = intParser();
            K = intParser();
            if (1 >= N || N >= K)
            {
                Console.WriteLine("Bad input");
            }
        } while (1 >= N || N >= K);

        Console.WriteLine("The division of these two factorials is {0}", factorial(N)*factorial(K) / factorial(K-N));
    }
}