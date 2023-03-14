int[] array = new int[4];

int[] fillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
        Console.Write($"{array[i]} ");
    }
    return array;
}

int counter(int[] arr)
{
    int Count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) Count++;
    }
    return Count;
}

fillArray(array);
Console.WriteLine();
Console.WriteLine(counter(array));