// Написать программу замену элементов массива на противоположные 
void PrintElements(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($" {array[i] * -1} ");
    }
    Console.WriteLine();
}
int[] arr = {1, 4, 6, 7, 8, 23, 67, -5};
PrintElements(arr);