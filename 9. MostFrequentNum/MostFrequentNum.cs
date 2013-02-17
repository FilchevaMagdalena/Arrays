using System;

public class MostFrequentNum
{
    public static void InitializationArray(int[] allNumbers)
    {
        for (int index = 0; index < allNumbers.Length; index++)
        {
            Console.Write("arr[{0}]=", index);
            allNumbers[index] = int.Parse(Console.ReadLine());
        }
    }

    public static void FindMostFreqNum(int[] allNumbers)
    {
        int countFreqNum = 0;
        int winnerNumber = 0;

        int tempFreqNum = 1;
        int tempWinnerNumber = 0;

        for (int index = 0; index < allNumbers.Length - 1; index++)
        {
            if (allNumbers[index] == allNumbers[index + 1])
            {
                tempFreqNum++;
                tempWinnerNumber = allNumbers[index];
            }
            else
            {
                FinedBiggerRepetition(ref countFreqNum, tempFreqNum, ref winnerNumber, tempWinnerNumber);
                tempFreqNum = 1;
            }
        }

        FinedBiggerRepetition(ref countFreqNum, tempFreqNum, ref winnerNumber, tempWinnerNumber);

        if (countFreqNum == 1)
        {
            Console.WriteLine("None of the elements is repeated");
        }
        else 
        {
            Console.WriteLine("{0} ({1} times)", winnerNumber, countFreqNum);
        }        
    }

    public static void FinedBiggerRepetition(ref int countFreqNum, int tempFreqNum, ref int winnerNumber, int tempWinnerNumber)
    {
        if (countFreqNum < tempFreqNum)
        {
            countFreqNum = tempFreqNum;
            winnerNumber = tempWinnerNumber;
        }
    }

    public static void Main()
    {
        Console.WriteLine("Please enter the array length");
        int length = int.Parse(Console.ReadLine());

        int[] allNumbers = new int[length];

        InitializationArray(allNumbers);

        Array.Sort(allNumbers);

        FindMostFreqNum(allNumbers);
    }
}