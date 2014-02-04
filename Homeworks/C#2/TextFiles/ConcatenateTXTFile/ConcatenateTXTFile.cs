using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
//Files are in bin/debug
class ConcatenateTXTFile
{
    static void Main(string[] args)
    {
        StreamReader reader =
            new StreamReader("File1.txt");
        StreamReader reader1 =
            new StreamReader("File2.txt");
        var line = new List<string>();
        var line1 = new List<string>();
        using (reader)
        {            
            line.Add(reader.ReadLine());
            line1.Add(reader1.ReadLine());
            int lineCount = 0;
            while (line[lineCount] != null)
            {
                line.Add(reader.ReadLine());
                lineCount++;
            }
            lineCount = 0;
            while (line1[lineCount] != null)
            {
                line1.Add(reader1.ReadLine());
                lineCount++;
            }
           
        }

        StreamWriter streamWriter =
            new StreamWriter("TheFile.txt");
        using (streamWriter)
        {
            for (int number = 0; number < line.Count; number++)
            {
                streamWriter.WriteLine(line[number]);
            }
            for (int number = 0; number < line1.Count; number++)
            {
                streamWriter.WriteLine(line1[number]);
            }
        }
        Process.Start("TheFile.txt");
    }
}

