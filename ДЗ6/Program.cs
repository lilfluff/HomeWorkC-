// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел строго больше 0 ввёл пользователь.
// Console.WriteLine("Введите несколько чисел ");
// string m = Console.ReadLine()!;
// string[] nums = m.Split(' ', StringSplitOptions.RemoveEmptyEntries);
// int[] num = new int[nums.Length];
// for (int i = 0; i < nums.Length; i++)
// {
//     num[i] = int.Parse(nums[i]);
// }
// Console.WriteLine($"Вы ввели {CountEl(num)} чисел > 0");

// int CountEl(int[] array)
// {
//     int count = 0;
//     foreach (int el in array)
//     {
//         if (el > 0)
//         {
//             count++;
//         }
//     }
//     return count;
// }

// Написать программу, которая на вход принимает массив из любого количества элементов 
// (не менее 6)в промежутке от 0 до 100, 
// а на выходе выводит этот же массив, но отсортированный по возрастанию(от меньшего числа к большему).

int[] FillArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100);
    }
    return array;
}
int[] num = FillArray(8);
MinToMax(num);
for (int i = 0; i < num.Length; i++)
{
    Console.Write($"{num[i]} ");
}

void MinToMax(int[] array)
{
    int temp = 0;
    for (int i = 0; i < array.Length - 1; i++)
    {
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[i] > array[j])
            {
                temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
        }
    }
}