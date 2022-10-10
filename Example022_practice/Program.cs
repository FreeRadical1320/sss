// Задача 39:** Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

Console.Clear();

void PrintArray(int[] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        Console.Write($"{arr[i]}\t");
    }
    Console.WriteLine();
}

int[] FillArray(int lng, int lowBorder, int highBorder)
{
    int[] arr = new int[lng];
    for(int i = 0; i < lng; i++)
    {
        arr[i] = new Random().Next(lowBorder, highBorder + 1);
    }
    return arr;
}
// int[] arr = FillArray(15, 100, 999);

// PrintArray(arr);

int[] ReverseArray(int[] arr)
{
    int tmp;
    int j = arr.Length - 1;
    for(int i = 0; i < j; i++)
    {
        tmp = arr[i];
        arr[i] = arr[j];
        arr[j] = tmp;
        j--;
    }
    return arr;
}

// PrintArray(ReverseArray(arr));

// Задача 40:** Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.

// **Теорема о неравенстве треугольника:** каждая сторона треугольника меньше суммы двух других сторон.

// Console.Write("Please, input a = ");

// int a = Convert.ToInt32(Console.ReadLine());

// Console.Write("Please, input b = ");

// int b = Convert.ToInt32(Console.ReadLine());

// Console.Write("Please, input c = ");

// int c = Convert.ToInt32(Console.ReadLine());

// string isExist = string.Empty;

// if((a + b > c) && (a + c > b) && (c + b > a)) isExist = "exist";
// else isExist = "not exist";

// Console.WriteLine($"Triangle with the sizes {a}, {b} and {c} {isExist}.");


// Задача 42:** Напишите программу, которая будет преобразовывать десятичное число в двоичное.

// 45 -> 101101
// 3 -> 11
// 2 -> 10

// Console.Write("Please, input N = ");

// double N = Convert.ToInt32(Console.ReadLine());

// int[] binary = new int[16];
// double factor = 0;

// for(int i = 15; i >= 0; i--)
// {
//     factor = Math.Pow(2, i);
//     if(N >= factor)
//     {
//         binary[i] = 1;
//         N -= factor;
//     } 
// }

// PrintArray(binary);  
// PrintArray(ReverseArray(binary));  

Console.Write("Please, input N = ");

int dec = Convert.ToInt32(Console.ReadLine());

string binary = string.Empty;

while(dec != 0)
{
    binary = Convert.ToString(dec % 2) + binary;
    dec = dec / 2;
}

Console.WriteLine(binary);   



// Задача 44:** Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

// Console.Write("Please, input N = ");
// int N = Convert.ToInt32(Console.ReadLine());

// int[] arr;
// if(N > 1)
// {
//     arr = new int[N];
//     arr[0] = 0;
//     arr[1] = 1;
//     if(N > 2)
//     {
//         for(int i = 2; i < N; i++)
//         {
//             arr[i] = arr[i - 1] + arr[i - 2];
//         }
//     }
// } 
// else
// {
//     arr = new int[1] {0};
// }

// PrintArray(arr);

// Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

// int[] CopyArray(int[] arr)
// {
//     int lng = arr.Length;
//     int[] new_arr = new int[lng];
//     for(int i = 0; i < lng; i++)
//     {
//         new_arr[i] = arr[i];
//     }
//     return new_arr;
// }
// int[] arr = FillArray(7, -100, 100);

// PrintArray(arr);

// PrintArray(CopyArray(arr));