using System;

public class WordAsIndexes
{
    public static void PrintWordAsNumber(char[] allCharsByWord)
    {
        foreach (char item in allCharsByWord)
        {
            if (((int)item - 'A') > 25)
            {
                Console.WriteLine("Incorrect word!");
                return;
            }
        }

        foreach (char ch in allCharsByWord)
        {
            Console.Write((int)ch - 'A');
            Console.Write(" ");
        }

        Console.WriteLine();
    }

    public static void Main()
    {
        Console.WriteLine("What is your word? The letters should be uppercase!");
        Console.Write("Word = ");
        string wordInput = Console.ReadLine();

        char[] allCharsByWord = wordInput.ToCharArray();

        PrintWordAsNumber(allCharsByWord);
    }
}