// Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.
using System;

class Program
{
    static void Main()
    {
        int numRows = 5; // Количество строк
        int numCols = 4; // Количество столбцов
        int[,] array = GenerateRandomArray(numRows, numCols);

        Console.WriteLine("Исходный массив:");
        PrintArray(array);

        int minRow = FindRowWithMinSum(array) + 1; // Увеличиваем на 1 для вывода номера строки
        Console.WriteLine($"Строка с наименьшей суммой элементов: {minRow}");
    }

    static int[,] GenerateRandomArray(int numRows, int numCols)
    {
        int[,] array = new int[numRows, numCols];
        Random random = new Random();

        for (int i = 0; i < numRows; i++)
        {
            for (int j = 0; j < numCols; j++)
            {
                array[i, j] = random.Next(1, 101); // Заполняем случайными числами от 1 до 100
            }
        }

        return array;
    }

    static int FindRowWithMinSum(int[,] array)
    {
        int numRows = array.GetLength(0);
        int numCols = array.GetLength(1);
        int minRow = 0;
        int minSum = int.MaxValue;

        for (int i = 0; i < numRows; i++)
        {
            int rowSum = 0;
            for (int j = 0; j < numCols; j++)
            {
                rowSum += array[i, j];
            }

            if (rowSum < minSum)
            {
                minSum = rowSum;
                minRow = i;
            }
        }

        return minRow;
    }

    static void PrintArray(int[,] array)
    {
        int numRows = array.GetLength(0);
        int numCols = array.GetLength(1);

        for (int i = 0; i < numRows; i++)
        {
            for (int j = 0; j < numCols; j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}