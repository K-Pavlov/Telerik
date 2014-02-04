using System;

class Biggest
{
    static int parseInt()
    {
        return int.Parse(Console.ReadLine());
    }
    static void Main(string[] args)
    {
        int[] varArr = new int[5];
        for (int i = 0; i < varArr.Length; i++)
        {
            varArr[i] = parseInt();
        }

        Array.Sort(varArr);

        Console.WriteLine("The biggest number is {0}", varArr[varArr.Length - 1]);
    }
}

