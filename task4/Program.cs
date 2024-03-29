﻿using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the number of rows in the jagged array: ");
        string inputRows = Console.ReadLine();
        if (int.TryParse(inputRows, out int n))
        {
            int[][] jaggedArray = new int[n][];

            Console.WriteLine("Enter elements of the jagged array:");

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Number of elements in row {i}: "); // entering size for each row
                string inputElements = Console.ReadLine();

                if (int.TryParse(inputElements, out int m))
                {
                    jaggedArray[i] = new int[m];

                    for (int j = 0; j < m; j++)
                    {
                        Console.Write($"Element [{i},{j}]: "); // after ask for enter some elements for row
                        string elementInput = Console.ReadLine();

                        if (int.TryParse(elementInput, out int element))
                        {
                            jaggedArray[i][j] = element;
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter a valid integer.");
                            j--; // Important step, cause re-entering data again. Since we increment j in cycle
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number of elements.");
                    i--; // And here too
                }
            }

            Console.WriteLine("Initial jagged array:");

            PrintJaggedArray(jaggedArray);

            int[] lastEvenElements = FindLastEvenElements(jaggedArray);

            Console.WriteLine("Array of last even elements in each row:");

            PrintArray(lastEvenElements);
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number of rows.");
        }
    }

    static int[] FindLastEvenElements(int[][] jaggedArray)
    {
        int n = jaggedArray.Length;
        int[] resultArray = new int[n];

        for (int i = 0; i < n; i++)
        {
            int m = jaggedArray[i].Length;
            int lastEvenElement = -1;

            foreach (int element in jaggedArray[i])
            {
                if (element % 2 == 0)
                {
                    lastEvenElement = element;
                }
            }

            resultArray[i] = lastEvenElement;
        }

        return resultArray;
    }

    static void PrintJaggedArray(int[][] jaggedArray)
    {
        foreach (var row in jaggedArray)
        {
            foreach (var element in row)
            {
                Console.Write(element + "\t");
            }
            Console.WriteLine();
        }
    }

    static void PrintArray(int[] array)
    {
        int n = array.Length;

        foreach (var element in array)
        {
            Console.Write(element + "\t");
        }
        Console.WriteLine();
    }
}