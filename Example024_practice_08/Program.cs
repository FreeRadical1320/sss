// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
Console.Clear();

void PrintArray(int[,] arr)
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

int[,] FillArray(int row, int col, int lowBorder, int highBorder)
{
    int[,] arr = new int[row, col];
    for(int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            arr[i, j] = new Random().Next(lowBorder, highBorder + 1);
        }
    }
    return arr;
}

int[,] ChangeFistLastRows(int[,] arr)
{
    int lastRow = arr.GetLength(0) - 1; 
    int buff;
    for(int j = 0; j < arr.GetLength(1); j++)
    {
        buff = arr[0, j];
        arr[0, j] = arr[lastRow, j];
        arr[lastRow, j] = buff;
    }
    return arr;
}


// int[,] arr = FillArray(5, 5, 100, 1000);

// PrintArray(arr);
// Console.WriteLine();
// PrintArray(ChangeFistLastRows(arr));

// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

int[,] TransformArray(int[,] arr)
{
    int row = arr.GetLength(0);
    int col = arr.GetLength(1);
    if(row != col)
    {
        Console.WriteLine($"A convertation is impossible!!!");
        return arr;
    }

    int buff = 0;
    for(int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            if(i > j)
            {
                buff = arr[i, j];
                arr[i, j] = arr[j, i];
                arr[j, i] = buff;
            }
        }
    }
    return arr;
}
// int[,] arr = FillArray(5, 5, 100, 1000);

// PrintArray(arr);
// Console.WriteLine();
// PrintArray(TransformArray(arr));

// Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

void IncrementCount(int[] arr, int number)
{
    
}

int[] CountArrayElements(int[,] arr)
{
    int row = arr.GetLength(0);
    int col = arr.GetLength(1);

    int[] counts = new int[10];
    for(int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            counts[arr[i, j]] += 1;
        }
    }
    return counts;
}

void PrintCounts(int[] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        Console.WriteLine($"Element {i} meets {arr[i]} times.");
    }
}

// int[,] arr = FillArray(5, 5, 0, 9);

// PrintArray(arr);
// Console.WriteLine();
// PrintCounts(CountArrayElements(arr));

// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим
// следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7
int FindMinimum(int[,] arr)
{
    int min = arr[0, 0];

    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if(arr[i, j] < min)
            {
                min = arr[i, j];    
            }
        }
    }
    return min;
}

void RemoveMinimums(int[,] arr, int min)
{
    int row = arr.GetLength(0);
    int col = arr.GetLength(1);

    for(int i = 0; i < row; i++)
    {
        for (int j = 0; j < row; j++)
        {
            if(arr[i, j] == min)
            {
                for (int k = 0; k < row; k++)
                {
                    arr[i, k] = -1;
                }
                for (int l = 0; l < row; l++)
                {
                    arr[l, j] = -1;
                }
            }
        }
    }
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < row; j++)
        {
            if (arr[i, j] != -1)
            {
                Console.Write($"{arr[i, j]}\t");
            }
        }
        Console.WriteLine();
    }
}


int[,] arr = FillArray(5, 5, 0, 100);

PrintArray(arr);
Console.WriteLine();
int min = FindMinimum(arr);
Console.WriteLine($"Minimum is {min}");
RemoveMinimums(arr, min);

// Задача 61: Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника