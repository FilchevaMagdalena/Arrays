using System;

public class Comparing2Arrays
{
    public static void ArrayInitialization(string[] arr, string arrayName)
    {
        for (int index = 0; index < arr.Length; index++)
        {
            Console.Write("{0}[{1}] = ", arrayName, index);
            arr[index] = Console.ReadLine();
        }

        Console.WriteLine();
    }

    public static bool Comparison(string[] firstArray, string[] secondArray)
    {
        for (int index = 0; index < firstArray.Length; index++)
        {
            if (firstArray[index] != secondArray[index])
            {
                return false;
            }
        }

        return true;
    }

    public static void Main()
    {
        Console.WriteLine("Please enter the length of the first Array");
        int n = int.Parse(Console.ReadLine());
        string[] firstArray = new string[n];

        Console.WriteLine("Please enter the length of the second Array");
        int m = int.Parse(Console.ReadLine());
        string[] secondArray = new string[m];

        if (firstArray.Length != secondArray.Length)
        {
            Console.WriteLine("Arrays are not equal because they are of different lengths");
            return;
        }
        else
        {
            ArrayInitialization(firstArray, "firstArray");
            ArrayInitialization(secondArray, "secondArray");
        }

        bool areEqual = Comparison(firstArray, secondArray);

        Console.WriteLine("Are arrays equal? {0}", areEqual); 
    }
}