// В матрицее чисел найти сумму элементов главной диагонали

void FillArray(int[,] mtrx)
{
    for (int i = 0; i < mtrx.GetLength(0); i++)
    {
        for (int j = 0; j < mtrx.GetLength(1); j++)
        {
            mtrx[i,j] = new Random().Next(1,10);
        }
    }
}

void PrintArray(int[,] mtrx)
{
    for (int i = 0; i < mtrx.GetLength(0); i++)
    {
        for (int j = 0; j < mtrx.GetLength(1); j++)
        {
            Console.Write($"{mtrx[i,j]} "); 
        }
    Console.WriteLine();
    }
}




void SumArray(int[,] mtrx)
{   
    int summa = 0;
    for (int i = 0; i < mtrx.GetLength(0); i++)
    {
        for (int j = 0; j < mtrx.GetLength(1); j++)
        {
            if (i == j) summa = summa + mtrx[i,j];
        }
    }
    Console.WriteLine(summa);
}



int[,] array = new int[10,10];
FillArray(array);
PrintArray(array);
Console.WriteLine();
SumArray(array);
