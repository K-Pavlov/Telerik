using System;

class ExhangeVal
{
    static void Main(string[] args)
    {
        Console.WriteLine("pls give 2 integers");
        int num1 = int.Parse(Console.ReadLine()), num2 = int.Parse(Console.ReadLine());
        if (num1 > num2)
        {
            int temp;
            temp = num1;
            num1 = num2;
            num2 = temp;
        }
        Console.WriteLine("First num now is {0} and second is {1}",num1,num2);
    }
}

