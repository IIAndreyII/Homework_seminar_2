Console.Write("Введите цифру, обозначающую день недели: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num >= 1 && num <= 5)
{
    Console.WriteLine("Это рабочий день.");
}

if (num == 6 || num == 7)
{
    Console.WriteLine("Ура! Выходной!");
}

if (num < 1 || num > 7)
{
    Console.WriteLine("Такого дня нет.");
}
