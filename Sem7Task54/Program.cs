//  Задайте двумерный массив. Мы его генерируем. Напишите программу, которая
// упорядочит по убыванию элементы каждой строки двумерного массива.

using System;

class Program
{
    static void Main()
    {
        int numRows = 3;
        int numCols = 4;
        int[,] array = GenerateRandomArray(numRows, numCols);

        Console.WriteLine("Исходный массив:");
        PrintArray(array);

        SortRowsDescending(array);

        Console.WriteLine("Упорядоченный массив:");
        PrintArray(array);
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

    static void SortRowsDescending(int[,] array)
    {
        int numRows = array.GetLength(0);
        int numCols = array.GetLength(1);

        for (int i = 0; i < numRows; i++)
        {
            int[] row = new int[numCols];

            for (int j = 0; j < numCols; j++)
            {
                row[j] = array[i, j];
            }

            Array.Sort(row, (a, b) => b.CompareTo(a));

            for (int j = 0; j < numCols; j++)
            {
                array[i, j] = row[j];
            }
        }
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