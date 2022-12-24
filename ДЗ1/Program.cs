Console.WriteLine("Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.");
Console.WriteLine("Введите первое число");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число");
int b = int.Parse(Console.ReadLine()!);
if (b>a)
    Console.WriteLine($"Максимальное число {b}");
else 
    Console.WriteLine($"Максимальное число {a}");

Console.WriteLine("Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.");
Console.WriteLine("Введите первое число");
int x = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число");
int y = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите третье число");
int z = int.Parse(Console.ReadLine()!);
int max = x;
if (y>max) {
    max = y;
}
if (z>max) {
    max = z;
}
Console.WriteLine($"Максимальное число {max}");

Console.WriteLine("Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).");

Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine()!);
if (num%2==0)
    Console.WriteLine("Число чётное");
else 
    Console.WriteLine("Число нечётное");

Console.WriteLine("Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.");

Console.WriteLine("Введите число");
int N = int.Parse(Console.ReadLine()!);
int inter = 1;
while (inter<=N) {
    if (inter%2==0)
        Console.Write($" {inter}");
    inter++;
}
    
