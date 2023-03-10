// 1. Напишите программу, которая выводит случайное число
//    из отрезка [10, 99] и показывает наибольшую цифру числа.
int Num(int num)
{
    Console.WriteLine(num);
    int num1 = num / 10;
    int num2 = num1 % 10;
    if (num1 > num2) return num1;
    return num2;
}
int a = Num(new Random().Next(10, 100));
Console.WriteLine(a);