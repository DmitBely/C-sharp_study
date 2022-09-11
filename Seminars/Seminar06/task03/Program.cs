// в двумерном массиве указать позиции числа 
// заданного пользователем или указать, что такого элемента нет

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

void FindInt(int[,] mtrx, int num)
{
    int schet =0;
    for (int i = 0; i < mtrx.GetLength(0); i++)
    {
        for (int j = 0; j < mtrx.GetLength(1); j++)
        {
            if (num == mtrx[i,j]) 
            {
                Console.WriteLine($"Искомый элемент {num} находится в координатах {i},{j}");
                schet++;
            }
            
            
        }
    }
    if (schet == 0) Console.WriteLine($"Элемента {num}");
}




Console.WriteLine("Введите искомое значение: ");
int number = int.Parse(Console.ReadLine());


int[,] array = new int[5,5];
FillArray(array);
PrintArray(array);
FindInt(array, number);