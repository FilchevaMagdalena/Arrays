using System;

public class LexicographicalComparison
{
    public static void PrintLexicographicOrder(string word1, string word2)
    {
        if (word1 == word2)
        {
            Console.WriteLine("They are equal!");
        }
        else
        {
            Console.WriteLine("Lexicographically the arrays are : 1.{0} 2.{1}", word1, word2);
        }
    }

    public static void Main()
    {
        Console.WriteLine("Enter the elements of first lexicographic array like a string");
        string firstWord = Console.ReadLine();
        char[] firstArray = firstWord.ToCharArray();

        Console.WriteLine("Enter the elements of second lexicographic array like a string");
        string secondWord = Console.ReadLine();
        char[] secondArray = secondWord.ToCharArray();

        if (firstWord == secondWord)
        {
            PrintLexicographicOrder(firstWord, secondWord);
            return;
        }

        int maxLength = firstArray.Length;
        if (firstArray.Length < secondArray.Length) 
        {
            maxLength = secondArray.Length;
        }

        for (int index = 0; index < maxLength; index++)
        {
            try
            {
                if (firstArray[index] != secondArray[index])
                {
                    if (firstArray[index] < secondArray[index])
                    {
                        PrintLexicographicOrder(firstWord, secondWord);
                        return;
                    }
                    else
                    {
                        PrintLexicographicOrder(secondWord, firstWord);
                        return;
                    }
                }
            }
            catch (Exception)
            {
                if (firstWord.Length < secondWord.Length)
                {
                    PrintLexicographicOrder(firstWord, secondWord);
                }
                else
                {
                    PrintLexicographicOrder(secondWord, firstWord);
                }
            }
        }
    }
}