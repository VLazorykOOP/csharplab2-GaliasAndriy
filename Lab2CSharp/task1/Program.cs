using System;

class Program
{
    static void Main()
    {
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("\nChoose option:");
            Console.WriteLine("1. Simple array");
            Console.WriteLine("2. Two-dimensional array");
            Console.WriteLine("3. Exit");
            Console.Write("\nYour choice: ");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    HandleOneDimensionalArray();
                    break;
                case 2:
                    HandleTwoDimensionalArray();
                    break;
                case 3:
                    exit = true;
                    Console.WriteLine("Exit...");
                    break;
                default:
                    Console.WriteLine("Wrong choice. Try again.");
                    break;
            }
        }
    }

    static void HandleOneDimensionalArray()
    {
        int n;

        Console.Write("Enter size of array: ");
        while (!int.TryParse(Console.ReadLine(), out n))
        {
            Console.WriteLine("Invalid input. ");
            Console.Write("Enter size of array: ");
        }

        int[] array1D = new int[n];

        Console.Write($"Enter {n} elements of array: ");

        for (int i = 0; i < n; i++)
        {
            while (!int.TryParse(Console.ReadLine(), out array1D[i]))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
                Console.Write($"Enter element at position {i + 1}: ");
            }
        }

        int oddCount1D = CountOddElements(array1D);
        Console.WriteLine($"Quantity of odd elements in array: {oddCount1D}");
    }

    static void HandleTwoDimensionalArray()
    {
        int rows, cols;

        Console.Write("Enter row size of two-dimensional array: ");
        while (!int.TryParse(Console.ReadLine(), out rows))
        {
            Console.WriteLine("Invalid input. ");
            Console.Write("Enter row size of two-dimensional array: ");
        }

        Console.Write("Enter column size of two-dimensional array: ");
        while (!int.TryParse(Console.ReadLine(), out cols))
        {
            Console.WriteLine("Invalid input. ");
            Console.Write("Enter column size of two-dimensional array: ");
        }

        int[,] array2D = new int[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"Enter element at position {i}, {j}: ");
                while (!int.TryParse(Console.ReadLine(), out array2D[i, j]))
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                    Console.Write($"Enter element at position {i + 1}, {j + 1}: ");
                }
            }
        }

        int oddCount2D = CountOddElements(array2D);
        Console.WriteLine($"Quantity of odd elements in array: {oddCount2D}");
    }

    static int CountOddElements(int[] array)
    {
        int count = 0;

        foreach (int element in array)
        {
            if (element % 2 != 0)
            {
                count++;
            }
        }
        return count;
    }

    static int CountOddElements(int[,] array)
    {
        int count = 0;
        int rows = array.GetLength(0);
        int cols = array.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (array[i, j] % 2 != 0)
                {
                    count++;
                }
            }
        }

        return count;
    }
}
