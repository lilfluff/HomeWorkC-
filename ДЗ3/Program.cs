Console.WriteLine("Задача 1: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.");
Console.WriteLine("Введите пятизначное число: ");
int num = int.Parse(Console.ReadLine()!); 
if (num>9999 && num<100000) {
    string num1 = num.ToString();
   if ((num1[0]==num1[4])||(num1[1]==num1[3]))
    Console.WriteLine("Число является палиндромом");
    else {
        Console.WriteLine("Число не является палиндромом");
    } 
}
else {
    Console.WriteLine("Это не пятизначное число");
}
Console.WriteLine("Задача 2: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.");
Console.WriteLine("Введите первую координату точки 1: ");
int x1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите вторую координату точки 1: ");
int y1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите третью координату точки 1: ");
int z1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите первую координату точки 2: ");
int x2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите вторую координату точки 2: ");
int y2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите третью координату точки 2: ");
int z2 = int.Parse(Console.ReadLine()!);
double result = Math.Sqrt((Math.Pow((x2-x1),2) + Math.Pow((y2-y1),2) + Math.Pow((z2-z1),2)));
Console.WriteLine($"Расстояние между точками равно:{result:f2}");

Console.WriteLine("Задача 3: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.");
Console.WriteLine("Введите число");
int N = int.Parse(Console.ReadLine()!);
for (int i=1; i<=N; i++) {
    Console.Write($"{Math.Pow(i,3)} ");
}
