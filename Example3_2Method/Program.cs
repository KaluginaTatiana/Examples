// 2 вид - что-то принимает, ничего не возвращает
void Method2(string msg)
{
    Console.WriteLine(msg);
}

Method2(msg: "Первый текст");
Method2("Второй текст");

void Method2_1(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}

Method2_1("Третий текст", 4);
Method2_1(msg: "Четвертый текст", count: 4); // именованный запуск, порядок задания переменных не важен
Method2_1(count: 4, msg: "Пятый текст"); // именованный запуск, порядок задания переменных не важен