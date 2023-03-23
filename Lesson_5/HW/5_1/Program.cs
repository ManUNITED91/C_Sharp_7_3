// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.WriteLine("Write the number of elements in the array");
int lenght = int.Parse(Console.ReadLine()!);
Console.WriteLine("Write the range (from)");
int dig1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Write the range (to)");
int dig2 = int.Parse(Console.ReadLine()!);
if (dig1 > 99 && dig2 < 1000 && dig1 < 1000 && dig2>99 && dig1 < dig2)
{
    int[] res = CreateArr(lenght, dig1, dig2);
    int even = EvenNum(res);
    Console.WriteLine($"The quantity of even numbers are {even}");
    PrintArr(res);
}
else if ( dig1 > dig2)
{
    Console.WriteLine("The first digit cannot be bigger than the second digit");
}
else
{
    Console.WriteLine("The number is not 3-digit digit");
}
// Создание массива
int[] CreateArr(int n, int firstNum, int lastNum)
{
    int[] arr = new int[n];
    for (int i = 0; i < n; i++)
    {
        arr[i] = new Random().Next(firstNum, lastNum + 1);
    }
    return arr;
}
// Вывод массива
void PrintArr(int[] arr)
{
    int count = arr.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}
// Вывод количетсва четных числе в массиве
int EvenNum(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            count += 1;
        }
    }
    return count;
}

