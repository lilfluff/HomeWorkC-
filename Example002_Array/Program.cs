void FillArray (int [] massive)
{
    int lenght = massive.Length;
    int index = 0;
    while (index < lenght)
    {
        massive[index] = new Random().Next(1, 100);
        index++;
    }
}
void PrintArray (int [] box)
{
    int count = box.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write($" {box[position]}");
        position++;
    }
}

int IndexOf (int [] collection, int find)
{
    int count = collection.Length;
    int position = -1;
    int index = 0;
    while (index<count)
    {
        if (collection[index]==find)
        {
            position = index;
    
        }
        index++;
    }
    return position;
}

int [] array = new int [6];
FillArray(array);
PrintArray(array);
Console.WriteLine();
Console.WriteLine("Введите число ");
int find = int.Parse(Console.ReadLine()!);
int pos = IndexOf(array, find);
Console.WriteLine($"Позиция этого числа {pos}");