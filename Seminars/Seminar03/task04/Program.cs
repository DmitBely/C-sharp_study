// Задать массив из 8 элементов и вывести его на экран

int[] array = {1, 2, 3, 4, 5, 6, 7, 8};

int index = 0;

while (index < array.Length)
{ 
    Console.Write($" {array[index]} "); 
    index++;
}
Console.WriteLine();