// Программа, которая на входе принимает число и выдаёт,
// является ли число чётным (делится ли оно на 2 без остатка).
System.Console.WriteLine("Введите число: ");
   string number=Console.ReadLine();
   int number1=int.Parse(number);
       if (number1%2==1)
       {
        Console.WriteLine("Число "+number1+" является нечётным.");
       }
       else
       {
         Console.WriteLine("Число "+number1+" является чётным.");
       }
