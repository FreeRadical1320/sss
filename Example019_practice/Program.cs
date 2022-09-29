// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10

// Console.Clear();
// Console.Write("Please, input A = ");

// int A = Convert.ToInt32(Console.ReadLine());
// int sum = 0;

// for(int i = 1; i <= A; i++)
// {
//     sum += i;
// }
// Console.WriteLine(sum); 


// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

// Console.Clear();
// Console.Write("Please, input number ");

// long N = Convert.ToInt64(Console.ReadLine());
// int nDigits = 0;
// while(N > 0)
// {
//     N /= 10;
//     nDigits += 1;
// }
// Console.WriteLine($"Number includes {nDigits} digits.");


// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

// Console.Clear();
// Console.Write("Please, input N = ");

// int A = Convert.ToInt32(Console.ReadLine());
// int prod = 1;

// for(int i = 1; i <= A; i++)
// {
//     prod *= i;
// }
// Console.WriteLine(prod); 

// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int[] arr = new int[8];

Console.Write("[");

for(int i = 0; i < 8; i++)
{
    arr[i] = new Random().Next(0, 2);
    Console.Write($"{arr[i]}, ");
}
Console.WriteLine("]");