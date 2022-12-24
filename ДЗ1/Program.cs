// Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// Console.WriteLine("Введите первое число");
// int a = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите второе число");
// int b = int.Parse(Console.ReadLine()!);
// if (b>a)
//     Console.WriteLine($"Максимальное число {b}");
// else 
//     Console.WriteLine($"Максимальное число {a}");

//Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// Console.WriteLine("Введите первое число");
// int a = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите второе число");
// int b = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите третье число");
// int c = int.Parse(Console.ReadLine()!);
// int max = a;
// if (b>max) {
//     max = b;
// }
// if (c>max) {
//     max = c;
// }
// Console.WriteLine($"Максимальное число {max}");

// Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// Console.WriteLine("Введите число");
// int a = int.Parse(Console.ReadLine()!);
// if (a%2==0)
//     Console.WriteLine("Число чётное");
// else 
//     Console.WriteLine("Число нечётное");

// Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число");
int N = int.Parse(Console.ReadLine()!);
int inter = 1;
while (inter<=N) {
    if (inter%2==0)
        Console.Write($" {inter}");
    inter++;
}
    
