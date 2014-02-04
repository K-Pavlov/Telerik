using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

//FIles are in bin/debug
class CompareTXTFiles
{
    static void Main(string[] args)
    {
        string[] lines = File.ReadAllLines("File1.txt");
        string[] lines1 = File.ReadAllLines("File2.txt");
        int isSame = 0;
        int isNotSame = 0;

        for (int i = 0; i < lines.Length && i < lines1.Length; i++)
        {
            if (lines[i] == lines1[i])
            {
                isSame++;
            }
            else
            {
                isNotSame++;
            }
        }

        Console.WriteLine("Same lines {0}, different lines {1}.",isSame,isNotSame);
    }
}

