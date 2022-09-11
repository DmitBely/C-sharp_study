// Найти сумму чисел одномерного массива стоящих на нечетной позиции 

int[] arr = new int[10];

void PrintArray(int[] col)
{
    for (int i = 0; i < col.Length; i++) Console.WriteLine(col[i]);
}


void FillArray(int[] col)
{
    for(int i = 0; i < col.Length; i++) col[i] = new Random().Next(1, 10);
}

int CountArr(int[] col)
{   
    int sum = 0;
    for(int i = 1; i < col.Length; i = i + 2 ) sum = sum + col[i];
    return sum;
}

FillArray(arr);
PrintArray(arr);
int result = CountArr(arr);
Console.WriteLine($"ответ: {result}");