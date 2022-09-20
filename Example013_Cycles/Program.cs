// Task 1
// int x = new Random().Next(10, 100);

// Console.WriteLine(x);

// int x1 = x % 10;
// int x2 = x / 10;

// if(x1 > x2)
// {
//     Console.WriteLine(x1);
// }
// else
// {
//     Console.WriteLine(x2);
// }

// Task 2
// int x = new Random().Next(100, 1000);

// Console.WriteLine(x);

// int nDecades = x % 10;
// int xNew = (x / 100) * 10 + x % 10 ;

// Console.WriteLine(xNew);

// Task 3

Console.Clear();
Console.Write("Please, input x1 = ");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Please, input x2 = ");
int x2 = Convert.ToInt32(Console.ReadLine());

int result = x1 % x2;
if(result == 0)
{
    Console.WriteLine("Кратно");
}
else
{
    Console.WriteLine(result);
}