// Программа, которая принимает на вход 3 числа и выдаёт
// максимальное из этих чисел.
Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine()); //Преобразовали строковое представление
// числа в 32-бит целое число со знаком.
Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());
int max=a;
if (max<b) max=b;
if (max<c) max=c;
System.Console.WriteLine("Максимальное из этих чисел: "+max);