Console.Write("Please, input user name ");
string username = Console.ReadLine();
if(username.ToLower() == "masha")
{
    Console.WriteLine("Huray! Here is Masha!");
}
else
{
    Console.Write("Hello, ");
    Console.WriteLine(username);
}