// Показать натуральные числа от N до 1, N задано

void PrintNumbers(int N)
{
    if(N < 1) return;
    Console.Write(N + " ");
    PrintNumbers(N - 1);
}
PrintNumbers(20);
