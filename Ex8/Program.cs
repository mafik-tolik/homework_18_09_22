// Задача 8: Напишите программу, которая на вход принимает число (N > 0), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Clear();

// int N = 2; // в условиях на выходе должны быть чётные числа от 1 до N. 1 - нечетное, поэтому начинать будем с 2. 

// Console.WriteLine("Введите целое число от 2 и более:");
// int number = Convert.ToInt32(Console.ReadLine());

// while (number < 2)
// {
//     Console.WriteLine("Введите целое число от 2 и более:");
//     number = Convert.ToInt32(Console.ReadLine());
// }

// //---------------

// while (N <= number)
// {
//    Console.Write(N + ", ");
//    N = N + 1;
// }
// Console.Write("\b\b");
// Console.WriteLine();


double a = 7;
double b = 2;

double prim1 = a / b;
double prim2 = a%b;

Console.WriteLine("prim1 = " + prim1);
Console.WriteLine("prim2 = " + prim2);