// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
Console.WriteLine("Введите количество строк ");
int rows = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов ");
int columns = int.Parse(Console.ReadLine()!);
double[,] array = FillArray(rows, columns, -100, 100);
PrintAray(array);
double[,] FillArray(int m, int n, int minvalue, int maxvalue)
{
    double[,] result = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Random p = new Random();
            result[i, j] = (maxvalue + 1 - minvalue) * p.NextDouble() + minvalue;

            Convert.ToDouble(new Random().Next(minvalue, maxvalue + 1));
        }
    }
    return result;
}
void PrintAray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j].ToString("F"+2)} ");
        }
        Console.WriteLine();
    }
}

// Задача 50. Напишите программу, которая на вход принимает число, 
// проверяя есть ли такое число в двумерном массиве и возвращает сообщение о том, 
// что оно найдено или же указание, что такого элемента нет.
