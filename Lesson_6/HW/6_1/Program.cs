// Пользователь вводит с клавиатуры M чисел. Посчитайте,
// сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
int[] CreateArr(int n)
{
    int[] arr = new int[n];
    Console.WriteLine("Write the value of numbers");
    for (int i = 0; i < n; i++)
    {
        arr[i] = int.Parse(Console.ReadLine()!);
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

void Bigger0(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length;i++)
    {
        if(arr[i] > 0)
        {
            count +=1;
        }
    }
    Console.WriteLine($"The numbers that bigger than zero = {count}");
}
Console.WriteLine("Write the number of elements in the array");
int lenght = int.Parse(Console.ReadLine()!);
int[] res = CreateArr(lenght);
PrintArr(res);
Bigger0 (res);