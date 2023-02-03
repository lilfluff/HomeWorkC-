// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.

int[,] array = FillArray(3, 4, 1, 10);
PrintAray(array);
int[,] NewArray = MaxToMin(array);
Console.WriteLine();
PrintAray(NewArray);


int[,] FillArray(int m, int n, int minvalue, int maxvalue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minvalue, maxvalue);
        }
    }
    return result;
}
void PrintAray(int[,] array)
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
int[,] MaxToMin(int[,] array)
{
    int[,] result = new int[array.GetLength(0), array.GetLength(1)];
    int n = 0;
    int m = 0;
    int i = 0;
    int j = 0;
    int max = 0;
    for (i = 0; i < array.GetLength(1); i++)
    { if (array[0, i] > max)
            {
                max = array[0, i];
                array[0, i] = result[n, m];
            }
        for (j = 0; j < array.GetLength(0); j++)
        {
            
        }
    }
    return result;
}
