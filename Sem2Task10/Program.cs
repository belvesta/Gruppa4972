// Программа, в которой на вход принимается трёхзначное число и на выходе
// показывает вторую цифру этого числа.
//int number = ReadInt("Введите трехзначное число: ");
Console.WriteLine("Введите трехзначное число. Выход из программы - команда Exit.");
    while(true)
    {
        string input = Console.ReadLine();
        if(!input.Equals("exit"))
            Console.WriteLine("{0}->{1}",input, input[1]);
        else
            break;
    }