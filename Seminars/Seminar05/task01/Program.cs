// Выяснить являются ли три числа сторонами треугольника 

Console.WriteLine("Сторона 1: ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Сторона 2: ");
int b = int.Parse(Console.ReadLine());

Console.WriteLine("Сторона 3: ");
int c = int.Parse(Console.ReadLine());


void IsTriangle(int a, int b, int c)
{
    if (((a + b) > c) & ((b + c) > a) & ((a + c) > b))
    {
        Console.WriteLine("Это треугольник");
    }
    else
    {
        Console.WriteLine("Это не треугольник");    
    }
}


IsTriangle(a, b, c);