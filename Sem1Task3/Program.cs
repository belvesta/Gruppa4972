// 1 вариант
//int day = int.Parse(Console.ReadLine()??"0");
//
//string[] dayOfWeek=new string[7];
//    dayOfWeek[0]="Понедельник";
//    dayOfWeek[1]="Вторник";
//    dayOfWeek[2]="Среда";
//    dayOfWeek[3]="Четверг";
//    dayOfWeek[4]="Пятница";
//    dayOfWeek[5]="Суббота";
//    dayOfWeek[6]="Воскресенье";
//
//Console.WriteLine(dayOfWeek[day-1]);    

//2 вариант решения
Console.WriteLine("Введите номер дня недели: ");
int dayNum=int.Parse(Console.ReadLine());
if (dayNum == 1){
    Console.WriteLine("Понедельник");
}
else if (dayNum == 2){
    Console.WriteLine("Вторник");
}
else if (dayNum == 3){
    Console.WriteLine("Среда");
}
else if (dayNum == 4){
    Console.WriteLine("Четверг");
}
else if (dayNum == 5){
    Console.WriteLine("Пятница");
}
else if (dayNum == 6){
    Console.WriteLine("Суббота");
}
else if (dayNum == 7){
    Console.WriteLine("Воскресенье");
}
else {
    Console.WriteLine("Нет такого дня в неделе");
}