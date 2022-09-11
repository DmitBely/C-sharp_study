Console.Write("Введиите первую координату: ");
int x = int.Parse(Console.ReadLine());
Console.Write("Введиите первую координату: ");
int y = int.Parse(Console.ReadLine());

if (x>0 && y>0)
{
    Console.WriteLine("Первая четверть");
}

else if (x<0 && y>0)
{
    Console.WriteLine("Вторая четверть");
}

else if (x<0 && y<0)
{
    Console.WriteLine("Третья четверть");
}

else if (x>0 && y<0)
{
    Console.WriteLine("Четвёртая четверть");
}
