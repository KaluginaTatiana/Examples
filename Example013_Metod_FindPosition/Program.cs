// Создание метода нахождения позиции элемента таблицы

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}
void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }

}

int IndexOff(int[] array, int find)
{
    int length = array.Length;
    int count = 0;
    int position = -1;
    while (count < length)
    {
        if (array[count] == find)
        {
            position = count;
            break;
        }
        count++;
    }
    return position;
}

int[] array = new int[10];
FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOff(array, 5);
Console.WriteLine(pos);