using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите первое число:");
        int a = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите второе число:");
        int b = int.Parse(Console.ReadLine());

        int max = Math.Max(a, b);
        int min = Math.Min(a, b);

        Console.WriteLine($"Максимальное число: {max}");
        Console.WriteLine($"Минимальное число: {min}");
    }
}

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите первое число:");
        int a = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите второе число:");
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите третье число:");
        int c = int.Parse(Console.ReadLine());

        int max = Math.Max(Math.Max(a, b), c);

        Console.WriteLine($"Максимальное число: {max}");
    }
}

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите число:");
        int number = int.Parse(Console.ReadLine());

        if (number % 2 == 0)
        {
            Console.WriteLine("Число является четным.");
        }
        else
        {
            Console.WriteLine("Число не является четным.");
        }
    }
}

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите число:");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Четные числа от 1 до {0}: ", n);
        for (int i = 2; i <= n; i += 2)
        {
            Console.Write(i + " ");
        }

        Console.WriteLine();
    }
}

