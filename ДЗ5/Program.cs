Console.WriteLine("Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.");
int []array = GetArray(10, 0, 999);
Console.WriteLine($"[{String.Join(',', array)}]"); 
int count = CountNums(array);
Console.WriteLine($"Количество четных чисел в массиве равно {count}");

int CountNums(int[] array) {
    int count = 0;
  foreach (int el in array) {
    if (el%2==0) {
        count++;
    } 
  }
  return count;
    }

int[] GetArray (int size, int minValue, int maxValue) {
    int[] result = new int[size];
    for (int i = 0; i<size; i++) {
        result[i]=new Random().Next(minValue, maxValue+1);
    }
return result;
}