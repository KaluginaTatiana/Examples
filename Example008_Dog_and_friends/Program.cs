double time;
double distance = 10000;
double Friend1Speed = 1;
double Friend2Speed = 2;
double DogSpeed = 5;
int Friend = 2;
int count = 0;
while(distance > 10)
{
    if(Friend == 1)
    {
        time = distance/(Friend1Speed + DogSpeed);
        Friend = 2;
    }
    else
    {
        time = distance/(Friend2Speed + DogSpeed);
        Friend = 1;
    }
    distance = distance - (Friend1Speed + Friend2Speed)*time;
    count = count + 1;
}
Console.Write("Собака пробежит ");
Console.Write(count);
Console.WriteLine(" раз.");