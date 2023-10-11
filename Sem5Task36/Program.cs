// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

Console.WriteLine("Введите размер массива: ");
int length=int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите минимальное значение массива: ");
int min=int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите максимальное значение массива: ");
int max=int.Parse(Console.ReadLine()!);
int[] Array= GetArray(length, min, max);
Console.WriteLine($"[{string.Join(", ", Array)}]");
FindOdd(Array);
int[] GetArray(int size, int minValue, int maxValue)
{
    Random rnd= new Random(); // переменная генератор случайных чисел
    int[] result= new int[size];
    for (int i= 0; i < result.Length; i++)
    {
        result[i] = rnd.Next(minValue, maxValue+ 1);
    }
    return result;
}

void FindOdd(int[] MyArray)
{
    int odd=0;
    for ( int i= 1; i < MyArray.Length; i=i+2)
    {
        odd=odd+MyArray[i];
    }
        Console.WriteLine($"Сумма чисел на нечётных позициях {odd}");
}