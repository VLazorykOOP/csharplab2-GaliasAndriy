using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter array size: ");
        int n = int.Parse(Console.ReadLine());

        double[] array = new double[n];

        Console.WriteLine("Enter elements of array:");

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Element {i}: ");
            array[i] = double.Parse(Console.ReadLine());
        }

        int lastMaxIndex = FindLastMaxIndex(array);

        Console.WriteLine($"The last max element index: {lastMaxIndex}");
        Console.WriteLine($"Element[{lastMaxIndex}] = {array[lastMaxIndex]}.");
    }

    static int FindLastMaxIndex(double[] array)
    {
        if (array.Length == 0)
        {
            Console.WriteLine("Array is empty.");
            return -1;
        }

        double maxElement = array[0];
        int lastMaxIndex = 0;

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] >= maxElement)
            {
                maxElement = array[i];
                lastMaxIndex = i;
            }
        }

        return lastMaxIndex;
    }
}
