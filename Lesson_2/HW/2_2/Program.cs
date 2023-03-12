// Напишите программу, которая выводит третью цифру заданного числа или 
// сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6



Console.WriteLine("Write a number: ");
int num = int.Parse(Console.ReadLine()!);
int ThirdDig(int num1)
{
    while (num1 > 999)
    {
        num1 = num1 / 10;
    }
    return num1 % 10;
}
if (num > 99)
{
    int result = ThirdDig(num);
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("Нет третьей цифры");
}

