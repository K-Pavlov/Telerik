using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BinRepresentationOfHex
{
    static void Main(string[] args)
    {
        Console.Write("Enter number: ");
        short number = short.Parse(Console.ReadLine());
        Console.Write("Binary is: ");
        Console.WriteLine(Convert.ToString(number, 2));
    }
}

