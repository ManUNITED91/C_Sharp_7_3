// 2. Напишите программу, которая будет
//    преобразовывать десятичное число в двоичное.


string Bin(int num)
{
    string result = "";
    while (num > 0)
    {
        result = num % 2 + result;
        num = num / 2;

    }
    return result;
}
Console.WriteLine("Write a number: ");
int a = int.Parse(Console.ReadLine()!);
string answer  = Bin(a);
Console.WriteLine(answer);


