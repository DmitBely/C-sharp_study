int numberA = 21; //new Random().Next(1,500);

Console.WriteLine(numberA);

if ((numberA % 7 == 0) && (numberA % 23 == 0))
{
    int result = numberA;
    Console.WriteLine($"Число {result} кратно 7 и 23");
}
else
{
    Console.WriteLine("Не кратно");
}
