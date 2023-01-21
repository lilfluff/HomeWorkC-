// Console.WriteLine("Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.");
// int []array = GetArray(10, 0, 999);
// Console.WriteLine($"[{String.Join(',', array)}]"); 
// int count = CountNums(array);
// Console.WriteLine($"Количество четных чисел в массиве равно {count}");

// int CountNums(int[] array) {
//     int count = 0;
//   foreach (int el in array) {
//     if (el%2==0) {
//         count++;
//     } 
//   }
//   return count;
//     }

// int[] GetArray (int size, int minValue, int maxValue) {
//     int[] result = new int[size];
//     for (int i = 0; i<size; i++) {
//         result[i]=new Random().Next(minValue, maxValue+1);
//     }
// return result;
// }

// Console.WriteLine("Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных индексах.");
// int []array = GetArray(10, 0, 10);
// Console.WriteLine($"[{String.Join(',', array)}]"); 
// int sum = Sums(array);
// Console.WriteLine($"Сумма элементов, стоящих на нечетных индексах, равна {sum}");
// int Sums (int[] array) {
//     int sum = 0;
//     int i = 0;
//     foreach (int el in array) {
//         if (i%2 !=0) {
//             sum+=el;
//         } i++;
//     } return sum;
// }

// int[] GetArray (int size, int minValue, int maxValue) {
//     int[] result = new int[size];
//     for (int i = 0; i<size; i++) {
//         result[i]=new Random().Next(minValue, maxValue+1);
//     }
// return result;
// }

Console.WriteLine("Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.");
int []array = GetArray(5, 1, 5);
Console.WriteLine($"{String.Join(' ', array)}"); 

int []mult = Mult(array);
Console.WriteLine($"{String.Join(' ',mult)}");

int[] Mult(int[] array) {
    int size = array.Length / 2;
    if (array.Length % 2 == 1) size++;
    int[] result = new int[size];
 for(int i = 0; i < size; i++) {
    result[i]=array[i]* (array[array.Length-i-1]);
 } 
 if (array.Length % 2 == 1) result[size-1] = array[array.Length /2];
 return result;
 }


int[] GetArray (int size, int minValue, int maxValue) {
    int[] result = new int[size];
    for (int i = 0; i<size; i++) {
        result[i]=new Random().Next(minValue, maxValue+1);
    }
return result;
}

