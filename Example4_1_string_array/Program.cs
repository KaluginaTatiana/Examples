// Создание двумерного массива строк
string[,] array = new string [2, 5];
// По умолчанию массив заполняется пустыми строками константой String.Empty

array[1, 2] = "слово";
for (int i = 0; i < 2; i++)
{
    for (int j = 0; j < 5; j++)
    {
        Console.Write($"-{array[i, j]}- ");
    }
    Console.WriteLine(" ");

}