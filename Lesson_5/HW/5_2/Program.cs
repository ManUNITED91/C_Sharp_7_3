//  Задайте одномерный массив, заполненный случайными числами. 
//  Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 26
// [-4, -6, 89, 6] -> 85
int[] CreateArr(int n, int firstNum, int lastNum)
{
    int[] arr = new int[n];
    for (int i = 0; i < n; i++)
    {
        arr[i] = new Random().Next(firstNum, lastNum + 1);
    }
    return arr;
}

void PrintArr(int[] arr)
{
    int count = arr.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}
// Сумма элементов, стоящих на нечётных позициях
void SumOfEl(int[] arr)
{
    int sum = 0;
    for(int i = 0; i < arr.Length;i+=2)
    {
       sum = sum + arr[i];
    }
    Console.WriteLine($"The value of odd index = {sum}");
}
Console.WriteLine("Write the number of elements in the array");
int lenght = int.Parse(Console.ReadLine()!);
Console.WriteLine("Write the range (from)");
int dig1 = int.Parse(Console.ReadLine()!); 
Console.WriteLine("Write the range (to)");
int dig2 = int.Parse(Console.ReadLine()!);
int[] res = CreateArr(lenght,dig1,dig2);

PrintArr(res);
SumOfEl(res);