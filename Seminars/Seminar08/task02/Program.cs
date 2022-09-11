// Показать натуральные числа от 1 до N, N задано

void PrintArray(int n)
{
    if(n < 1) return;
    PrintArray(n - 1);
    Console.Write(n + " ");
}

PrintArray(5);