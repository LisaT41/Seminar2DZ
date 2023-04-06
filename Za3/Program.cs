// Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.
//6  -> да 
// 7 -> да 
// 1 -> нет

var Monday = "1";
var Tuesday = "2";
var Wensday = "3";
var Thursday = "4";
var Friday = "5";
var Saterday = "6";
var Sunday = "7";

System.Console.WriteLine("Enter number of day");
var input = int.Parse(Console.ReadLine());

if (input == 1)
{
    Console.WriteLine("No");
}
if (input == 2)
{
    Console.WriteLine("No");
}
if (input == 3)
{
    Console.WriteLine("No");
}
if (input == 4)
{
    Console.WriteLine("No");
}
if (input == 5)
{
    Console.WriteLine("No");
}
if (input == 6)
{
    Console.WriteLine("Yes");
}
if (input == 7)
{
    Console.WriteLine("Yes");
}
else if (input > 7)
{
    Console.WriteLine("Your number not correctly");
}
