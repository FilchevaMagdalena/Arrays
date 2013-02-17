using System;

public class InitValueIndexMultiplied5
{
    public static void PrintArray(int[] arr)
    {
        foreach (int element in arr)
        {
            Console.Write(element);
            Console.Write(" ");
        }

        Console.WriteLine();
    }

    public static void Main(string[] args)
    {
        int[] myArray = new int[20];

        for (int index = 0; index < myArray.Length; index++)
        {
            myArray[index] = index * 5;
        }

        PrintArray(myArray);
    }
}