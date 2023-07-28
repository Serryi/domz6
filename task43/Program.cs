// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

double b1 = GetDouble("Введите значение b1: ");
double k1 = GetDouble("Введите значение k1: ");
double b2 = GetDouble("Введите значение b2: ");
double k2 = GetDouble("Введите значение k2: ");

double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;

Console.WriteLine($"Точка пересечения: ({x}; {y})");


static double GetDouble(string message)
{
    Console.WriteLine(message);
    double num = double.Parse(Console.ReadLine());
    return num;
}
