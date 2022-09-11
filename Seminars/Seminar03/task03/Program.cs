// Определите количество цифр в числе

Console.WriteLine("Введите число :");
int number = int.Parse(Console.ReadLine());
int count = 1;
int num1 = number;

while ((num1 / 10) > 0)
{
    count++;
    num1 = num1 / 10;
}

Console.WriteLine($"В числе {number}, {count} чисел");