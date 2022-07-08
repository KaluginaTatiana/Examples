// 4 вид - что-то принимает, что-то возвращает
// обязательно указывается тип данных метода, так как их нужно будет возвращать, обязаьельно указываются переменные
string Method4(int count, string text) 
{
    int i = 0;
    string result = String.Empty; // нужно присвоить переменной какое то значение, в данном случае - пустую строку
    while ( i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}

string res = Method4(5, "ab");  //написать ab 5 раз
Console.WriteLine(res);

// тот же метод, только с другим видом цикла
string Method4_1(int count, string text) 
{
    string result = String.Empty; // нужно присвоить переменной какое то значение, в данном случае - пустую строку
    for ( int i =0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}

string res1 = Method4_1(5, "ab");  //написать ab 5 раз
Console.WriteLine(res1);