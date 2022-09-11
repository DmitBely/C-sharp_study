// В двумерном массиве n на k заменить чётные элементы на противоположные

Console.WriteLine("Введите кол-во строк: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов: ");
int k = int.Parse(Console.ReadLine());

int[,] array = new int[n,k];


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



void ChangeToMinus(int[,] mtrx)
{
    for (int i = 0; i < mtrx.GetLength(0); i++)
    {
        for (int j = 0; j < mtrx.GetLength(1); j++)
        {
            if (mtrx[i,j] % 2 == 0)
            {
                mtrx[i, j] = mtrx[i, j] * (-1);
            }
        }
    }

}




FillArray(array);
PrintArray(array);
Console.WriteLine();
ChangeToMinus(array);
PrintArray(array);
