//Два друга идут навстречу друг другу. Один из друзей - с собакой. 
//Пока друзья идут навстречу друг другу, собака убегает от хозяина навстречу его другу, 
//добегает до друга хозяина и бежит обратно к хозяину, добегает до хозяина и бежит обратно к его другу. 
//И так бегает туда-сюда до момента встречи друзей. 
//В момент встречи расстояние между друзьями 10 метров.
double timeS, distanceM, distanceKM, Friend1Speed, Friend2Speed, DogSpeed;
int Friend = 2;
int count = 0;
Console.Write("Введите первичное расстояние между друзьями в метрах ");
distanceM = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите скорость хозяина собаки в км/ч ");
Friend1Speed = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите скорость друга, который идет навстречу, в км/ч ");
Friend2Speed = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите скорость собаки в км/ч ");
DogSpeed = Convert.ToDouble(Console.ReadLine());
distanceKM = distanceM/1000;
while(distanceM > 10)
{
    if(Friend == 1)
    {
        timeS = distanceM/((Friend1Speed + DogSpeed)/3.6);
        Friend = 2;
    }
    else
    {
        timeS = distanceM/((Friend2Speed + DogSpeed)/3.6);
        Friend = 1;
    }
    distanceM = distanceM - ((Friend1Speed + Friend2Speed)/3.6)*timeS;
    count = count + 1;
}
Console.WriteLine();
Console.WriteLine("Заданные параметры:");
Console.Write("Первичное расстояние между друзьями ");
Console.Write(distanceKM);
Console.WriteLine(" километров.");
Console.Write("Скорость друга с собакой ");
Console.Write(Friend1Speed);
Console.WriteLine(" км/ч.");
Console.Write("Скорость второго друга ");
Console.Write(Friend2Speed);
Console.WriteLine(" км/ч.");
Console.Write("Скорость собаки ");
Console.Write(DogSpeed);
Console.WriteLine(" км/ч.");
Console.WriteLine();
Console.WriteLine("Результат:");
Console.Write("До момента встречи друзей собака будет бегать от хозяина собаки до его друга и обратно ");
Console.Write(count);
Console.WriteLine(" раз.");