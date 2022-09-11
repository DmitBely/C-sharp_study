Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

int minusNumber = (number *(-1));
int count = 0;

while(count <= number)
{
    Console.Write(" " + minusNumber);
    minusNumber++;
}
Console.WriteLine();