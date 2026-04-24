const string printArrayFormat = "{0}";
int[] array = [1, 2, 3, 4, 5];

PrintArray(array);
Clear(array);
PrintArray(array);

void PrintArray<T>(T[] data)
{
    foreach (T value in data)
    {
        Console.Write(
            printArrayFormat,
            value
        );
    }
    Console.WriteLine();
}

void Clear<T>(T[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = default(T);
    }
}