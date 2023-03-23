//  Напишите программу, которая принимает на вход число и 
// выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
int SumDig(int num)
{
    int sum = 0;
    while (num > 0)
    {
        int a = num % 10;
        sum = sum + a;
        num = num / 10;
    }
    return sum;
}
Console.WriteLine("Write a number: ");
int dig = int.Parse(Console.ReadLine()!);
int res = SumDig(dig);
Console.WriteLine(res);