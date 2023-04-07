// Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30
Console.WriteLine("Write M number: ");
int numM = int.Parse(Console.ReadLine()!);
Console.WriteLine("Write N number: ");
int numN = int.Parse(Console.ReadLine()!);

int SumEl(int m,int n)
{
    if (m > n) return 0;
    return  n + SumEl(m,n-1);
}
Console.Write(SumEl(numM,numN));