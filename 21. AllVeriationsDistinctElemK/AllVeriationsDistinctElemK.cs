using System;

public class AllVeriationsDistinctElemK
{
    public static void Variations(int currentLoop, int numLoops, int numInteration, int[] loops)
    {
        if (currentLoop == numLoops)
        {
            PrintLoops(loops);
            return;
        }

        int endRang = currentLoop == 0 ? numInteration : numInteration - loops[currentLoop - 1];

        for (int counter = 1; counter <= endRang; counter++)
        {
            if (currentLoop == 0)
            {
                loops[currentLoop] = counter;
                Variations(currentLoop + 1, numLoops, numInteration, loops);
            }
            else
            {
                loops[currentLoop] = counter + loops[currentLoop - 1];
                Variations(currentLoop + 1, numLoops, numInteration, loops);
            }            
        }
    }

    public static void PrintLoops(int[] loops)
    {
        for (int i = 0; i < loops.Length; i++)
        {
            Console.Write("{0} ", loops[i]);
        }

        Console.WriteLine();
    }

    public static void Main()
    {
        Console.Write("N=");
        int numberOfInterations = int.Parse(Console.ReadLine());

        Console.Write("K=");
        int numberOfLoops = int.Parse(Console.ReadLine());

        int[] loops = new int[numberOfLoops];

        Variations(0, numberOfLoops, numberOfInterations, loops);
    }
}
