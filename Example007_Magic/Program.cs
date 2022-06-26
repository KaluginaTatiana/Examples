Console.Clear();
int xa = 39, ya = 1, 
    xb = 1, yb = 41,
    xc = 77, yc = 41;
Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");
Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");
Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");
int x = xa, y = ya;
int count = 0;
while(count < 10000)
{
    int abc = new Random().Next(0, 3);
    if (abc == 0)
    {
        x = (x + xa) / 2;
        y = (y + ya) / 2;
    }
    if (abc == 1)
    {
        x = (x + xb) / 2;
        y = (y + yb) / 2;
    }
    if (abc == 2)
    {
        x = (x + xc) / 2;
        y = (y + yc) / 2;
    }
    Console.SetCursorPosition(x, y);
    Console.Write("+");
    count = count + 1;
}