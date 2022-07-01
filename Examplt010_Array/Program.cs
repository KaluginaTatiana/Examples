// Создание массива и использование метода
int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result)
    {
        result = arg2;
    }
    if (arg3 > result)
    {
        result = arg3;
    }
    return result;
}


int[] Array1 = { 11, 55, 67, 45, 213, 43, 239, 26, 2115 };

int max =  Max(Max(Array1[0], Array1[1], Array1[2]), Max(Array1[3], Array1[4], Array1[5]), Max(Array1[6], Array1[7], Array1[8]));
Console.WriteLine(max);