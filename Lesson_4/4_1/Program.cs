int Digits(int num)
{
    int dig_sum = 0;
    for (int i=1;num > 0;i++ )
    {
        num = num / 10;
        dig_sum = i;
    }
    return dig_sum;
}
Console.WriteLine("Enter a number: ");
int a = int.Parse(Console.ReadLine()!);
int result = Digits(a);
Console.WriteLine(result);