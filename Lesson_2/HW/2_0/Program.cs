//Напишите программу, которая принимает на вход трёхзначное число и на выходе 
// показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
int SecDig(int digit)
{
   return digit / 10 % 10;
}
Console.WriteLine("Введите трехзначное число");
int num = int.Parse(Console.ReadLine()!);
int result = SecDig(num);
Console.WriteLine(result);