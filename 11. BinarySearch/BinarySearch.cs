using System;

public class BinarySearch
{
    public static void InitializationArray(int[] allNumbers)
    {
        for (int index = 0; index < allNumbers.Length; index++)
        {
            Console.Write("arr[{0}]=", index);
            allNumbers[index] = int.Parse(Console.ReadLine());
        }
    }

    public static void BinarySearchDedecateElement(int[] arr, int start, int end, int n)
    {
        int middleCheckNum = ((end - start) / 2) + start;

        if (start == end)
        {
            Console.WriteLine("The number doesn't exist in given array!");
            return;
        }
        else if (arr[middleCheckNum] > n)
        {
            BinarySearchDedecateElement(arr, start, middleCheckNum, n);
        }
        else if (arr[middleCheckNum] < n)
        {
            BinarySearchDedecateElement(arr, middleCheckNum + 1, end, n);
        }
        else if (arr[middleCheckNum] == n)
        {
            Console.WriteLine("Number is on index {0}.", middleCheckNum);
            return;
        }
    }

    public static void Main()
    {
        Console.WriteLine("Please enter the array length");
        int length = int.Parse(Console.ReadLine());

        int[] allNumbers = new int[length];
        
        Console.WriteLine("Requirement! The arry must be sorted.");
        InitializationArray(allNumbers);
        
        Console.WriteLine("Which number in the array you are looking for?");
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());

        BinarySearchDedecateElement(allNumbers, 0, allNumbers.Length, n);
    }
}