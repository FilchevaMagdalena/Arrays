using System;
using System.Collections.Generic;

public class SelectionSortInArray
{
    public static void PrintElements(List<int> list)
    {
        foreach (int item in list)
        {
            Console.Write(item);
            Console.Write(" ");
        }
    }

    public static void Main()
    {
        Console.WriteLine("Enter the length of the array");
        int n = int.Parse(Console.ReadLine());

        List<int> notSortedElements = new List<int>();

        List<int> sortedElements = new List<int>();

        for (int index = 0; index < n; index++)
        {
            notSortedElements.Add(int.Parse(Console.ReadLine()));
        }

        Console.WriteLine("Elements are not sorted:");
        PrintElements(notSortedElements);

        while (notSortedElements.Count != 0)
        {
            int minElement = notSortedElements[0];
            int minIndexElement = 0;

            for (int index = 1; index < notSortedElements.Count; index++)
            {
                if (minElement > notSortedElements[index])
                {
                    minElement = notSortedElements[index];
                    minIndexElement = index;
                }
            }

            sortedElements.Add(notSortedElements[minIndexElement]);
            notSortedElements.Remove(notSortedElements[minIndexElement]);
        }

        Console.WriteLine();
        Console.WriteLine("Elements are sorted:");
        PrintElements(sortedElements);
    }
}