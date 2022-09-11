// Даны два числа. Показать больше и меньшее.

int numberA = new Random().Next(1, 10);
Console.WriteLine(numberA);
int numberB = new Random().Next(1, 10);
Console.WriteLine(numberB);

int max = 0;
int min = 0;

if(numberA > numberB) 
{
    max = numberA;
    min = numberB;
}
else
{
    max = numberB;
    min = numberA;
}

Console.Write("Максимальное число: ");
Console.WriteLine(max);
Console.Write("Минимальное число: ");
Console.WriteLine(min);
