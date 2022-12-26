// Console.WriteLine("Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. Обязательна проверка на ввод чисел больше/меньше 3-х знаков");
// Console.WriteLine("Введите трехзначное число ");
// int number = int.Parse(Console.ReadLine()!);
// if (number>99 && number<1000) {
//   int result = (number - (number/100)*100-(number%10))/10;
//     Console.WriteLine($"Вторая цифра введенного числа {result}");
// } 
// else Console.WriteLine($"Это не трехзначное число");

Console.WriteLine("Задача 2: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. Берем числа до 100000");
Console.WriteLine("Введите число ");
int num = int.Parse(Console.ReadLine()!); 
if (num>99 && num<100000) {
    string num1 = num.ToString();
    Console.WriteLine($"Третья цифра введенного числа {num1[2]}");
} 
else 
    Console.WriteLine("Третьей цифры нет");

// Console.WriteLine("Задача 3: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным. Обязательна проверка на ввод числа <1 и >7");
// Console.WriteLine("Введите цифру, соответствующую дню недели");
// int count = int.Parse(Console.ReadLine()!);
// if (count>0 && count <6)
//     Console.WriteLine("Это не выходной день");
// else if (count>5 && count <8)
//     Console.WriteLine("Это выходной день");
// else 
//     Console.WriteLine("Эта цифра не обозначает день недели");