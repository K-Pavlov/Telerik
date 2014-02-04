using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class DayOfTheWeek
{
    static void Main(string[] args)
    {
        DateTime ClockInfoFromSystem = DateTime.Now;
        Console.WriteLine("They day today is: {0}", ClockInfoFromSystem.DayOfWeek);
    }
}

