using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class WorkDays
{
    static void Main(string[] args)
    {
        DateTime then = new DateTime(2014, 5, 30);
        DateTime today = DateTime.Now;
        int count = 0;
        int timeLen = (then - today).Days;
        DateTime[] holidays =
        {
            new DateTime(2014, 5, 2),
            new DateTime(2014, 2, 2),
            new DateTime(2014, 3, 3),
            new DateTime(2014, 4, 4),
            new DateTime(2014, 1, 18)
        };
        bool isHoliday = false;
        for (int i = 0; i < timeLen; i++)
        {
            if (today.DayOfWeek != DayOfWeek.Sunday && today.DayOfWeek != DayOfWeek.Saturday)
            {
                for (int j = 0; j < holidays.Length; j++)
                {
                    if (holidays[j] == today)
                    {
                        isHoliday = true;
                        break;
                    }
                }
                if (isHoliday == false) count++;
            }
            today = today.AddDays(1);
        }
        Console.WriteLine(count);
    }
}

