using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class HexToBinDirectly
{
    static void Main(string[] args)
    {
        Console.WriteLine("Give me the number");
        string hex = Console.ReadLine();
        string binary = "";
        binary = Convert.ToString(Convert.ToInt32(hex, 16), 2);
        Console.WriteLine("The number in binary is: {0}", binary);
    }
}

