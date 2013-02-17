using System;

public class QuickSort
{
    public static void InitializationArray(int[] allNumbers)
    {
        for (int index = 0; index < allNumbers.Length; index++)
        {
            Console.Write("arr[{0}]=", index);
            allNumbers[index] = int.Parse(Console.ReadLine());
        }
    }

    public static void QuickSortMethod(int[] allNumbers, int left, int right)
    {
        int i = left, j = right;
        int pivot = allNumbers[(left + right) / 2];

        while (i <= j)
        {
            while (allNumbers[i].CompareTo(pivot) < 0)
            {
                i++;
            }

            while (allNumbers[j].CompareTo(pivot) > 0)
            {
                j--;
            }

            if (i <= j)
            {
                int tmp = allNumbers[i];
                allNumbers[i] = allNumbers[j];
                allNumbers[j] = tmp;

                i++;
                j--;
            }
        }

        if (left < j)
        {
            QuickSortMethod(allNumbers, left, j);
        }

        if (i < right)
        {
            QuickSortMethod(allNumbers, i, right);
        }
    }

    public static void PrintSortedArray(int[] sortedElements)
    {
        foreach (int item in sortedElements)
        {
            Console.Write(item + " ");
        }
    }

    public static void Main()
    {
        Console.WriteLine("Please enter the array length");
        int length = int.Parse(Console.ReadLine());

        int[] notSortedElements = new int[length];

        InitializationArray(notSortedElements);
        
        QuickSortMethod(notSortedElements, 0, notSortedElements.Length - 1);

        PrintSortedArray(notSortedElements);
    }
}