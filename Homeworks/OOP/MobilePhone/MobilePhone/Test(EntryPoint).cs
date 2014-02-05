using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    class Test
    {
        public static void Main()
        {
            GSMTest test = new GSMTest();
            test.DisplayInfo();
            GSMCallHistoryTest testCalls = new GSMCallHistoryTest();
            testCalls.TestCalls();
        }
    }
}
