Console.Write("Введите трёхзначное число: ");
int number = int.Parse(Console.ReadLine());

int thirdNumber = (number % 10);

Console.WriteLine(thirdNumber);
