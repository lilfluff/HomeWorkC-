// Задача 64: Выполнить с помощью рекурсии.Задайте значение N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// void Recurtion(int n)
// {
//     if (n > 0)
//     {
//         Console.Write("{0} ", n);
//         Recurtion(n - 1);
//     }
// }
// Recurtion(2);

// Задача 66: Выполнить с помощью рекурсии.Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// Console.WriteLine("Введите первое число: ");
// int M = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите второе число: ");
// int N = int.Parse(Console.ReadLine()!);

// Console.WriteLine($"СУмма натуральных элементов в промежутке от {M} до {N} = {Recurtion(M,N)}");
// int Recurtion(int M, int N)
// {
//     if (N == M) return 0;
//     else return M+Recurtion(M+1,N);
//
// Задача 68: Выполнить с помощью рекурсии.Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

int Akkerman(int n, int m)
{
    if (n == 0) return (m + 1);
    else if (m == 0 && n > 0)
    {
        return Akkerman(n - 1, 1);
    }
    else return Akkerman((n - 1), Akkerman(n, m - 1));
}
Console.Write($"{Akkerman(3, 2)}");