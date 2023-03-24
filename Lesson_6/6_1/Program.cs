// 1. Напишите программу, которая принимает на вход три числа
//    и проверяет, может ли существовать треугольник с сторонами такой длины.
int a = int.Parse(Console.ReadLine()!);
int b = int.Parse(Console.ReadLine()!);
int c = int.Parse(Console.ReadLine()!);
void IsItTr(int num, int num1, int num2)
{
    if (num < num1 + num2 && num1 < num + num2 && num2 < num + num1)
        Console.WriteLine("Yes");
    else Console.WriteLine("No");
}
IsItTr(a,b,c);
