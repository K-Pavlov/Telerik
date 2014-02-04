using System;

class XNumberCalc
{
    static void Main(string[] args)
    {
        float sum = 0;
        Console.WriteLine("Pls give how much numbers you will sum");
        int n = int.Parse(Console.ReadLine());
        while(n!=0)
        {
            Console.WriteLine("Pls give something to sum");
            sum += float.Parse(Console.ReadLine());
            n--;
        }
        Console.WriteLine("Sum is {0}", sum);
    }
}

