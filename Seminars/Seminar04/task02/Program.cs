// задать массив. заполнить случайными 
// положительными трёхзначными числами 
// и показать кол-во нечётных и чётных чисел


int [] arr = new int[10];

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while(index < length)
    {
        collection[index] = new Random().Next(100, 1000);
        index++;
    }
}

void PrintArray(int[] col)

{
    int count = col.Length;
    int position = 0;
    while(position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

void PositiveNeg(int[] col)
{
    int positive = 0;
    int negative = 0;
    for (int i = 0; i < col.Length; i++)
    {
        if (col[i] % 2 == 0) positive++;
        else negative++;
    }
    Console.WriteLine($"Чётных: {positive}");
    Console.WriteLine($"Нечётных: {negative}");
}

FillArray(arr);
PrintArray(arr);
PositiveNeg(arr);
