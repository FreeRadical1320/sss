// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"


void PrintNumbers(int N, int n)
{
    if(n <= N) 
    {
        Console.Write($"{n}, ");
        PrintNumbers(N, ++n);
    }
    return;
}

Console.Clear();
// Console.WriteLine("Please input N: ");
// int N = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Please input M: ");
// int M = Convert.ToInt32(Console.ReadLine());

// PrintNumbers(N, M);
// Console.WriteLine();

// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

// Console.WriteLine("Please input N: ");
// int N = Convert.ToInt32(Console.ReadLine());
// int res = 0;
// int Sum(int n, int res)
// {
    
//     if(n == 0) return res;
//     res += n % 10;
//     n /= 10;
//     return Sum(n, res);
// }
// Console.WriteLine(Sum(N, 0));


// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

Console.WriteLine("Please input A: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please input B: ");
int b = Convert.ToInt32(Console.ReadLine());


int Product(int n, int a, int res)
{
    if(n == 0) return res;
    res *= a;
    n--;
    return Product(n, a, res);
}
int res = 1;
Console.WriteLine(Product(b, a, res));