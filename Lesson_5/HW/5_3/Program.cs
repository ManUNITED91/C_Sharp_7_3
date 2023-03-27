// Задайте массив вещественных чисел. Найдите разницу между максимальным 
// и минимальным элементов массива.
// [3 7 22 2 78] -> 76
double[] CreateArr(int n, double firstNum, double lastNum)
{
    double[] arr = new double[n];
    for (int i = 0; i < n; i++)
    {
        arr[i] = new Random().NextDouble() * (lastNum - firstNum) + firstNum;
    }
    return arr;
}

void PrintArr(double[] arr)
{
    int count = arr.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}
void Diff(double[] arr)
{
    double minVal = arr[0];
    double maxVal = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (minVal > arr[i])
        {
            minVal = arr[i];
        }
        else if (maxVal < arr[i])
        {
            maxVal = arr[i];
        }
    }

    Console.WriteLine($"The difference between max el {maxVal} and min el {minVal} = {maxVal - minVal}");
}
Console.WriteLine("Write the number of elements in the array");
int lenght = int.Parse(Console.ReadLine()!);
Console.WriteLine("Write the range (from)");
double dig1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Write the range (to)");
double dig2 = double.Parse(Console.ReadLine()!);
double[] res = CreateArr(lenght, dig1, dig2);

PrintArr(res);
Diff(res);
