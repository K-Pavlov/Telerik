using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

class AddingNumberToLines
{
    static void Main(string[] args)
    {
        StreamReader reader =
            new StreamReader("File1.txt");
        int lineCount = 0;
        var lines = new List<string>();
        lines.Add(reader.ReadLine());
        using (reader)
        {
            while (lines[lineCount] != null)
            {
                lines.Add(reader.ReadLine());
                lineCount++;
            }
        }
        StreamWriter writer =
            new StreamWriter("TheFile.txt");
        using (writer)
        {
            for (int i = 0; i < lines.Count - 1; i++)
            {
                writer.Write("{0}: ",i+1);
                writer.WriteLine(lines[i]);
            }
        }
        Process.Start("TheFile.txt");
    }
}

