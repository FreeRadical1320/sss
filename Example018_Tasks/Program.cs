// // Задача 17: Напишите программу, которая на вход принимает две координаты точки X и Y 
// // и выдаёт, в какую координатную четверть попадает точка.


// Console.Clear();
// Console.Write("Please, input x = ");

// int x = Convert.ToInt32(Console.ReadLine());

// Console.Write("Please, input y = ");

// int y = Convert.ToInt32(Console.ReadLine());

// int N = 0;
// if(x > 0)
// {
//     if(y > 0) N = 1;
//     else N = 4;
// }
// else if(x < 0)
// {
//     if(y < 0) N = 3;
//     else N = 2;
// }
// Console.WriteLine($"Point with coordinates x = {x}, y = {y} locates in {N} quarter.");

// Задача 18: Напишите программу, которая на вход принимает две координаты точки X и Y 
// и выдаёт, в какую координатную четверть попадает точка.


// Console.Clear();
// Console.Write("Please, input quarter number [1, 4] = ");

// int N = Convert.ToInt32(Console.ReadLine());

// string x = string.Empty;
// string x1 = "x = (0, infinity)";
// string x2 = "x = (-infinity, 0)";

// string y = string.Empty;
// string y1 = "y = (0, infinity)";
// string y2 = "y = (-infinity, 0)";

// if(N < 1 || N > 4) 
// {
//     Console.WriteLine($"Input error: the number must be in range [1, 4]!!!");
// }
// else if(N == 1)
// {
//     x = x1;
//     y = y1;
// }
// else if(N == 2)
// {
//     x = x2;
//     y = y1;
// }
// else if(N == 3)
// {
//     x = x2;
//     y = y2;
// }
// else if(N == 4)
// {
//     x = x1;
//     y = y2;
// }

// Console.WriteLine($"The {N} quarter includes points with such coordinates range: {x}, {y}.");


// Задача 21: Напишите программу, которая на вход принимает координаты двух точек 
// и находит расстояние между ними в 2D.

// Console.Clear();
// Console.Write("Please, input xa = ");

// int xa = Convert.ToInt32(Console.ReadLine());

// Console.Write("Please, input ya = ");

// int ya = Convert.ToInt32(Console.ReadLine());

// Console.Write("Please, input xb = ");

// int xb = Convert.ToInt32(Console.ReadLine());

// Console.Write("Please, input yb = ");

// int yb = Convert.ToInt32(Console.ReadLine());

// double distance = Math.Sqrt(Math.Pow((xb - xa), 2) + Math.Pow((yb - ya), 2));


// Console.WriteLine($"The distance between A({xa}, {ya}) and B({xb}, {yb}) is equal: {Math.Round(distance, 2)}.");




// Задача 22: Напишите программу, которая на вход принимает число N 
// и выдает таблицу квадратов чисел от 1 до N.

Console.Clear();
Console.Write("Please, input N = ");

int N = Convert.ToInt32(Console.ReadLine());

for(int i = 1; i <= N; i++)
{
    Console.Write($"{Math.Pow(i, 2)}, ");
}
Console.WriteLine(); 