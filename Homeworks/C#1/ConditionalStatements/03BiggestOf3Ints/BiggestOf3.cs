using System;

class BiggestOf3
{
    static int parseInt()
    {
        return int.Parse(Console.ReadLine());
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Pls give 3 ints");
        int num1 = parseInt(),
            num2 = parseInt(),
            num3 = parseInt();
        if (num1 > num2)
        {
            if (num1 > num3)
            {
                Console.WriteLine("The first number is bigger");
            }
            else
            {
                Console.WriteLine("The third number is bigger");
            }
        }
        else
        {
            if (num2 > num3)
            {
                Console.WriteLine("The second number is bigger");
            }
            else
            {
                Console.WriteLine("The thrird number is bigger");
            }
        }
    }
}

