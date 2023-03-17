// 2.Напишите программу, которая принимает на вход координаты двух 
// точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
double Dist(int x1,int y1,int z1, int x2, int y2,int z2)
{
    double result = Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2)+
    Math.Pow(z2-z1,2));
    return result;
}
Console.WriteLine("Write number of x2: ");
int num_x2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Write number of x1: ");
int num_x1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Write number of y2: ");
int num_y2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Write number of y1: ");
int num_y1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Write number of z2: ");
int num_z2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Write number of y2: ");
int num_z1 = int.Parse(Console.ReadLine()!);

double res = Dist(num_x1,num_y1,num_z1,num_x2,num_y2,num_z2);
Console.WriteLine(res);