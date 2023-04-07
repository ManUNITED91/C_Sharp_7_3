// 2. Задайте значения M и N. Напишите программу, которая 
//    рекурсивно выведет все натуральные числа в промежутке от M до N.
Console.Write("Enter number M: ");
int numM = int.Parse(Console.ReadLine()!);
Console.WriteLine();
Console.Write("Enter number N: ");
int numN = int.Parse(Console.ReadLine()!);
void NaturalArr(int m, int n)
{
    if(m > n) return;
    NaturalArr(m, n-1);
    Console.Write($"{n} ");
}
NaturalArr(numM,numN);