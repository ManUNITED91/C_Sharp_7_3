//Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
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
int[,] MatrixTimes(int[,] matr1, int[,] matr2)
{
    int[,] res = new int[matr1.GetLength(0), matr2.GetLength(1)];
    int sum = 0;
    if (matr1.GetLength(1) == matr2.GetLength(0))
    {
        for (int i = 0; i < matr1.GetLength(0); i++)
        {
            for (int j = 0; j < matr2.GetLength(1); j++)
            {
                sum = 0;
                for (int k = 0; k < matr1.GetLength(1); k++)
                {
                    sum += matr1[i, k] * matr2[k, j];
                }
                res[i,j] = sum;

            }
        }
    }
    return res;
}

Console.Write("Enter the number of rows in matrix1: ");
int rowNum = int.Parse(Console.ReadLine()!);
Console.Write("Enter the number of columns in matrix1: ");
int columnNum = int.Parse(Console.ReadLine()!);

Console.Write("Enter the min number of massive1: ");
int start = int.Parse(Console.ReadLine()!);
Console.Write("Enter the max number of massive1: ");
int stop = int.Parse(Console.ReadLine()!);

Console.Write("Enter the number of rows in matrix2: ");
int rowNum2 = int.Parse(Console.ReadLine()!);
Console.Write("Enter the number of columns in matrix2: ");
int columnNum2 = int.Parse(Console.ReadLine()!);

Console.Write("Enter the min number of massive2: ");
int start2 = int.Parse(Console.ReadLine()!);
Console.Write("Enter the max number of massive2: ");
int stop2 = int.Parse(Console.ReadLine()!);
int[,] massFirst = MassNums(rowNum, columnNum, start, stop);
int[,] massSec = MassNums(rowNum2, columnNum2, start2, stop2);

Print(massFirst);
Print(massSec);

int[,] matrixTimes = MatrixTimes(massFirst, massSec);
Print(matrixTimes);