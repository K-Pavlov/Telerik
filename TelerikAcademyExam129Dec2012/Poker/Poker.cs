using System;
using System.Collections.Generic;
using System.Linq;

class Poker
{
    static int Main(string[] args)
    {
        string[] cards = new string[5];
        int[] values = new int[5];
        int[] match = new int[14];
        int[] repeated = new int[200];
        
        for (int i = 0; i < 5; i++)
        {
            cards[i] = Console.ReadLine();
            if (cards[i] == "A")
            {
                cards[i] = "1";
            }
            else if (cards[i] == "K")
            {
                cards[i] = "13";
            }
            else if (cards[i] == "Q")
            {
               cards[i] = "12";
            }
            else if (cards[i] == "J")
            {
                cards[i] = "11";
            }
            values[i] = int.Parse(cards[i]);
        }

        Array.Sort(values);

        bool smile = true;
        for (int i = 0; i < 5; i++)
        {
            if (match[values[i]] == 0)
            {
                match[values[i]] += 1;
                for (int j = 0; j < 4; j++)
                {
                    if(values[i] == values[j+1])
                    {
                        if(i == 0 && smile == true)
                        {
                            repeated[values[i]] += 1;    
                            smile = false;
                        }
                        repeated[values[i]] += 1;
                    }
                }
            }
            
        }

        bool threePair = false;
        int counter = 0;

        for (int i = 0; i < 4; i++)
        {
            if (repeated[values[i]] > 4)
            {
                Console.WriteLine("Impossible");
                return 0;
            }
            else if (repeated[values[i]] == 4)
            {
                Console.WriteLine("Four of a Kind");
                return 0;
            }
            else if (repeated[values[i]] == 3 && threePair == false)
            {
                threePair = true;
            }
            else if (repeated[values[i]] == 2)
            {
                counter++;
            }
        }

        bool isStraight = false;
        if (counter>0 && threePair)
        {
            Console.WriteLine("Full House");
            return 0;
        }
        else if (counter==2)
        {
            Console.WriteLine("One Pair");
            return 0;
        }
        else if (counter>2)
        {
            Console.WriteLine("Two Pairs");
            return 0;
        }
        else if (threePair)
        {
            Console.WriteLine("Three of a Kind");
            return 0;
        }
        else
        {

            for (int j = 0; j < 4; j++)
            {
                if (values[j] + 1 == values[j + 1])
                {
                    isStraight = true;
                }
                else if (values[0] + 9 + j == values[j + 1])
                {
                    isStraight = true;
                }
                else
                {
                    isStraight = false;
                    break;
                }
            }
        }
        if (isStraight)
        {
            Console.WriteLine("Straight");
        }
        else
        {
            Console.WriteLine("Nothing");
        }
        return 0;
    }
}

