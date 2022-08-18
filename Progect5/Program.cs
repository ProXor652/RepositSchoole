Console.Write ("Введите имя пользователя");
string username = Console.ReadLine();

if(username.ToLower() == "вика")
{
    Console.WriteLine("Привет, Жопа");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}