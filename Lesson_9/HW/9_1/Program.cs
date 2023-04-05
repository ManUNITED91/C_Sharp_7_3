// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все
// чётные натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"
Console.Write("Enter number M: ");
int numM = int.Parse(Console.ReadLine()!);
Console.WriteLine();
Console.Write("Enter number N: ");
int numN = int.Parse(Console.ReadLine()!);
void NaturalEvenArr(int m, int n)
{
    if (m > n)
    {
        return;
    }
    else if (m % 2 == 0 && n % 2 == 0)
    {
        NaturalEvenArr(m, n - 2);
        Console.Write($"{n} ");
    }
    else if (m % 2 == 0 && n % 2 != 0)
    {
        n--;
        NaturalEvenArr(m, n - 2);
        Console.Write($"{n} ");
    }
     else if (m % 2 != 0 && n % 2 != 0)
    {
        m++;
        NaturalEvenArr(m, n - 2);
        Console.Write($"{n} ");
    }

}
NaturalEvenArr(numM, numN);