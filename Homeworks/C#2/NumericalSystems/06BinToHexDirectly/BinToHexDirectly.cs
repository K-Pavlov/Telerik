using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BinToHexDirectly
{
    static void Main(string[] args)
    {
        Console.WriteLine("Give me the number");
        string strBinary = Console.ReadLine();
        string strHex = Convert.ToInt32(strBinary, 2).ToString("X");
        Console.WriteLine("Number in hex is: {0}",strHex); 
    }
}

