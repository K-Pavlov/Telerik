using System;

class XNumbersBetweenNumbers
{
    static void Main(string[] args)
    {
        byte i = 0;

        uint num1 = uint.Parse(Console.ReadLine()), num2 = uint.Parse(Console.ReadLine());

        if(num2 > num1)
        {
            uint tmp = num1;
            num1 = num2;
            num2 = tmp;
        }
        for (uint k = num2; num1 >= k; k++)
        {
            if (k % 5 == 0)
            {
                i++;
            }
        }
        Console.WriteLine(num1);
        Console.WriteLine(num2);
        Console.WriteLine("Numbers betweem {0} and {1} which when divided by 5 have 0 reminder are {2}", num1, num2, i);
    }
}

