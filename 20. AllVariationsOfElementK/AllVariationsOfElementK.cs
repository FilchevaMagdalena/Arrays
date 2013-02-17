using System;

public class AllVariationsOfElementK
{
    public static void Variations(int currentLoop, int numLoops, int numInteration, int[] loops)
      {
          if (currentLoop == numLoops)
            {
                  PrintLoops(loops);
                  return;
            }

          for (int counter = 1; counter <= numInteration; counter++)
            {
                  loops[currentLoop] = counter;
                  Variations(currentLoop + 1, numLoops, numInteration, loops);
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