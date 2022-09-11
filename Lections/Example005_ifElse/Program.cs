Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "дмитрий")
{
    Console.WriteLine("Ура, это же великий король!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}
