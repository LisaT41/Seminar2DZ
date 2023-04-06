// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. Не использовать строки для расчета.
// 645 -> 5
// 78 -> третьей цифры нет
// 326792 -> 6

int ReadInt(string message)
{
    Console.Write($"{message} > ");
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int number = ReadInt("enter number");
if (number >= 100)
{
    while (number > 1000)
    {
        Console.WriteLine(number = number / 10);
    }
int lastDigit = number % 10;
Console.WriteLine($"Third digit of number {number} egal {lastDigit}");
}
else
{
    Console.WriteLine("Number have not third digit");
}

