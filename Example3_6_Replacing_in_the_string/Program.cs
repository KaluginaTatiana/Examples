// Дан текст. Нужно в тексте заменить пробелы знаком |, заглавные К заменить строчными к, 
// строчные С заменить на заглавные С
string text = "На краю дороги стоял дуб. Вероятно, в десять раз старше берез, "
            + "составлявших лес, он был в десять раз толще, и в два раза выше каждой березы."
            + " Это был огромный, в два обхвата дуб, с обломанными, давно, видно, суками и"
            + " с обломанной корой, заросшей старыми болячками.";
// string text = "abcde"
//                01234
// text[1] // b

string Change(string story, char old, char updated)
{
    string result = String.Empty;
    int length = story.Length;
    for (int i = 0; i < length; i++)
    {
        if (story[i] == old)
        result = result + $"{updated}";
        else
        result = result + $"{story[i]}";
    }
    return result;
}
Console.WriteLine();
Console.WriteLine(text);
Console.WriteLine();
string newText = Change(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();
newText = Change(newText, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();
newText = Change(newText, 'с', 'С');
Console.WriteLine(newText);
Console.WriteLine();