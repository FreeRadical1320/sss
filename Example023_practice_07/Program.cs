// Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1
Console.Clear();

void PrintArray(double[,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]}\t");
        }
        Console.WriteLine();
    }
}

double[,] FillArray(int row, int col, int lowBorder, int highBorder)
{
    double[,] arr = new double[row, col];
    for(int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            arr[i, j] = new Random().Next(lowBorder, highBorder + 1);
        }
    }
    return arr;
}
double[,] arr = FillArray(5, 5, 100, 1000);

PrintArray(arr);

// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

// int[,] FillArrayWithIndexSum(int row, int col)
// {
//     int[,] arr = new int[row, col];
//     for(int i = 0; i < row; i++)
//     {
//         for (int j = 0; j < col; j++)
//         {
//             arr[i, j] = i + j;
//         }
//     }
//     return arr;
// }
// int[,] arr = FillArrayWithIndexSum(3, 4);
// PrintArray(arr);

// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
// Например, изначально массив
// выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Console.WriteLine();

// double[,] ReplaceEvenNumbers(double[,] arr)
// {
//     for(int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             if( i != 0 
//                 && i % 2 == 0
//                 && j != 0
//                 && j% 2 == 0)
//             arr[i, j] = Math.Pow(arr[i, j], 2);
//         }
//     }
//     return arr;
// }
// double[,] new_arr = ReplaceEvenNumbers(arr);
// PrintArray(new_arr);

// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

double FindDiagonalSum(double[,] arr)
{
    double sum = 0;
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if(i == j)
            sum += arr[i, j];
        }
    }
    return sum;
}
Console.WriteLine($"The diagonal sum of the matrix is equal: {FindDiagonalSum(arr)}.")