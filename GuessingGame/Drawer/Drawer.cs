using System;
using System.Threading;
using System.Collections.Generic;
using System.Threading.Tasks;

public class Drawer
{
    //Method takes word and
    //splits into letters
    public List<char> splitLetter(string word)
    {
        List<char> letter = new List<char>();
        foreach (char c in word)
        {
            letter.Add(c);
        }
        return letter;
    }

    //Method draws underscores on 
    //the screen(underscores are as
    //much as the word length
    public void drawUnderscores(List<char> givenLetters,List<char> splitWord)
    {
        foreach(char c in splitWord)
        {
            if (givenLetters.Contains(c))
            {
                Console.Write("{0} ", c);
            }
            else
            {
                Console.Write("_ ");
            }
        }
        Console.WriteLine();
    }

    //Method adds some beauty to
    //the the way the user sees
    // the lives. Takes an int
    // returs nothing
    public void writeLives(int lives)
    {
        int x = Console.CursorLeft;
        int y = Console.CursorTop;
        Console.CursorTop = 0;
        Console.CursorLeft = Console.BufferWidth - 10;
        Console.Write("Lives {0}",lives);
        Console.SetCursorPosition(x, y);
    }
    
}

