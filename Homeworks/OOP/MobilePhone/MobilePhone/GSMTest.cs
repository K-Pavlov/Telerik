using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    class GSMTest
    {
        private static GSM[] array = 
        {
            new GSM(
                "iPhone", "Apple","SomeDude",300f,  new Battery("someModel1",800, 200, BatteryType.LiIon),new Display(30,5000)),
            new GSM(
                "Xperia", "Sony", "SomeDude2",200f, new Battery("someModel2",600, 100, BatteryType.LiPoly), new Display(35,5000)),
            new GSM(
                "4ka", "Tuhla", "SomeDude3",300f,new Battery("someModel3",760, 230, BatteryType.NiMH), new Display(32,5000))
        };

        public void DisplayInfo()
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Phone {0}:", i + 1);
                Console.WriteLine(array[i]);
            }
            Console.WriteLine("Iphone 4s:");
            Console.WriteLine(GSM.iPhone4s);
        }
    }
}
