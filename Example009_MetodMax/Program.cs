// Создание метода нахождения максимального из 3-х чисел
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
int a1 = 151344;
int b1 = 18;
int c1 = 23;
int a2 = 55;
int b2 = 1;
int c2 = 203;
int a3 = 58;
int b3 = 1111;
int c3 = 209399;

// int Max1 = Max(a1, b1, c1);
// int Max1 = Max(a2, b2, c2);
// int Max1 = Max(a3, b3, c3);
// int max = Max(Max1, Max2, Max3);

int max = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3));

Console.WriteLine(max);