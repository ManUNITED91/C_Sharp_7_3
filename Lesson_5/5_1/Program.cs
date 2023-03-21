// 1. Напишите программу замена элементов массива:
//    положительные элементы замените на соответствующие отрицательные, и наоборот.
// void Print(int[] arr)
// {
//     int size = arr.Length;

//     for (int i = 0; i < size; i++)
//         Console.Write($"{arr[i]} ");
//     Console.WriteLine();
// }

// int[] EightMass(int size, int from, int to)
// {
//     int[] arr = new int[size];

//     for (int i = 0; i < size; i++)
//         arr[i] = new Random().Next(from, to + 1);
//     return arr;
// }

// void ChangeDig(int[] arr)
// {
    
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] > 0)
//             arr[i]*= -1 ;
//         else if(arr[i]<0)
//             arr[i]*= 1; 
//         else
//             arr[i] = 0; 
//     }
// }

// int num = int.Parse(Console.ReadLine()!);
// int start = int.Parse(Console.ReadLine()!);
// int stop = int.Parse(Console.ReadLine()!);

// int[] mass = EightMass(num, start, stop);
// Print(mass);
// ChangeDig(mass);
// Print(mass);
int[] RandArr()
{
    Console.Write("Enter array length: ");
    int len = int.Parse(Console.ReadLine()!);
    Console.Write("Enter minimal range value: ");
    int min = int.Parse(Console.ReadLine()!);
    Console.Write("Enter maximum range value: ");
    int max = int.Parse(Console.ReadLine()!);
    
    int[] arr = new int[len];
    for (int i = 0; i < len; i++)
    {
        arr[i] = new Random().Next(min, max + 1);
    }
    return arr;
}

void PrintArr(int[] arr)
{
    Console.WriteLine();
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
        
    }
    Console.WriteLine();
    // Console.WriteLine("[{0}]", string.Join(", ", arr));
}

void reverse(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] *= -1;
    }
}

int[] array = RandArr();
PrintArr(array);
reverse(array);
PrintArr(array);