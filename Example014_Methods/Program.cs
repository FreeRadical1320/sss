
//Type 1
// No arguments, No output
void Method1()
{
    Console.WriteLine("Author ...");
}

//Method1();

// Type 2
// Have arguments, No output

void Method2(string msg)
{
    Console.WriteLine(msg);
}
// ethod2("Message");M

void Method21(string msg, int count)
{
    int i = 0;
    while(i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
//Method21("Text", 4);
// Method21( count: 5, msg: "New text");

// Type 3
// Have output, No arguments

int Method3()
{
    return DateTime.Now.Year;
}
//Console.WriteLine(Method3());

// Type 4
// Have arguments and have output

// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty;
//     while(i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }
// string Method4(int count, string text)
// {
//     string result = String.Empty;
//     for(int i = 0; i < count; i++)
//     {
//         result = result + text;
//     }
//     return result;
// }
// Console.WriteLine(Method4(10, "qwerty"));
void Method4()
{
    string result = String.Empty;
    for(int i = 2; i <= 10; i++)
    {
        for(int j = 2; j <= 10; j++)
        {
            Console.WriteLine($"{i} x {j} = {i * j}"); 
        }
        Console.WriteLine();
    }
}
Method4();