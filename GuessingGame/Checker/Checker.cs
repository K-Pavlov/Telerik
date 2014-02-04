using System;
using System.Linq;
using System.Threading;
using System.Collections.Generic;
using System.Threading.Tasks;


public class Checker
{
    char inputLetter;
    // Method checkes if letters is a guess
    // Method takes letter and list of the right letters
    public bool checkIfRightGuess(List<char> rightLetters)
    {   
        if (rightLetters.Contains(inputLetter))
        {
            Console.WriteLine(
                "You have guessed a letter");
            return true;
        }
        else
        {
            Console.WriteLine(
                "Sorry, wrong letter. Please trying again");
            return false;
        }
    }

    // Method takes the given letter and refernce to the list of used letters
    // and check is the letter has benn used
    bool checkIfGiven(char letter, ref List<char> uLetters)
    {
        if (uLetters.Contains(letter))
        {
            Console.WriteLine(
                "You have already given this letter");
            return false;
        }
        else
        {
            uLetters.Add(letter);
            return true;
        }
    }

    // Method takes refernce to the list of used letters
    // and checks if input is ok
    public bool checkInput(ref List<char> uLetters)
    {

        if (char.TryParse(Console.ReadLine().ToLower(), out inputLetter))
        {
            return checkIfGiven(inputLetter, ref uLetters);
        }
        else
        {
            Console.WriteLine(
                "Give me 1 letter!!!");
            return false;
        }
    }

    //Check if the given list of 
    // guessed char symbols is the  
    // same as the word to guess 
    // char list
    public bool checkIfWordIsGuessed(List<char> givenLetters, List<char> splitWord)
    {
        foreach (char c in splitWord)
        {
            if (!givenLetters.Contains(c))
            {
                return false;
            }
        }
        return true;
            
    }
}

