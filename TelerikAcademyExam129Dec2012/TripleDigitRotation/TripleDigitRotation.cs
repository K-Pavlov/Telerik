using System;

class TripleDigitRotation
{
    static void Main(string[] args)
    {     
        int input = int.Parse(Console.ReadLine());
        int numLen = input.ToString().Length;
        int holder = 0;
        for (int i = 0; i < 3; i++)
        {
            if (numLen == 1)
            {
                break;
            }
            holder = input % 10;
            if (holder == 0)
            {
                input = input / 10;
                numLen--;
            }
            else
            {
                input = input / 10 + (int)Math.Pow(10, numLen - 1) * holder;
            }
            
        }
        Console.WriteLine(input);
    }
}

