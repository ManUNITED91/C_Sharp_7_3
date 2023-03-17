// Напишите программу, которая принимает на вход пятизначное число и 
// проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

void Digit5(int num)
{
    if (num > 9999 && num < 100000)
    {
        int a = num % 10;
        int b = num /10 %10;
        int c = num / 1000;
        int d = c % 10;
        int e = c / 10;
        Console.WriteLine($"{a},{b},{num / 100 % 10},{d},{e}");
        if(a == e && b == d)
        {
            Console.WriteLine($"{num} -> palindrome");
        }
        else
        {
            Console.WriteLine($"{num} -> isn't palindrome");
        }
    }
    else
    {
        Console.WriteLine($"{num} is not a 5-digit digit");
    }
}
Console.WriteLine("Write a number: ");   
int dig = int.Parse(Console.ReadLine()!);
Digit5(dig);

