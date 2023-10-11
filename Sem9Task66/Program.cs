// Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N.

using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите значение M: ");
        int m = int.Parse(Console.ReadLine());

        Console.Write("Введите значение N: ");
        int n = int.Parse(Console.ReadLine());

        if (m <= n)
        {
            int sum = SumNaturalNumbersInRange(m, n);
            Console.WriteLine($"Сумма натуральных чисел в промежутке от {m} до {n}: {sum}");
        }
        else
        {
            Console.WriteLine("M должно быть меньше или равно N.");
        }
    }

    static int SumNaturalNumbersInRange(int m, int n)
    {
        int sum = 0;

        for (int i = m; i <= n; i++)
        {
            if (i > 0)
            {
                sum += i;
            }
        }

        return sum;
    }
}