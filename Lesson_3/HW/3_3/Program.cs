﻿// Напишите программу, которая принимает на вход число (N) и 
// выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
void Dig3(int num)
{
    int a = 1;
    while(a <= num)
    {
        Console.WriteLine(a*a*a);
        a++;
    } 
}
Console.WriteLine("Write a number:");
int number = int.Parse(Console.ReadLine()!);
Dig3(number);