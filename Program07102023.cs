// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         // Создание генератора случайных чисел
//         Random random = new Random();

//         // Создание массива
//         int[] numbers = new int[4]; // Здесь число 4 указывает на размер массива

//         // Заполнение массива случайными трехзначными числами
//         for (int i = 0; i < numbers.Length; i++)
//         {
//             numbers[i] = random.Next(100, 1000); // Генерация случайного числа от 100 до 999
//         }

//         // Подсчет количества четных чисел в массиве
//         int count = 0;
//         for (int i = 0; i < numbers.Length; i++)
//         {
//             if (numbers[i] % 2 == 0)
//             {
//                 count++;
//             }
//         }

//         // Вывод результата
//         Console.WriteLine($"Количество четных чисел в массиве: {count}");
//     }
// }

// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         // Создание генератора случайных чисел
//         Random random = new Random();

//         // Создание массива
//         int[] numbers = new int[4]; // Здесь число 4 указывает на размер массива

//         // Заполнение массива случайными числами
//         for (int i = 0; i < numbers.Length; i++)
//         {
//             numbers[i] = random.Next(-100, 100); // Генерация случайного числа от -100 до 99
//         }

//         // Нахождение суммы элементов, стоящих на нечетных позициях
//         int sum = 0;
//         for (int i = 1; i < numbers.Length; i += 2)
//         {
//             sum += numbers[i];
//         }

//         // Вывод результата
//         Console.WriteLine($"Сумма элементов на нечетных позициях: {sum}");
//     }
// }

// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         // Создание массива вещественных чисел
//         double[] numbers = new double[] { 3.22, 4.2, 1.15, 77.15, 65.2 }; // Можно изменить значения элементов массива

//         // Нахождение максимального и минимального элементов массива
//         double max = numbers[0];
//         double min = numbers[0];

//         for (int i = 1; i < numbers.Length; i++)
//         {
//             if (numbers[i] > max)
//                 max = numbers[i];
            
//             if (numbers[i] < min)
//                 min = numbers[i];
//         }

//         // Вычисление разницы
//         double difference = max - min;

//         // Вывод результата
//         Console.WriteLine($"Разница между максимальным и минимальным элементами: {difference}");
//     }
// }