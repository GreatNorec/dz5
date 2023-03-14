int[] array = new int[4];

int[] fillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100, 100);
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
    return array;
}

int SumArray(int[] array)
{
    int Sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if ( i % 2 == 1)  Sum = Sum + array[i];
    }
    return Sum;
}

fillArray(array);
Console.WriteLine(SumArray(array));