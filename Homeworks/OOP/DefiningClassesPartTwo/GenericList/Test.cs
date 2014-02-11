using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    class Test
    {
        public static int Main()
        {
            GenericList<int> list = new GenericList<int>(20);
            for (int i = 0; i <= 45; i++)
            {
                list.AddElement(i + 5);
            }
            list.RemoveElement(5);
            Console.Write("Elements: ");
            for (int i = 0; i <= list.Size() - 1; i++)
            {
                Console.Write(list.GetElement((uint)i));
                if (i < list.Size() - 1)
                {
                    Console.Write(",");
                }
            }
            Console.WriteLine("\n{0}",list.FindElementByVal(40));
            Console.WriteLine(list.Min());
            Console.WriteLine(list.Max());
            Console.WriteLine(list.ToString());
            return 0;
        }
    }
}
