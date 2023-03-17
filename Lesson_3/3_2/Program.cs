// // 2. Напишите программу, которая принимает на вход координаты
// //    двух точек и находит расстояние между ними в 2D пространстве.
double Distance(int x1, int y1, int x2, int y2)
{
    return Math.Sqrt(Math.Pow(x2 - x1, 2) +Math.Pow(y2 - y1, 2));
}
Console.WriteLine("Write x1:");
int numX1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Write y1:");
int numY1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Write x2:");
int numX2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Write y2:");
int numY2 = int.Parse(Console.ReadLine()!);
double result = Distance(numX1, numY1, numX2, numY2);
Console.WriteLine(result);

// double Distance(int x1, int y1, int x2, int y2)
// {
// return Math.Sqrt(Math.Pow(x2 - x1,2)+Math.Pow(y2-y1,2));
// }
// int x_1 = int.Parse(Console.ReadLine()!);
// int y_1 = int.Parse(Console.ReadLine()!);
// int x_2 = int.Parse(Console.ReadLine()!);
// int y_2 = int.Parse(Console.ReadLine()!);
// double a = Distance(x_1,y_1,x_2,y_2);
// Console.WriteLine(a);