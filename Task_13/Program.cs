/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6 */

Console.Clear();

int ThreeNumber(int n){
    while (n > 999 || n < -999)
    {
        n = n / 10;
    }
    return n % 10;}

Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine());
if (n < 100 && n > -100) Console.Write("Третьей цифры нет");
else Console.Write($"Третья цифра -> {ThreeNumber(n)}");
