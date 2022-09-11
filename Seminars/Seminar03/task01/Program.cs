// Показать таблицу квадратов чисел от 1 до N 
void FillNumber(int number1)
{
   
   int count = 1;

while (count <= number1)
{
    Console.WriteLine($"{count} + {count} = {count + count}");
    count++;
}
}

Console.WriteLine("Введите число N :");
int number = int.Parse(Console.ReadLine());

FillNumber(number);
