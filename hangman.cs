
using System;
using System.Collections.Generic;

public class hangman
{
    static void Main()
    {
        Console.WriteLine("\nGuess a letter");
        int characterCode = Console.Read();

        char inputCharacter = (char)characterCode;
        Console.WriteLine("\nYou pressed: " + inputCharacter);

        bool isCharacter = false;
        int turns = 4;
        string word = "balls";

        if (word.Contains(inputCharacter))
        {
            Console.WriteLine("Character " + inputCharacter + " is in word");
            isCharacter = true;
            IsRightCharacter(isCharacter, turns);
        }
        else
        {
            Console.WriteLine("Character " + inputCharacter + " is not in word");
            isCharacter = false;
            IsRightCharacter(isCharacter, turns);
        }
        // List<string> word_list = new List<string> { "apple", "grapes", "kiwi" };
        GameOver(turns, word);
    }

    public static void GameOver(int turns, string word)
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
            Console.WriteLine("Turns remaining: " + turns);
        }
        else
        {
            turns--;
            Console.WriteLine("Turns remaining: " + turns);
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