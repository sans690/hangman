
using System;
using System.Collections.Generic;

public class hangman
{
    static void Main()
    {
        Console.WriteLine("Guess a letter");
        int characterCode = Console.Read();
        char inputCharacter = (char)characterCode;
        Console.WriteLine(inputCharacter);
        Console.WriteLine();
        Console.WriteLine("You pressed: " + inputCharacter);
        bool isCharacter = false;

        int turns = 4;
        string word = "balls";

        if (word.Contains(inputCharacter))
        {
            Console.WriteLine("Character " + inputCharacter + " is in word");
            isCharacter = true;
        }

        else
        {
            Console.WriteLine("Character " + inputCharacter + " is not in word");
            isCharacter = false;

        }
        // List<string> word_list = new List<string> { "apple", "grapes", "kiwi" };
        GameOver(isCharacter, turns, word);
    }

    public static void GameOver(bool isCharacter, int turns, string word)
    {
        if (IsOutOfTurns(turns))
        {
            Console.WriteLine("Damn! You lost! The word was: " + word);
        }
        // if the word is guessed
        // else if ()
    }


    public static void IsRightCharacter(bool isCharacter, int turns)
    {
        if (isCharacter)
        {
            Console.WriteLine("Congratulations! You found the right letter!");
            // turns remain
        }

        else
        {
            Console.WriteLine("Oops! You did not find the right letter!");
            // decrement turns
        }
    }

    public static bool IsOutOfTurns(int turns)
    {
        if (turns <= 0)
        {
            Console.WriteLine("You are out of turns!");
            return true;
        }
        return false;
    }
}