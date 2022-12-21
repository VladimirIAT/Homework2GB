// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
using static System.Console;
WriteLine("Введите трехзначное число");
int a = Convert.ToInt32(ReadLine());

WriteLine(a%100/10);