﻿// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

Console.WriteLine("Введите размер массива: ");
int length=int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите минимальное значение массива: ");
int min=int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите максимальное значение массива: ");
int max=int.Parse(Console.ReadLine()!);
int[] Array= GetArray(length, min, max);
Console.WriteLine($"[{string.Join(", ", Array)}]");
FindEven(Array);
int[] GetArray(int size, int minValue, int maxValue)
{
    Random rnd= new Random(); // переменная генератор случайных чисел
    int[] result = new int[size];
    for(int i= 0; i< result.Length; i++)
    {
        result[i] = rnd.Next(minValue, maxValue+ 1);
    }
    return result;
}
void FindEven(int[] MyArray)
{
    int even=0;
    for (int i= 0; i< MyArray.Length; i++)
    {
        if (MyArray[i]%2==0)
        {
            even=even+1;
        }
    }
    Console.WriteLine($"Чётных чисел {even}");
}

