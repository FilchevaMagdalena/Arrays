using System;

public class SubsetOfGivenSum
{
    public static void InitializationArray(int[] arrayOfNumbers)
    {
        for (int index = 0; index < arrayOfNumbers.Length; index++)
        {
            Console.Write("arr[{0}]=", index);
            arrayOfNumbers[index] = int.Parse(Console.ReadLine());
        }
    }

    public static void ChekingAllCombinations(int findingSum, int[] arrayOfNumbers)
    {
        int combinations = (int)Math.Pow(2, arrayOfNumbers.Length);
        
        for (int index = 1; index < combinations; index++)
        {
            int tempSum = 0;

            for (int bit = 0; bit < arrayOfNumbers.Length; bit++)
            {
                if (((index >> bit) & 1) == 1)
                {
                    tempSum += arrayOfNumbers[bit];
                }
            }

            if (tempSum == findingSum)
            {
                PrintSubset(findingSum, arrayOfNumbers, index);
                return;
            }
        }

        Console.WriteLine("Is there are a subset with sum = {0} -> No", findingSum);
    }

    public static void PrintSubset(int findingSum, int[] arrayOfNumbers, int subset)
    {
        Console.WriteLine("Is there are a subset with sum = {0} -> Yes", findingSum);
        
        for (int index = 0; index < arrayOfNumbers.Length; index++)
        {
            if (((subset >> index) & 1) == 1)
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

        Console.Write("The searching sum of the subset S=");
        int findingSum = int.Parse(Console.ReadLine());

        int[] arrayOfNumbers = new int[length];

        InitializationArray(arrayOfNumbers);

        ChekingAllCombinations(findingSum, arrayOfNumbers);
    }
}