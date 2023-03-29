// Напишите программу, которая на вход принимает позиции элемента в 
// двумерном массиве, и возвращает значение этого элемента 
// или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
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

int[,] MassNums(int row, int column)
{
    int[,] arr = new int[row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            arr[i, j] = i + j;

    return arr;
}
string Position(int[,] arr, int rowPos, int columnPos)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);
    if (row >= rowPos && column >= columnPos && rowPos > 0 && columnPos > 0)
    {
        return $"Position is in the array,value = {arr[rowPos - 1, columnPos - 1]}";
    }
    return "This position isn't in the array";
}

Console.Write("Enter the number of rows: ");
int row_num = int.Parse(Console.ReadLine()!);
Console.Write("Enter the number of columns: ");
int column_num = int.Parse(Console.ReadLine()!);

int[,] mass = MassNums(row_num, column_num);

Print(mass);
Console.Write("Enter the position of row: ");
int posOfrow = int.Parse(Console.ReadLine()!);
Console.Write("Enter the position of column: ");
int posOfcolumn = int.Parse(Console.ReadLine()!);
string showPosition = Position(mass, posOfrow, posOfcolumn);
Console.WriteLine(showPosition);