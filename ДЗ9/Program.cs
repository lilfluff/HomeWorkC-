// Задача 64: Выполнить с помощью рекурсии.Задайте значение N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine($"{Recurtion(N)}");
int Recurtion(int N)
{
    if (N == 1) return 1;
    else return N+Recurtion(N - 1);
}
