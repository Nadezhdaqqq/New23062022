Console.WriteLine("Введите имя: ");
string username = Console.ReadLine();

if (username.ToLower() == "маша")
{
Console.WriteLine("I love Маша");
}
else
{
    Console.Write("А где Маша, ");
    Console.WriteLine(username);
}
