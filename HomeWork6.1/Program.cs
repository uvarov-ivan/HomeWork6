// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double InputDouble(string msg)
{
    System.Console.Write(msg + " > ");
    return Convert.ToDouble(Console.ReadLine());
}

double FindX(double b1, double k1, double b2, double k2)
{
    return (b2 - b1) / (k1 - k2);
}

double FindY(double b1, double k1, double x)
{
    return k1 * x + b1;
}

double b1 = InputDouble("Введите значение b1");
double k1 = InputDouble("Введите значение k1");
double b2 = InputDouble("Введите значение b2");
double k2 = InputDouble("Введите значение k2");

if (k1 == k2)
{
    System.Console.WriteLine("Линии параллельны, точки пересечения нет!");
}
else
{
    System.Console.WriteLine($"Точка пересечения прямых с введёнными данными: Y = {FindY(b1, k1, FindX(b1, k1, b2, k2))}, X = {FindX(b1, k1, b2, k2)}.");
}
