using System;
using System.Threading;
using System.Collections.Generic;
using System.Threading.Tasks;

class HangMan
{
    static void Main(string[] args)
    {
        //Class instances
        InfoGiver infoGive = new InfoGiver();
        Checker check = new Checker();
        Drawer draw = new Drawer();        

        //Dynamic arrays cuz i'm cool
        List<char> usedLetters = new List<char>();
        List<char> letter = new List<char>();   

        //5 lives is good ? 
        int lives = 5;
        string word;
        //Games starts and runs while the user wants        
        infoGive.giveUserInfo();
        while(true)
        {            
            Console.WriteLine(
                "If you quit press Q if you wanna play press any other key!");

            ConsoleKeyInfo key = Console.ReadKey();
            Console.WriteLine();
            if (key.KeyChar == 'Q' || key.KeyChar == 'q')
            {
                Console.Clear();
                Console.WriteLine("Exiting the game");
                Thread.Sleep(1000);
                break;
            }
            else
            {
                Console.Clear();
                letter.Clear();
                usedLetters.Clear();

                lives = 5;

                word = infoGive.generateWords();
                letter.AddRange(draw.splitLetter(word));
                infoGive.giveWordExplanation(word);

                while (lives != 0)
                {
                    Console.Clear();                    
                    infoGive.giveWordExplanation(word);
                    draw.writeLives(lives);                    
                    Console.WriteLine(
                        "Give me a letter");
                    draw.drawUnderscores(usedLetters, letter);
                    if(!(usedLetters.Count == 0))
                    {
                    check.checkIfRightGuess(letter);
                    }
                    while (true)
                    {
                        if (check.checkInput(ref usedLetters) == true)
                        {
                            break;
                        }
                    }
                   
                    if (!check.checkIfRightGuess(letter))
                    {
                        lives--;
                    }

                    if (check.checkIfWordIsGuessed(usedLetters, letter))
                    {
                        Console.Clear();
                        draw.drawUnderscores(usedLetters, letter);
                        Console.WriteLine(
                            "And you have guessed the word!");
                        break;
                    }

                    if (lives == 0)
                    {
                        draw.writeLives(lives);
                        Console.WriteLine(
                            "Sorry endgame");
                    }
                    
                }
                Console.WriteLine();
            }
        }
        
    }
}

