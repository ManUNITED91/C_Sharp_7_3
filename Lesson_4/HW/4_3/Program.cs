// Напишите программу, которая задаёт массив из 8 элементов случайными числами
// и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
int[] CreateArr(int n, int firstNum, int lastNum)
{
    int[] arr = new int[n];
    for (int i = 0; i < n; i++)
    {
        arr[i] = new Random().Next(firstNum, lastNum);
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
}
Console.WriteLine("Write the number of elements in the array");
int lenght = int.Parse(Console.ReadLine()!);
Console.WriteLine("Write the range (from)");
int dig1 = int.Parse(Console.ReadLine()!); 
Console.WriteLine("Write the range (to)");
int dig2 = int.Parse(Console.ReadLine()!);
int[] res = CreateArr(lenght,dig1,dig2);

PrintArr(res);


