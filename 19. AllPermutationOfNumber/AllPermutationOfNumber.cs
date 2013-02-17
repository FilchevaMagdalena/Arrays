using System;

public class AllPermutationOfNumber
{
    public static void Permutations(int n, int k, int[] arr)
    {
        int temp = 0;
        while (k > 0)
        {
            for (int i = 0; i < n - 1; i++)
            {
                temp = arr[i];
                arr[i] = arr[n - 1];
                arr[n - 1] = temp;

                PrintVariation(arr);
            }

            Permutations(n, k - 1, arr);
            return;
        }
    }

    public static void PrintVariation(int[] arr)
    {
        foreach (int item in arr)
        {
            Console.Write("{0,3}", item);
        }

        Console.WriteLine();
    }

    public static void Main()
    {
        Console.Write("For all permutations of number N, please endter the number N=");
        int n = int.Parse(Console.ReadLine());

        int[] arrPermutations = new int[n];

        for (int index = 0; index < arrPermutations.Length; index++)
        {
            arrPermutations[index] = index + 1;
        }

        Permutations(n, n, arrPermutations);
    }
}
