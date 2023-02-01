Console.Write("Введите первое число:");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число:");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2)
{
    System.Console.WriteLine($"max={number1} min={number2}");
}
else
{
    if (number2 > number1)
    {
        System.Console.WriteLine($"max={number2} min={number1}");
    }
    else System.Console.WriteLine("Числа равны");
}
