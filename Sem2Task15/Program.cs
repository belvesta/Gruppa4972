﻿// Программа, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.
//* Сделать вариант с использованием конструкции Dictionary

int dayNumber = ReadInt("Введите номер дня недели - от 1 до 7: ");
Console.WriteLine(WorkHoliday(dayNumber));

// Функция принимает сообщение для отображения в консоли,
// и выводит результат введенных данных пользователем.
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

// Функция принимает число от 1 до 7 и выводит сообщение - выходной день или нет.

string WorkHoliday(int a)
{
    if (a > 0 && a < 8)
    {
        if (a == 7 || a == 6)
        {
            Console.Write("Число " + a + " - значит выходной ");
        }
        else
        {
            Console.Write("Число " + a + " - значит рабочий ");
        }
    }
    else
    {
        Console.Write("Вы ввели неверное число, поэтому невозможно определить. Введите число от 1 до 7.");
    }
    return "день.";
}