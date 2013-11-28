using System;
using System.Runtime.InteropServices;

class MaxAndMin
{
    static void intParser(ref int num)
    {
        num = int.Parse(Console.ReadLine());
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Pls give how many integers you want to compare");
        int count = 0;
        intParser(ref count);
        int[] arr = new int[count];
        for (int i = 0; i < arr.Length; i++)
        {
            intParser(ref arr[i]);
        }
        Array.Sort(arr);
        Console.WriteLine("Smallest num is {0} and biggest num is {1}",arr[0],arr[arr.Length-1]);
    }
}

