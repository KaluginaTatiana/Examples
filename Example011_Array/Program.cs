// Имеется одномерный массив array из n элементов. Требуется найти номер элемента массива, равного find.
int[] array = { 12, 15, 18, 34, 12, 67 };
int index = 0;
int find = 12;
int n = array.Length;
while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}
