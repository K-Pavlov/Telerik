using System;
using System.Threading;
using System.Collections.Generic;
using System.Threading.Tasks;


public class InfoGiver
{
    //Method calls givesUserInfo method
    //and generates words
    public string generateWords()
    {
        //Words to guess
        Random rand = new Random();
        string[] words = new string[10];
        words[0] = "potato";
        words[1] = "car";
        words[2] = "Mephisto";
        // Generate random word from given
        return words[rand.Next(0, 3)].ToLower();
    }

    //Method takes the given word and
    //gives and explanation for it
    public void giveWordExplanation(string word)
    {
        switch (word)
        {
            case "potato":
                Console.WriteLine(
                    "This is a vegetable, grows in the ground and is widely consumed");
                break;
            case "car":
                Console.WriteLine(
                    "A thing that transports you from one position to another");
                break;
            case "mephisto":
                Console.WriteLine(
                    "Another name for the devil");
                break;
        }
    }

    //Gives info about the
    //game to the user
    public void giveUserInfo()
    {
        // User info
        Console.WriteLine(
            "Hello this is the GUESSSSSSSSING GAME");
        Thread.Sleep(2000);
        Console.WriteLine(
            "Now you must guess a random word");
        Thread.Sleep(2000);
    }
}

