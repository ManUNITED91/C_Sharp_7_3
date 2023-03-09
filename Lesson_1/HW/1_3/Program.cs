// Напишите программу, которая на вход принимает число (N), а на выходе
//  показывает все чётные числа от 1 до N.
Console.WriteLine("Write a number: ");
int num = int.Parse(Console.ReadLine()!);
int a = 2;
int count = 0 ;
while (num >= a )
{
    count = a;
    a = a + 2;
    Console.WriteLine(count);
}

