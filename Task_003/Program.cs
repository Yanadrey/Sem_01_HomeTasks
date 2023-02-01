Console.Write("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 0)
    System.Console.WriteLine($"{number} - четное число");
else
    System.Console.WriteLine($"{number} - нечетное число");
