// Программа, которая выводит третью цифру заданного числа или сообщает,
// что третьей цифры нет.
//* Сделать вариант для числа длиной до 10 цифр не используя char или string

int ThirdDigit(int number)
        {
            int result = -1;
            if (number >= 100)
            {
                while (number > 999)
                {
                    number = number / 10;
                }
                result = number % 10;
            }
            return result; 
        }
Console.Write("Введите число длиной до 10 цифр: ");
int number1 = Convert.ToInt32(Console.ReadLine());
 
if (ThirdDigit(number1) == -1)
Console.WriteLine("Третьей цифры нет!");
else
Console.WriteLine($"Третья цифра введённого числа: {ThirdDigit(number1)}");