// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

Console.Clear();

int[] arr = new int[9];

void GetPosNetSums(int[] arr)
{
    int sumNeg = 0;
    int sumPos = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        if(arr[i] > 0) sumPos += arr[i];
        else sumNeg += arr[i];
    }
    Console.WriteLine($"Sum for negative elements of array is {sumNeg} and for positives is {sumPos}");
}


void PrintArray(int[] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.WriteLine();
}

void FillArray(int[] arr, int lowBorder, int highBorder)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        arr[i] = new Random().Next(lowBorder, highBorder + 1);
        Console.Write($"{arr[i]}, ");
    }
    Console.WriteLine();
}

FillArray(arr, 0, 10);
// GetPosNetSums(arr);


// Задача 32: Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

void InvertArray(int[] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        arr[i] = - arr[i];
        Console.Write($"{arr[i]}, ");
    }
    Console.WriteLine();
}
// InvertArray(arr);

// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

// Boolean FindNumInArray(int[] arr, int n)
// {
//     for(int i = 0; i < arr.GetLength(0); i++)
//     {
//         if(arr[i] == n) return true;
//     }
//     return false;
// }
// Console.WriteLine(FindNumInArray(arr, 3));

// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

void CountNumsInArray(int[] arr, int lowBorder, int highBorder)
{
    int count = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        if(arr[i] >= lowBorder && arr[i] <= highBorder) count++;
    }
    Console.WriteLine($"There are {count} elements of array in range [{lowBorder}, {highBorder}]");
}

// CountNumsInArray(arr, 10, 99);

// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] GetNewProdArray(int[] arr)
{
    int[] new_arr;
    if(arr.GetLength(0) % 2 == 0) new_arr = new int[arr.GetLength(0) / 2];
    else 
    {
        new_arr = new int[(arr.GetLength(0) / 2) + 1];
        new_arr[new_arr.GetLength(0) - 1] = arr[arr.GetLength(0) / 2];
    }
    int j = arr.GetLength(0) - 1;
    Console.WriteLine(new_arr.GetLength(0));

    for (int i = 0; i < new_arr.GetLength(0); i++)
    {
        if(j >= new_arr.GetLength(0)) 
        {
            new_arr[i] = arr[i] * arr[j];
            j--;
        }
        else break;
    }
    return new_arr;
}
int[] new_arr;
new_arr = GetNewProdArray(arr);
PrintArray(new_arr);