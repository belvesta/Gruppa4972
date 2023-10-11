// Задайте значение N. Напишите программу, которая выведет все натуральные
// числа в промежутке от N до 1. Выполнить с помощью рекурсии.
using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите значение N: ");
        int n = int.Parse(Console.ReadLine());

        if (n < 1)
        {
            Console.WriteLine("N должно быть натуральным числом.");
        }
        else
        {
            PrintNaturalNumbers(n);
        }
    }

    static void PrintNaturalNumbers(int n)
    {
        if (n == 0)
        {
            return;
        }
        else
        {
            Console.WriteLine(n);
            PrintNaturalNumbers(n - 1);
        }
    }
}