// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Введите значение N:");
//         int n = int.Parse(Console.ReadLine());
        
//         PrintNumbers(n);
//         Console.ReadLine();
//     }

//     static void PrintNumbers(int n)
//     {
//         if (n <= 0)
//             return;
        
//         Console.Write("{0}, ", n);
//         PrintNumbers(n - 1);
//     }
// }

// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Введите значение M:");
//         int m = int.Parse(Console.ReadLine());

//         Console.WriteLine("Введите значение N:");
//         int n = int.Parse(Console.ReadLine());

//         int sum = CalculateSum(m, n);
//         Console.WriteLine("Сумма натуральных элементов в промежутке от {0} до {1} равна: {2}", m, n, sum);

//         Console.ReadLine();
//     }

//     static int CalculateSum(int m, int n)
//     {
//         int sum = 0;

//         for (int i = m; i <= n; i++)
//         {
//             sum += i;
//         }

//         return sum;
//     }
// }

// using System;

// // class Program
// // {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Введите значение m:");
//         int m = int.Parse(Console.ReadLine());

//         Console.WriteLine("Введите значение n:");
//         int n = int.Parse(Console.ReadLine());

//         int result = Ackermann(m, n);
//         Console.WriteLine("A({0}, {1}) = {2}", m, n, result);

//         Console.ReadLine();
//     }

//     static int Ackermann(int m, int n)
//     {
//         if (m == 0)
//         {
//             return n + 1;
//         }
//         else if (m > 0 && n == 0)
//         {
//             return Ackermann(m - 1, 1);
//         }
//         else
//         {
//             return Ackermann(m - 1, Ackermann(m, n - 1));
//         }
//     }
// }