// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
void NumDegr(int num1, int num2)
{
    int sum = 1;
    for(int i = 1;i <= num2;i++)
    {
       sum*= num1;
    }
    Console.WriteLine($"{num1}, {num2} ->{sum}");
}
Console.WriteLine("Write number A: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Write number B: ");
int b = int.Parse(Console.ReadLine()!);
NumDegr(a,b);