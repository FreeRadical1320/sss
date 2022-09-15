// // User input
Console.Clear();
Console.Write("Please, input N = ");

int N = Convert.ToInt32(Console.ReadLine());
int count = 0;
int max = 0;

if(N < 0)
{
    count = N;
    max = -N;
}
else
{
    count = -N;
    max = N;
}

while(count <= N)
{
    Console.WriteLine(count);
    count += 1;
} 



// User input
Console.Clear();
Console.Write("Please, input N = ");
int N = Convert.ToInt32(Console.ReadLine());
int result = N%10;
Console.WriteLine($"Last digit = {result}");