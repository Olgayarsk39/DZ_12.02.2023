/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1*/

Console.Clear();
Console.Write("Введите трехзначное число -> ");
int a = int.Parse(Console.ReadLine());
if (a < 100 || a >= 1000)
{
    Console.WriteLine("Введено неверное число");
    return;
}
// int a = new Random().Next(100, 1000);
//int result = (a % 100) / 10;
Console.WriteLine($" {a} -> вторая цифра {(a % 100) / 10}");