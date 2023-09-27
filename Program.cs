// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Введите трехзначное число:");
//         int number = int.Parse(Console.ReadLine());

//         int secondDigit = (number / 10) % 10;
//         Console.WriteLine("Вторая цифра числа: " + secondDigit);
//     }
// }


// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// using System;

// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine("Введите число:");
//         int number = int.Parse(Console.ReadLine());

//         int thirdDigit = GetNthDigit(number, 3);

//         if (thirdDigit == -1)
//         {
//             Console.WriteLine("Третьей цифры нет");
//         }
//         else
//         {
//             Console.WriteLine("Третья цифра числа: " + thirdDigit);
//         }
//     }

//     static int GetNthDigit(int number, int n)
//     {
//         number = Math.Abs(number);

//         int digitCount = CountDigits(number);

//         if (digitCount >= n)
//         {
//             int divisor = (int)Math.Pow(10, digitCount - n);
//             number /= divisor;
//             return number % 10;
//         }
//         else
//         {
//             return -1;
//         }
//     }

//     static int CountDigits(int number)
//     {
//         int count = 0;

//         while (number != 0)
//         {
//             number /= 10;
//             count++;
//         }

//         return count;
//     }
// }



// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите число, обозначающее день недели (1-7):");
        int day = int.Parse(Console.ReadLine());

        bool isWeekend = IsWeekend(day);

        if (isWeekend)
        {
            Console.WriteLine("Да, это выходной день.");
        }
        else
        {
            Console.WriteLine("Нет, это не выходной день.");
        }
    }

    static bool IsWeekend(int day)
    {
        return day == 6 || day == 7;
    }
}