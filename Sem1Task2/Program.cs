// Программа, которая на вход принимает 2 числа и выдаёт, какое
// число большее, а какое меньшее.
Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine()); //Преобразовали строковое представление
// числа в 32-бит целое число со знаком.
Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
if (a>b)
       System.Console.WriteLine("Большее число: "+a+", меньшее число: "+b);
       else
       System.Console.WriteLine("Большее число: "+b+", меньшее число: "+a);

 