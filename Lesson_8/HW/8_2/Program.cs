// Задайте прямоугольный двумерный массив. Напишите программу, которая будет 
// находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
void Print(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
            Console.Write($" {arr[i, j]} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] MassNums(int row, int column, int from, int to)
{
    int[,] arr = new int[row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            arr[i, j] = new Random().Next(from, to + 1);

    return arr;
}
int[] MinSum(int[,] arr)
{
    int[] minlValue = new int[arr.GetLength(0)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum += arr[i, j];
        }
        minlValue[i] = sum;
    }
    return minlValue;
}
void Minimal(int[] arr)
{
    int valMin = arr[0];
    int rowIndex = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        
        if (valMin > arr[i])
        {
            
            valMin = arr[i];
            rowIndex = i;
        }
    }
    Console.WriteLine($"{rowIndex + 1},{valMin}");
    
}
Console.Write("Enter the number of rows: ");
int rowNum = int.Parse(Console.ReadLine()!);
Console.Write("Enter the number of columns: ");
int columnNum = int.Parse(Console.ReadLine()!);

Console.Write("Enter the min number of massive ");
int start = int.Parse(Console.ReadLine()!);
Console.Write("Enter the max number of massive ");
int stop = int.Parse(Console.ReadLine()!);

int[,] mass = MassNums(rowNum, columnNum, start, stop);

Print(mass);

int[] sumArr = MinSum(mass);
Minimal(sumArr);

