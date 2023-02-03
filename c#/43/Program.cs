//  Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
Console.Clear();
Console.Write("Введите k1: ");
double k1 = double.Parse(Console.ReadLine());

Console.Write("Введите k2: ");
double k2 = double.Parse(Console.ReadLine());

Console.Write("Введите b1: ");
double b1 = double.Parse(Console.ReadLine());

Console.Write("Введите b2: ");
double b2 = double.Parse(Console.ReadLine());

double x = -(b1 - b2) / (k1 - k2);
double y = k1 * x + b1;

x = Math.Round(x, 3);
y = Math.Round(y, 3);
 
Console.Write($"Пересечиние в точке : ({x};{y})");