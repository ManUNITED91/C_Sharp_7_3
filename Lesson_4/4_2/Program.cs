// 2. Напишите программу, которая принимает на вход
//    число N и выдаёт произведение чисел от 1 до N.
int Times(int num)
{
    int sum = 1;
    for (int i = 1;i <= num;i++)
    {
        sum *= i;
        // sum = sum *i;
    }
    return sum;
}
Console.WriteLine("Enter a number: ");
int a = int.Parse(Console.ReadLine()!);
int result = Times(a);
Console.WriteLine(result);