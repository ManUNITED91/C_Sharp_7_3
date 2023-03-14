// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
Console.WriteLine("Write a number of a day: ");
int numOfday = int.Parse(Console.ReadLine()!);
int DayOfWeek(int day)
{
    if (day ==6 | day == 7)
    {
        Console.WriteLine($"{day} is weekend");
    }
    else if (day >= 1 && day <= 5){
        Console.WriteLine($"{day} is a working day");
    }
    else
    {
        Console.WriteLine($"{day} is not even a day");
    }
    return day;
}
DayOfWeek(numOfday);