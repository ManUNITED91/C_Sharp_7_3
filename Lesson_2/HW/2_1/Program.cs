// Напишите программу,которая выводит случайное трёхзначное число и удаляет
// вторую цифру этого числа
// 456 - 46
// 782 - 72
// 918 - 98
int DelSecDig(int num)
{
    Console.WriteLine(num);
    int a = num / 100 * 10;
    int b = num % 10;
    int c = a + b;
    return c;
}
int number = new Random().Next(100,1000);
int result = DelSecDig(number);
Console.WriteLine(result);
