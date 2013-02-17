using System;
using System.Collections.Generic;

public class RemoveElemToGetIncreasOrder
{
    public static void InitializationArray(int[,] arrayOfNumbers, int size)
    {
        for (int index = 0; index < size; index++)
        {
            Console.Write("arr[{0}]=", index);
            arrayOfNumbers[0, index] = int.Parse(Console.ReadLine());
            arrayOfNumbers[1, index] = index;
        }
    }

    public static void QuickSort(int[,] allNumbers, int left, int right)
    {
        int i = left, j = right;
        int pivot = allNumbers[0, (left + right) / 2];

        while (i <= j)
        {
            while (allNumbers[0, i].CompareTo(pivot) < 0)            
            {
                i++;
            }

            while (allNumbers[0, j].CompareTo(pivot) > 0)
            {
                j--;
            }

            if (i <= j)
            {
                int tmp = allNumbers[0, i];
                int tmpIndex = allNumbers[1, i];
                allNumbers[0, i] = allNumbers[0, j];
                allNumbers[1, i] = allNumbers[1, j];
                allNumbers[0, j] = tmp;
                allNumbers[1, j] = tmpIndex;

                i++;
                j--;
            }
        }

        if (left < j)
        {
            QuickSort(allNumbers, left, j);
        }

        if (i < right)
        {
            QuickSort(allNumbers, i, right);
        }

        CorrectIndexesAfterSort(allNumbers, right);
    }

    public static void CorrectIndexesAfterSort(int[,] allNumbers, int right)
    {
        for (int index = 0; index < right - 1; index++)
        {
            if (allNumbers[0, index] == allNumbers[0, index + 1])
            {
                if (allNumbers[1, index] > allNumbers[1, index + 1])
                {
                    int tempIndex = allNumbers[1, index + 1];
                    allNumbers[1, index + 1] = allNumbers[1, index];
                    allNumbers[1, index] = tempIndex;
                }
            }
        }
    }

    public static List<int> RemoveElements(int length, int[,] arrInitialValus)
    {
        int maxSubSet = 0;
        int tmpSubSet = 0;
        List<int> maxSubElem = new List<int>();
        List<int> tmpSubElem = new List<int>();

        for (int startSubset = 0; startSubset < length - 1; startSubset++)
        {
            tmpSubSet = 0;
            tmpSubElem.Add(arrInitialValus[0, startSubset]);

            for (int index = startSubset + 1; index < length; index++)
            {
                if ((arrInitialValus[1, startSubset] < arrInitialValus[1, index]) &&
                    (arrInitialValus[1, index] > arrInitialValus[1, index - 1]))
                {
                    tmpSubSet++;
                    tmpSubElem.Add(arrInitialValus[0, index]);
                }
            }

            if (maxSubSet < tmpSubSet)
            {
                maxSubElem.Clear();

                foreach (int item in tmpSubElem)
                {
                    maxSubElem.Add(item);
                }

                maxSubSet = tmpSubSet;
            }

            tmpSubElem.Clear();
        }

        return maxSubElem;
    }

    public static void Main()
    {
        Console.Write("The length of the array N=");
        int length = int.Parse(Console.ReadLine());

        int[,] arrInitialValus = new int[2, length];

        InitializationArray(arrInitialValus, length);

        QuickSort(arrInitialValus, 0, length - 1);

        List<int> resultArray = RemoveElements(length, arrInitialValus);

        foreach (int item in resultArray)
        {
            Console.Write("{0,4}", item);
        }

        Console.WriteLine();
    }
}