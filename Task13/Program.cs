// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет
using static System.Console;
WriteLine("Введите число");

int a = Convert.ToInt32(ReadLine());

WriteLine( a>100 ? a%10 : "Третьего числа нет");
