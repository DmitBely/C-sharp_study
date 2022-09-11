// Написать программу преобразования десятичного числа в двоичное

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());


string result = String.Empty;

while (num > 0)
{
    result = Convert.ToString(num % 2) + result;
    num = num / 2;
}
Console.WriteLine(result);
