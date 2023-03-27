//  Напишите программу, которая будет создавать копию заданного
//  двумерного массива с помощью поэлементного копирования.
int[,] CreateArr(int n, int m, int firstNum, int lastNum)
{
    int[,] arr = new int[n, m];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(firstNum, lastNum + 1);
        }
    }
    return arr;
}

void PrintArr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }

}
int[,] CopyArr(int[,] arr)
{
    int[,] arrCopy = new int[arr.GetLength(0),arr.GetLength(1)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arrCopy[i, j] = arr[i,j];
        }
    }
    return arrCopy;
}
Console.WriteLine("Write the number of elements in the first part of array ");
int lenghtFirst = int.Parse(Console.ReadLine()!);
Console.WriteLine("Write the number of elements in the second part of array ");
int lenghtSecond = int.Parse(Console.ReadLine()!);
Console.WriteLine("Write the range (from)");
int dig1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Write the range (to)");
int dig2 = int.Parse(Console.ReadLine()!);
int[,] res = CreateArr(lenghtFirst, lenghtSecond, dig1, dig2);

PrintArr(res);
Console.WriteLine();
int[,] newArr = CopyArr(res);
PrintArr(newArr);
