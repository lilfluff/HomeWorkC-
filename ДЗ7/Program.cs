// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// Console.WriteLine("Введите количество строк ");
// int rows = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите количество столбцов ");
// int columns = int.Parse(Console.ReadLine()!);
// double[,] array = FillArray(rows, columns, -100, 100);
// PrintAray(array);
// double[,] FillArray(int m, int n, int minvalue, int maxvalue)
// {
//     double[,] result = new double[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             Random p = new Random();
//             result[i, j] = (maxvalue + 1 - minvalue) * p.NextDouble() + minvalue;
/* result[i, j] = new Random().NextDouble*(maxvalue-mivalue);*/

//             Convert.ToDouble(new Random().Next(minvalue, maxvalue + 1));
//         }
//     }
//     return result;
// }
// void PrintAray(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i,j].ToString("F"+2)} ");
/* Console.Write($"{array[i,j]:f2} ");*/
//         }
//         Console.WriteLine();
//     }
// }

// Задача 50. Напишите программу, которая на вход принимает число, 
// проверяя есть ли такое число в двумерном массиве и возвращает сообщение о том, 
// что оно найдено или же указание, что такого элемента нет.
// Console.WriteLine("Введите количество строк ");
// int rows = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите количество столбцов ");
// int columns = int.Parse(Console.ReadLine()!);
// int[,] array = FillArray(rows, columns, 0, 10);
// PrintArray(array);
// Console.WriteLine("Введите число ");
// int number = int.Parse(Console.ReadLine()!);
// if (IsThere(array, number)) Console.WriteLine("Такой элемент существует");
// else Console.WriteLine("Такого элемента не существует");

// bool IsThere(int[,] array, int number)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (array[i, j] == number) return true;
//         }
//     }
//     return false;
// }
// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }
// int[,] FillArray(int m, int n, int minValue, int maxvalue)
// {
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = new Random().Next(minValue, maxvalue + 1);

//         }
//     }
//     return result;
// }

// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
int[,] array = FillArray(3, 4, 0, 10);
PrintArray(array);
double [] result = Average(array);
Console.Write($"{String.Join(" ", result)}");

double[] Average(int[,] array)
{
    double[] result = new double[array.GetLength(1)];
        for (int i = 0; i < array.GetLength(1); i++)
        {
            double sum = 0;
            for (int j = 0; j < array.GetLength(0); j++)
            {
                sum += array[j, i];
            }
            result[i] = Math.Round(sum / array.GetLength(0),2);
        }
    return result;
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
int[,] FillArray(int m, int n, int minValue, int maxvalue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxvalue + 1);

        }
    }
    return result;
}