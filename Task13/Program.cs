// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет
using static System.Console;
WriteLine("Введите число");

int a = Convert.ToInt32(ReadLine());

WriteLine( a<100 ? "Третьего числа нет" : a<1000 ? a%10 : a<10000 ? a%100/10 : a<100000 ? a%1000/100 : "Введите число до 100000") ;
