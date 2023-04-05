// Задайте двумерный массив из целых чисел. Напишите программу,
// которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
void Print(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
            Console.Write($" {arr[i, j], 4}");
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
int[] FindMinEl(int[,] arr)
{
    int[] arr2 = new int[2];
    int minEl = arr[0,0];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if(minEl > arr[i,j])
            {
                minEl = arr[i,j];
                arr2[0] = i;
                arr2[1] = j;
            }
        }
    }
    return arr2;
}
void DelLineOfMinEl(int[,] arr, int[] arr2)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);
    
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
            if (arr2[0] == i || arr2[1] == j) 
            {
                continue;
            }
            else
            {
                Console.Write($"{arr[i, j],4}");
            }
        Console.WriteLine();
    }
    Console.WriteLine();
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

int[] newArr = FindMinEl(mass);
DelLineOfMinEl(mass,newArr);
