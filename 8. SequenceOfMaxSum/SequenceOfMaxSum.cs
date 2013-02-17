using System;

public class SequenceOfMaxSum
{
    public static void InitializationArray(int[] allNumbers)
    {
        for (int index = 0; index < allNumbers.Length; index++)
        {
            Console.Write("arr[{0}]=", index);
            allNumbers[index] = int.Parse(Console.ReadLine());
        }
    }

    public static int[] MaxSumInArray(int[] arr)
    {
        int maxSum = arr[0];
        int maxTemp = arr[0];
        int start = 0;
        int startTemp = 0;
        int end = 0;

        for (int index = 1; index < arr.Length; index++)
        {
            maxTemp += arr[index];
            if (arr[index] > maxTemp)
            {
                maxTemp = arr[index];
                startTemp = index;
            }

            if (maxTemp > maxSum)
            {
                maxSum = maxTemp;
                start = startTemp;
                end = index;
            }
        }

        int[] sequence = new int[end - start + 1];
        for (int index = 0; index < sequence.Length; index++)
        {
            sequence[index] = arr[index + start];
        }

        return sequence;
    }
    
    public static void Main()
    {
        Console.WriteLine("Enter the array length");
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());

        int[] getNumbers = new int[n];

        InitializationArray(getNumbers);

        Console.WriteLine("The sequence with maximum sum is:");
        int[] seguenceMaxSum = MaxSumInArray(getNumbers);

        foreach (int item in seguenceMaxSum)
        {
            Console.Write(item + " ");
        }

        Console.WriteLine();
    }
}
