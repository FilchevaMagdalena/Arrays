using System;

public class SequenceOfGivenSum
{
    public static void InitializationArray(int[] allNumbers)
    {
        for (int index = 0; index < allNumbers.Length; index++)
        {
            Console.Write("arr[{0}]=", index);
            allNumbers[index] = int.Parse(Console.ReadLine());
        }
    }

    public static void FindSequenceForGivenSum(int[] allNumbers, int expectedSum)
    {
        int tempSum = 0;

        for (int i = 0; i < allNumbers.Length; i++)
        {
            for (int j = i; j < allNumbers.Length; j++)
            {
                tempSum += allNumbers[j];
                if (tempSum == expectedSum && ((j - i) > 0))
                {
                    PrintSequence(allNumbers, i, j);
                    return;
                }
            }

            tempSum = 0;
        }

        Console.WriteLine("There was no sequence(more than one element) with sum = {0}", expectedSum);
    }

    public static void PrintSequence(int[] allNumbers, int i, int j)
    {
        for (int index = i; index <= j; index++)
        {
            Console.Write(allNumbers[index] + " ");
        }
    }

    public static void Main()
    {
        Console.WriteLine("Please enter the array length");
        int length = int.Parse(Console.ReadLine());

        int[] allNumbers = new int[length];

        InitializationArray(allNumbers);

        Console.Write("S = ");
        int expectedSum = int.Parse(Console.ReadLine());

        FindSequenceForGivenSum(allNumbers, expectedSum);
    }
}