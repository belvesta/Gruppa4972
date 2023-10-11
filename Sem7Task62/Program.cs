// Напишите программу, которая заполнит спирально массив 4 на 4.

using System;

class Program
{
    static void Main()
    {
        int n = 4;
        int[,] spiralArray = GenerateSpiralArray(n);

        PrintArray(spiralArray);
    }

    static int[,] GenerateSpiralArray(int n)
    {
        int[,] array = new int[n, n];
        int value = 1;
        int left = 0, right = n - 1, top = 0, bottom = n - 1;

        while (value <= n * n)
        {
            for (int i = left; i <= right; i++)
                array[top, i] = value++;

            for (int i = top + 1; i <= bottom; i++)
                array[i, right] = value++;

            if (left < right && top < bottom)
            {
                for (int i = right - 1; i > left; i--)
                    array[bottom, i] = value++;

                for (int i = bottom; i > top; i--)
                    array[i, left] = value++;
            }

            left++;
            right--;
            top++;
            bottom--;
        }

        return array;
    }

    static void PrintArray(int[,] array)
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