Console.Write("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 2)
    System.Console.WriteLine($"Нет положительных четных числел < {number}");
else
{
    for (int i = 2; i <= number; i++)
    {
        if (i % 2 == 0)
            Console.Write($"{i} ");
    }
}
