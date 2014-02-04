using System;

class Ex11
{
    static void Main()
    {
        for (int i = 1; i <= 4; i++)
        {
            for (int j = 1; j <= 12; j++)
            {
                switch (j)
                {
                    case 1: Console.Write("Ace of "); break;
                    case 2: Console.Write("Second of "); break;
                    case 3: Console.Write("Third of "); break;
                    case 4: Console.Write("Fourth of "); break;
                    case 5: Console.Write("Fifth of "); break;
                    case 6: Console.Write("Sixth of "); break;
                    case 7: Console.Write("Seventh of "); break;
                    case 8: Console.Write("Eight of "); break;
                    case 9: Console.Write("Nineght of "); break;
                    case 10: Console.Write("Jack of "); break;
                    case 11: Console.Write("Queen of "); break;
                    case 12: Console.Write("King of "); break;
                }
                switch (i)
                {
                    case 1: Console.WriteLine("Clubs"); break;
                    case 2: Console.WriteLine("Diamonds"); break;
                    case 3: Console.WriteLine("Hearts"); break;
                    case 4: Console.WriteLine("Spades"); break;
                }

            }

        }
    }
}

