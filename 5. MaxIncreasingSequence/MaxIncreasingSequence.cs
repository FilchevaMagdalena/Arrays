using System;

public class MaxIncreasingSequence
{
    public static void FindBiggerSequence(int tempStart, int tempCount, ref int maxStart, ref int maxCount)
    {
        if (maxCount < tempCount)
        {
            maxCount = tempCount;
            maxStart = tempStart;
        }
    }

    public static void Main()
    {
        Console.WriteLine("Please enter the length of the array");
        int n = int.Parse(Console.ReadLine());

        int[] myArray = new int[n];

        for (int index = 0; index < myArray.Length; index++)
        {
            Console.Write("arr[{0}] = ", index);
            myArray[index] = int.Parse(Console.ReadLine());
        }
        
        int tempStart = 0;
        int tempCount = 1;

        int maxStart = 0;
        int maxCount = 1;

        for (int index = 0; index < myArray.Length - 1; index++)
        {
            if (myArray[index] < myArray[index + 1])
            {
                tempCount++;
            }
            else
            {
                FindBiggerSequence(tempStart, tempCount, ref maxStart, ref maxCount);
                tempCount = 1;
                tempStart = index + 1;
            }
        }

        FindBiggerSequence(tempStart, tempCount, ref maxStart, ref maxCount);

        for (int index = 0; index < maxCount; index++)
        {
            Console.Write("{0} ", myArray[maxStart + index]);
        }
    }
}