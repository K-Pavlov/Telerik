using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SumCalc
{
    static void Main(string[] args)
    {
        Console.WriteLine("Give me the numbers.");
        string[] numberByNumber = Console.ReadLine().Split(' ');
        int[] numbers = new int[numberByNumber.Length];

        int counter = 0;
        foreach (string number in numberByNumber)
        {
            numbers[counter] = int.Parse(number);
            counter++;
        }

        int sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
        Console.WriteLine("The sum is: {0}", sum);
    }
}

