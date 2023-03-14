double[] array = new double[5];
//Решил работать через дабл чтобы можно было задать вещественные числа
double[] fillArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 100);
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
    return array;
}

double finding(double[] array)
{
    double min = array[0];
    double max = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
        if (array[i] > max) max = array[i];
    }
    double result = max - min;
    return result;
}

fillArray(array);
Console.WriteLine(finding(array));