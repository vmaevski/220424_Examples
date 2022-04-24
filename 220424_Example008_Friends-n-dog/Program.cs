double count=0, distance = 10000, friend1Speed = 1, friend2Speed = 2, dogSpeed = 5, friend = 2;
double time = 0;

while (distance > 10)
{
    if (friend == 1)
    {
        time = distance / (friend2Speed + dogSpeed);
        friend = 2;
    }
    else
    {
        time = distance / (friend1Speed + dogSpeed);
        friend = 1;
    }
    distance = distance - (friend1Speed + friend2Speed) * time;
    count++;
}
Console.Write("Собака пробежит ");
Console.Write(count);
Console.WriteLine(" раз.");