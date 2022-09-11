// Показать числа Фибоначчи меньшие заданного числа N 

Console.WriteLine("Введиите число: ");
int num = int.Parse(Console.ReadLine());

int fib1 = 1;
int fib2 = 1;


int i =0;
while (i < (num -2))
    {
        int fibsum = fib1 + fib2;
        fib1 = fib2;
        fib2 = fibsum;
        i++;
        Console.WriteLine(fibsum);
    }
