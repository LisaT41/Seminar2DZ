// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа. Не использовать строки для расчета.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int ReadInt(string message)
{
    System.Console.Write($"{message} > ");
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int number = ReadInt("enter number");
int lastDigit = number / 10 % 10;
System.Console.WriteLine($"Seconde chiffre of number {number} egal {lastDigit}");
