int num = new Random().Next(-100000000, 100000000);
//int num = -123456789;
Console.WriteLine(num);
if (num < 0)
{
    num = num * -1;
}
if (num < 100)
{
    Console.WriteLine("Третьей цифры нет.");
}

if (num >= 100)
{
    while(num > 1000)
    {
        num = num / 10;
    }
    num = num % 10;
    Console.WriteLine(num);
}
