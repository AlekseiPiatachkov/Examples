Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "маша")
{
    Console.Write("Ура, это же Маша!");
    Console.Write("Привет, ");
    Console.WriteLine(username);
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}
