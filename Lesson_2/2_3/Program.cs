// 3. Напишите программу, которая принимает на вход число и проверяет,
//    кратно ли оно одновременно 7 и 23.

// 14 -> нет
// 46 -> нет
// 161 -> да
void del(int nm1)
{
    if (nm1 % 7 == 0 && nm1 % 23 == 0)
    {
        Console.WriteLine("Yes");
    }
    else
    {
        Console.WriteLine("NO");
    }
}
int a = new Random().Next(1,1000); 
Console.WriteLine(a);
del(a);
