using System;

class DrukenNumbers
{
    public static int ToInt(char c)
    {
        return (int)(c - '0') ;
    }

    public static void Main()
    {
        int rounds = int.Parse(Console.ReadLine());
        string[] drunkenNumber = new String[rounds+1];
        int M = 0,V = 0;
        int counter = 0;
        
        for (int i = 0; i < rounds; i++)
        {

            drunkenNumber[i] = Console.ReadLine().TrimStart('0');
            if (drunkenNumber[i].Length % 2 == 0)
            {
                counter = 0;
                foreach(char c in drunkenNumber[i])
                {
                    if (counter < drunkenNumber[i].Length * 0.5)
                    {                        
                        M += Math.Abs(ToInt(c));
                    }
                    else
                    {                        
                        V += Math.Abs(ToInt(c));
                    }
                    counter++;
                }
            }
            else
            {
                counter = 0;
                foreach (char c in drunkenNumber[i])
                {
                    if (counter < (Math.Round(drunkenNumber[i].Length * 0.5, MidpointRounding.AwayFromZero)-1))
                    {
                        M += Math.Abs(ToInt(c));
                    }
                    else if (counter == (Math.Round(drunkenNumber[i].Length * 0.5, MidpointRounding.AwayFromZero)-1))
                    {
                        M += Math.Abs(ToInt(c));
                        V += Math.Abs(ToInt(c));                        
                    }
                    else
                    {
                        V += Math.Abs(ToInt(c));
                    }
                    counter++;
                }
            }
        }
        if (M != V)
        {
            Console.WriteLine(M > V ? "M " + (M - V) : "V " + (V - M));
        }
        else
        {
            Console.WriteLine("No {0}",M+V);
        }
    }
}
