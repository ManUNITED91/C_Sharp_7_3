//Напишите программу, которая на вход принимает два числа и выдаёт, какое число 
//большее, а какое меньшее.
Console.WriteLine("Write a first number: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Write a second number: ");
int b = int.Parse(Console.ReadLine()!);
if (a > b){
    Console.WriteLine($"max = {a}, min = {b} ");
}
else if (b > a){
    Console.WriteLine($"max = {b}, min = {a} ");
}
else {
    Console.WriteLine($"numbers {a} and {b} are equal");
}