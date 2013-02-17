using System;
using System.Collections.Generic;

public class MergeSort
{
    public static void InitializationArray(List<int> listForInit)
    {
        for (int index = 0; index < listForInit.Capacity; index++)
        {
            Console.Write("arr[{0}]=", index);
            listForInit.Add(int.Parse(Console.ReadLine()));
        }
    }

    public static List<int> MergeSortElements(List<int> listNotSortedElem)
    {
        List<int> result = new List<int>();
        List<int> left = new List<int>();
        List<int> right = new List<int>();

        if (listNotSortedElem.Count <= 1)
        {
            return listNotSortedElem;
        }

        int middle = listNotSortedElem.Count / 2;
        for (int i = 0; i < middle; i++)
        {
            left.Add(listNotSortedElem[i]);
        }

        for (int i = middle; i < listNotSortedElem.Count; i++)
        {
            right.Add(listNotSortedElem[i]);
        }

        left = MergeSortElements(left);
        right = MergeSortElements(right);

        if (left[left.Count - 1] <= right[0])
        {
            return AppendingElements(left, right);
        }
        else
        {
            result = MergeBiggerSmaller(left, right);
        }

        return result;
    }

    public static List<int> AppendingElements(List<int> left, List<int> right)
    {
        List<int> result = new List<int>(left);

        foreach (int item in right)
        {
            result.Add(item);
        }

        return result;
    }

    public static List<int> MergeBiggerSmaller(List<int> left, List<int> right)
    {
        List<int> result = new List<int>();

        while (left.Count > 0 && right.Count > 0)
        {
            if (left[0] < right[0])
            {
                result.Add(left[0]);
                left.RemoveAt(0);
            }
            else
            {
                result.Add(right[0]);
                right.RemoveAt(0);
            }
        }

        while (left.Count > 0)
        {
            result.Add(left[0]);

            left.RemoveAt(0);
        }

        while (right.Count > 0)
        {
            result.Add(right[0]);

            right.RemoveAt(0);
        }

        return result;
    }

    public static void PrintSortedArray(List<int> sortedElements)
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

        List<int> elementsToBeSorted = new List<int>(length);

        InitializationArray(elementsToBeSorted);

        List<int> sortedElements = new List<int>();

        sortedElements = MergeSortElements(elementsToBeSorted);

        PrintSortedArray(sortedElements);

        Console.WriteLine();
    }
}