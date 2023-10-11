// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int temp=a;
int sum = 0;

      while (temp != 0)
       {
         sum=sum+temp%10;
         temp=temp/10;
       } 
       
Console.WriteLine("Сумма цифр в числе "+a+" равно: "+sum);