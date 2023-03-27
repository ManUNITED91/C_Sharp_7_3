//  Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
Console.WriteLine("Write the value of b1");
double b1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Write the value of k1");
double k1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Write the value of b2");
double b2 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Write the value of k2");
double k2 = double.Parse(Console.ReadLine()!);

void DotOfCross(double a1,double c1,double a2,double c2)
{
    if (a1 == a2 && c1 == c2)
    {
        Console.WriteLine("Прямые наложились друг на друга");
    }
    else if( a1 == a2)
    {
        Console.WriteLine("Прямые параллельны");
    }
    else
    {
        double x = (b2 - b1) / (k1 - k2);
        double y = k1 * x + b1;
        Console.WriteLine($"Пересечение в точке: ({x};{y})");
    }
}
DotOfCross(b1,k1,b2,k2);