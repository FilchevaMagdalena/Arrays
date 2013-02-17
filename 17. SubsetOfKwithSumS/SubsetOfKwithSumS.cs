using System;
using System.Collections.Generic;

public class SubsetOfKwithSumS
{
    public static void InitializationArray(int[] arrayOfNumbers)
    {
        for (int index = 0; index < arrayOfNumbers.Length; index++)
        {
            Console.Write("arr[{0}]=", index);
            arrayOfNumbers[index] = int.Parse(Console.ReadLine());
        }
    }

    public static void FindSumWithGivenSubset(int subsetLength, int[] arrayOfNumbers, int findingSum)
    {
        int allCombinations = (int)Math.Pow(2, arrayOfNumbers.Length);

        for (int index = 1; index < allCombinations; index++)
        {
            int combinationIsValid = 0;
            int tempSum = 0;

            for (int bit = 0; bit < arrayOfNumbers.Length; bit++)
            {
                if (((index >> bit) & 1) == 1)
                {
                    combinationIsValid++;
                    tempSum += arrayOfNumbers[bit];
                }
            }

            if (combinationIsValid == subsetLength)
            {
                if (tempSum == findingSum)
                {
                    PrintSubset(findingSum, arrayOfNumbers, index, subsetLength);
                    return;
                }
            }
        }

        Console.WriteLine("There is no a subset with sum {0} with {1} elements.", findingSum, subsetLength);
    }

    public static void PrintSubset(int findingSum, int[] arrayOfNumbers, int combinationNumber, int subset)
    {
        Console.Write("The first find subset of sum = {0} with {1} elements is -> ", findingSum, subset);

        for (int index = 0; index < arrayOfNumbers.Length; index++)
        {
            if (((combinationNumber >> index) & 1) == 1)
            {
                Console.Write(arrayOfNumbers[index] + " ");
            }
        }

        Console.WriteLine();
    }

    public static void Main()
    {
        Console.Write("The length of the array N=");
        int length = int.Parse(Console.ReadLine());

        Console.Write("The length of the subset K=");
        int subsetLength = int.Parse(Console.ReadLine());

        Console.Write("The searching sum for given subset S=");
        int sum = int.Parse(Console.ReadLine());

        int[] arrayOfNumbers = new int[length];

        InitializationArray(arrayOfNumbers);

        FindSumWithGivenSubset(subsetLength, arrayOfNumbers, sum);
    }
}