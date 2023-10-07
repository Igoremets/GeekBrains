// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.Write("Введите количество чисел: ");
//         int n = int.Parse(Console.ReadLine()); // Ввод количества чисел

//         int count = 0; // Счетчик чисел, больших нуля

//         for (int i = 0; i < n; i++)
//         {
//             Console.Write($"Введите число {i + 1}: ");
//             int number = int.Parse(Console.ReadLine()); // Ввод числа

//             if (number > 0)
//                 count++; // Увеличение счетчика, если число больше нуля
//         }

//         Console.WriteLine($"Количество чисел, больших нуля: {count}");
//     }
// }

// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.Write("Введите значение b1: ");
//         double b1 = double.Parse(Console.ReadLine()); // Ввод значения b1

//         Console.Write("Введите значение k1: ");
//         double k1 = double.Parse(Console.ReadLine()); // Ввод значения k1

//         Console.Write("Введите значение b2: ");
//         double b2 = double.Parse(Console.ReadLine()); // Ввод значения b2

//         Console.Write("Введите значение k2: ");
//         double k2 = double.Parse(Console.ReadLine()); // Ввод значения k2

//         double x = (b2 - b1) / (k1 - k2); // Расчет x-координаты точки пересечения
//         double y = k1 * x + b1; // Расчет y-координаты точки пересечения

//         Console.WriteLine($"Точка пересечения: ({x}; {y})");
//     }
// }