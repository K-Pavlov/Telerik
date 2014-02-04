using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class LeapYear
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please give me the year.");
        int year = int.Parse(Console.ReadLine());
        Console.WriteLine(DateTime.IsLeapYear(year) == true ? "It's a leap year." : "Nope, just not a leap year.");
    }
}

