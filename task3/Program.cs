using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter size of the 2-dimensional array (N x N): ");
        int n = int.Parse(Console.ReadLine());

        double[,] array = new double[n, n];

        Console.WriteLine("Enter elements of array:");

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write($"Element [{i},{j}]: ");
                array[i, j] = double.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("Initial array:");
        PrintArray(array);

        ExchangeMiddleColumns(array); // switch mid columns

        Console.WriteLine("Array after switching of columns:");
        PrintArray(array);
    }

    static void ExchangeMiddleColumns(double[,] array)
    {
        int n = array.GetLength(0);
        int middleColumn = n / 2;

        if (n % 2 == 0)
        {
            for (int i = 0; i < n; i++)
            {
                double temp = array[i, middleColumn];
                array[i, middleColumn] = array[i, middleColumn - 1];
                array[i, middleColumn - 1] = temp;
            }
        }
        else
        {
            for (int i = 0; i < n; i++)
            {
                double temp = array[i, 0];
                array[i, 0] = array[i, middleColumn];
                array[i, middleColumn] = temp;
            }
        }
    }

    static void PrintArray(double[,] array)
    {
        int n = array.GetLength(0);

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(array[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}
