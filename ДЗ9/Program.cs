// Задача 64: Выполнить с помощью рекурсии.Задайте значение N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// Console.WriteLine("Введите число: ");
// int N = int.Parse(Console.ReadLine()!);
// Console.WriteLine($" {Recurtion(N)}");
// int [] Recurtion(int N)
// {
//    int [] result = new int [N-1];
   
//    for (int i = 1; i <N; i++)
//    {
//     result [i] = Recurtion(N);
//    }
// }
// for (int i = 0; i<N; i++)
// {
//     Console.Write($" {Recurtion(N)}");
// }

// Задача 66: Выполнить с помощью рекурсии.Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
Console.WriteLine("Введите первое число: ");
int M = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int N = int.Parse(Console.ReadLine()!);

Console.WriteLine($"СУмма натуральных элементов в промежутке от {M} до {N} = {Recurtion(M,N)}");
int Recurtion(int M, int N)
{
    if (N == M) return 0;
    else return M+Recurtion(M+1,N);
}