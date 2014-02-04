using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class RandomValues //10 between 100-200
{
    static void Main(string[] args)
    {
        Random rand = new Random();
        Console.WriteLine("10 random numbers:");
        for (int i = 0; i < 10; i++)
        {
            if (i == 0)
            {
                Console.Write("{0}", rand.Next(100, 200));
            }
            else
            {
                Console.Write(", {0}", rand.Next(100, 200));
            }
        }
        Console.WriteLine();
    }
}

