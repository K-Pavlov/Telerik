using System;

class ReadIntegers
{
    static int parseIntegers(int num)
    {
        num = int.Parse( Console.ReadLine() );
        return num;
    }
    static void Main(string[] args)
    {
        int num1 = 0, num2 = 0, num3 = 0;
        Console.WriteLine("pls give three integers");
        num1 = parseIntegers(num1);
        num2 = parseIntegers(num2);
        num3 = parseIntegers(num3);
        int sum = num1 + num2 + num3;
        Console.WriteLine("{0} + {1} + {2} = {3}",num1,num2,num3,sum);
    }
}

