// // Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// // [345, 897, 568, 234] -> 2

// int[] CreatArray (int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue);
//     }
//     return array;
// } 

// void ShowArray (int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write($"{array[i]} ");
//     }
//     System.Console.WriteLine();
// }

// int FindEvenNumbers (int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i]%2 == 0)
//         {
//            count++;
//         }
//     }
//     return count;
// }
// System.Console.Write("Введите длинну массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int minValue = 100;
// int maxValue = 1000;
// int[] array = CreatArray (size, minValue, maxValue);
// ShowArray(array);
// int count = FindEvenNumbers(array);
// System.Console.WriteLine($"Количество четных чисел в массиве равно {count}");


// // Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// // Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// // [5, 18, 123, 6, 2] -> 1
// // [1, 2, 3, 6, 2] -> 0
// // [10, 11, 12, 13, 14] -> 5

// int[] CreatArray (int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue);       
//     }
//     return array;
// } 

// void ShowArray (int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] >= 10 && array[i] < 100)
//         {
//             Console.ForegroundColor = ConsoleColor.Red;
//              System.Console.Write($"{array[i]} ");
//             Console.ForegroundColor = ConsoleColor.White;
//         }
//         else
//             System.Console.Write($"{array[i]} ");
//     }
//     System.Console.WriteLine();
// }

// int FindEvenNumbers (int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] >= 10 && array[i] < 100)
//         {
//            count++;
//         }
//     }
//     return count;
// }
// int size = 123;
// int minValue = 1;
// int maxValue = 1000;
// int[] array = CreatArray (size, minValue, maxValue);
// ShowArray(array);
// int count = FindEvenNumbers(array);
// System.Console.WriteLine($"количество элементов массива, значения которых лежат в отрезке [10,99] равно {count}");

// // Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// // [3, 7, 23, 12] -> 19
// // [-4, -6, 89, 6] -> 0

// int[] CreatArray (int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue);
//     }
//     return array;
// } 

// void ShowArray (int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write($"{array[i]} ");
//     }
//     System.Console.WriteLine();
// }

// int FindSummNumbers (int[] array)
// {
//     int summ = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (i%2 != 0)
//         {
//            summ += array[i];
//         }
//     }
//     return summ;
// }

// System.Console.Write("Введите длинну массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int minValue = -100;
// int maxValue = 100;
// int[] array = CreatArray (size, minValue, maxValue);
// ShowArray(array);
// int summ = FindSummNumbers(array);
// System.Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях равны {summ}");

// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

// double[] CreatArray (int size, double minValue, double maxValue)
// {
//     double[] array = new double[size];
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = Math.Round(new Random().NextDouble()*(maxValue - minValue) + minValue, 2);
//     }
//     return array;
// } 

// void ShowArray (double[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write($"{array[i]} ");
//     }
//     System.Console.WriteLine();
// }
// double FindMaxNumber (double[] array)
// {
//     double maxNumber = array[0];
//     for (int i = 1; i < array.Length; i++)
//     {
//         if (array[i] > maxNumber)
//         {
//             maxNumber = array[i];
//         }
//     }
//     return maxNumber;
// }

// double FindMinNumber (double[] array)
// {
//     double minNumber = array[0];
//     for (int i = 1; i < array.Length; i++)
//     {
//         if (array[i] < minNumber)
//         {
//             minNumber = array[i];
//         }
//     }
//     return minNumber;
// }

// System.Console.Write("Введите длинну массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// double maxValue = 100;
// double minValue = -100;
// double[] array = CreatArray (size, minValue, maxValue);
// ShowArray(array);
// double maxNumber = FindMaxNumber (array);
// double minNumber = FindMinNumber (array);
// double diff = Math.Round(maxNumber - minNumber, 2);
// System.Console.WriteLine();
// System.Console.WriteLine($"Разница между максимальным и минимальным элементом массива равны {diff}");

// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] CreatArray (int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(minValue, maxValue);       
    }
    return array;
} 

void ShowArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
            System.Console.Write($"{array[i]} ");
    System.Console.WriteLine();
}
int[] NewArray(int[] array)
{
    int n = array.Length;
    int k = n / 2;
    if (n % 2 != 0)
        k++;
    int[] newArray = new int[k];
    if (n % 2 == 0)
    {
        for (int i = 0; i < k; i++)
            newArray[i] = array[i] * array[n - i - 1];
    }
    else
    {
        for (int i = 0; i < k; i++)
        {
            if (i == k - 1)
                newArray[i] = array[i];
            else
                newArray[i] = array[i] * array[n - i - 1];
        }
    }
    return newArray;
}

System.Console.Write("Введите длинну массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int minValue = -100;
int maxValue = 100;
int[] array = CreatArray(size, minValue, maxValue);
ShowArray(array);
System.Console.WriteLine();
int[] newArray = NewArray(array);
ShowArray(newArray);