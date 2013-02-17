using System;

public class ElementsWithMaxSum
{
    public static void ArrayInitialisation(int[] arr)
    {
        for (int index = 0; index < arr.Length; index++)
        {
            Console.Write("arr[{0}] = ", index);
            arr[index] = int.Parse(Console.ReadLine());
        }
    }

    public static void GetMaxSumOnGivenSequence(int k, int[] allNum)
    {
        int maxSum = 0;
        int startIndex = 0;
        int tempSum = 0;

        for (int index = 0; index <= allNum.Length - k; index++)
        {
            for (int indexSeq = 0; indexSeq < k; indexSeq++)
            {
                tempSum += allNum[index + indexSeq];
            }

            if (tempSum > maxSum)
            {
                startIndex = index;
                maxSum = tempSum;
            }

            tempSum = 0;
        }

        Console.WriteLine("The maximum sum is = {0}", maxSum);
        Console.Write("The sequence is : ");

        for (int index = 0; index < k; index++)
        {
            Console.Write("{0} ", allNum[index + startIndex]);
        }
    }    

    public static void Main()
    {
        int n = 0;
        int k = 0;
        do
        {
            Console.WriteLine("Please enter n and k. 'k' have to be smaller than n ");

            Console.Write("n = ");
            n = int.Parse(Console.ReadLine());

            Console.Write("k = ");
            k = int.Parse(Console.ReadLine());
        }
        while (k > n);

        int[] allNum = new int[n];
        ArrayInitialisation(allNum);

        GetMaxSumOnGivenSequence(k, allNum);
    }
}