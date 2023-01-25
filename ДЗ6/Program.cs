// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел строго больше 0 ввёл пользователь.
Console.WriteLine("Введите несколько чисел ");
string m = Console.ReadLine()!;
string[] nums = m.Split(' ', StringSplitOptions.RemoveEmptyEntries);
int[] num = new int[nums.Length];
for (int i = 0; i < nums.Length; i++)
{
    num[i] = int.Parse(nums[i]);
}
Console.WriteLine($"Вы ввели {CountEl(num)} чисел > 0");

int CountEl(int[] array)
{
    int count = 0;
    foreach (int el in array)
    {
        if (el > 0)
        {
            count++;
        }
    }
    return count;
}

