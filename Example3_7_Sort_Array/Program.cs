// Сортировка массива методом выбора
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int k = i + 1; k < array.Length; k++)
        {
            if (array[k] < array[minPosition])
                minPosition = k;
        }
        int bufer = array[i];
        array[i] = array[minPosition];
        array[minPosition] = bufer;
    }
}



int[] array = {3, 6, 9, 8, 4, 5, 4, 3, 1, 2};
PrintArray(array);
SelectionSort(array);
PrintArray(array);