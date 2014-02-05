using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    class GSMCallHistoryTest
    {
        private static GSM gsm = new GSM(
            "Xperia", "Sony", "SomeDude2", 200f,
            new Battery("someModel2", 600, 100, BatteryType.LiPoly),
            new Display(35, 5000));

        private static void PrintDetails(GSM myPhone)
        {
            for (int i = 0; i < myPhone.CallHistory.Count; i++)
            {
                Console.WriteLine("Call #{0}", i + 1);
                Console.WriteLine("Date made: {0}", myPhone.CallHistory[i].DateTime);
                Console.WriteLine("Dialed number: {0}", myPhone.CallHistory[i].NumberDialed);
                Console.WriteLine("Duration in seconds: {0}", myPhone.CallHistory[i].CallDurationInSeconds);
                Console.WriteLine();
            }
        }
        public void TestCalls()
        {
            gsm.AddCall("5/1/2008 8:30:52 AM", 2030, 120);
            gsm.AddCall("6/1/2008 10:50:52 AM", 3040, 360);
            gsm.AddCall("7/1/2008 11:33:52 AM", 4050, 200);

            PrintDetails(gsm);

            Console.WriteLine("Total Call Cost: {0:0.00}$\n", gsm.GetCallsCost(0.37f));

            float longestDuration = gsm.CallHistory[0].CallDurationInSeconds;
            for (int i = 1; i < gsm.CallHistory.Count; i++)
            {
                if (gsm.CallHistory[i].CallDurationInSeconds > longestDuration)
                {
                    longestDuration = gsm.CallHistory[i].CallDurationInSeconds;
                }
            }

            gsm.RemoveCall(longestDuration);
            Console.WriteLine("Total Call Cost After Longest Call Removal: {0:0.00}$\n", gsm.GetCallsCost(0.37f));
            gsm.ClearCallHistory();
            Console.WriteLine("Now cleared\n");
            PrintDetails(gsm);

        }
    }
}
