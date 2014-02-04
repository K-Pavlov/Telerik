using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class DecimalToHex
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter number: ");
        string number = Console.ReadLine();
        Console.WriteLine(AnyToAny.BaseXToBaseY(number, 10, 16));
    }
}
