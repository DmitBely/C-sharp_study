// Найти сумму чисел от 1 до А 

Console.WriteLine("Введите число А: ");


int numA = int.Parse(Console.ReadLine());

int count = 1;
int sum = 0;

while (count <= numA)
{
    sum += count;
    count++;
}

Console.WriteLine($"Сумма чисел от 1 до {numA} = {sum}");