// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.Write("Введите число A: ");
//         int a = int.Parse(Console.ReadLine());

//         Console.Write("Введите число B: ");
//         int b = int.Parse(Console.ReadLine());

//         int result = 1;
//         for (int i = 0; i < b; i++)
//         {
//             result *= a;
//         }

//         Console.WriteLine($"Результат: {result}");
//     }
// }

// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.Write("Введите число: ");
//         int number = int.Parse(Console.ReadLine());

//         int sum = GetDigitsSum(number);

//         Console.WriteLine($"Сумма цифр числа: {sum}");
//     }

//     static int GetDigitsSum(int number)
//     {
//         int sum = 0;

//         while (number != 0)
//         {
//             int digit = number % 10;
//             sum += digit;
//             number /= 10;
//         }

//         return sum;
//     }
// }

// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         // Создание и инициализация массива
//         int[] array = new int[8] { 1, 2, 5, 7, 19, 6, 1, 33 };

//         // Вывод массива на экран
//         Console.Write("[");
//         for (int i = 0; i < array.Length; i++)
//         {
//             Console.Write(array[i]);
//             if (i != array.Length - 1)
//             {
//                 Console.Write(", ");
//             }
//         }
//         Console.WriteLine("]");
//     }
// }
