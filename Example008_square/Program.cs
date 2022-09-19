// User input
Console.Clear();
Console.Write("Please, input a = ");

int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Please, input b = ");

int num2 = Convert.ToInt32(Console.ReadLine());

// Calculate square
int square = num2 * num2;

Console.Write($"Square = {square}, Is 'a' the square of 'b'? ");

// Check the condition
if(square == num1)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}
