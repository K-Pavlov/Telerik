using System;

class CatalanNumber
{
    static decimal factorial(decimal num)
    {
        decimal quotient = 1;
        for (int i = 1; i <= num; i++)
        {
            quotient *= i;
        }
        return quotient;
    }

    static void Main(string[] args)
    {
        decimal catalanNumber = 0;
        Console.WriteLine("Which catalan number do u want?");
        decimal N = decimal.Parse(Console.ReadLine());
        catalanNumber = factorial(2 * N)/(factorial(N+1)*factorial(N));
        Console.WriteLine("The number is {0}", catalanNumber);
    }
}



