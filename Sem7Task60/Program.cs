// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив,
// добавляя индексы каждого элемента.

using System;

class Program
{
    static void Main()
    {
        int[,,] threeDimArray = GenerateUniqueTwoDigitArray(3, 4, 2);

        Console.WriteLine("Сгенерированный трехмерный массив с индексами:");
        PrintThreeDimArrayWithIndices(threeDimArray);
    }

    static int[,,] GenerateUniqueTwoDigitArray(int x, int y, int z)
    {
        int[,,] array = new int[x, y, z];
        bool[] usedNumbers = new bool[90]; // Для отслеживания использованных чисел (10-99).

        Random random = new Random();

        for (int i = 0; i < x; i++)
        {
            for (int j = 0; j < y; j++)
            {
                for (int k = 0; k < z; k++)
                {
                    int number;
                    do
                    {
                        number = random.Next(10, 100); // Генерируем случайное двузначное число.
                    } while (usedNumbers[number - 10]); // Проверяем, использовалось ли оно.

                    array[i, j, k] = number;
                    usedNumbers[number - 10] = true; // Помечаем число как использованное.
                }
            }
        }

        return array;
    }

    static void PrintThreeDimArrayWithIndices(int[,,] array)
    {
        int x = array.GetLength(0);
        int y = array.GetLength(1);
        int z = array.GetLength(2);

        for (int i = 0; i < x; i++)
        {
            for (int j = 0; j < y; j++)
            {
                for (int k = 0; k < z; k++)
                {
                    Console.WriteLine($"array[{i},{j},{k}] = {array[i, j, k]}");
                }
            }
        }
    }
}