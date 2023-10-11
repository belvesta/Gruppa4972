// Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
Console.WriteLine("Введите число A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int b = Convert.ToInt32(Console.ReadLine());
int c = a;

if (b<1)
{
   Console.WriteLine("Число B должно быть натуральным, то есть больше 0!");
}
else
{
   for (int i = 1; i < b; i++)
    {
      c = c * a;
    }
    Console.WriteLine("A в степени B равно: " + c);
}
