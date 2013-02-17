using System;
using System.Collections.Generic;

public class SieveOfEratosthenes
{
    public static void EratosthenMethodForPrimeNum(bool[] eratosthenArray)
    {
        for (int index = 2; index < Math.Sqrt(eratosthenArray.Length); index++)
        {
            for (int i = index * index; i < eratosthenArray.Length; i = i + index)
            {
                eratosthenArray[i] = true;
            }
        }
    }

    public static void PrintPrimeElements(bool[] eratosthenArray)
    {
        for (int index = 2; index < eratosthenArray.Length; index++)
        {
            if (eratosthenArray[index] == false)
            {
                Console.Write(index + " ");
            }
        }
    }
    
    public static void Main()
    {
        bool[] eratosthenArray = new bool[10000000];

        EratosthenMethodForPrimeNum(eratosthenArray);

        PrintPrimeElements(eratosthenArray);
    }
}
