// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным
using static System.Console;
WriteLine("Введите номер дня недели");

int a = Convert.ToInt32(ReadLine());

WriteLine(a==1 ? "Monday": a==2 ? 
                "Tuesday": a==3 ? 
                "Wednesday": a==4 ? 
                "Thursday": a==5 ? 
                "Friday": a==6 ? 
                "Saturday": a==7 ? 
                "Sunday": "В неделе только семь дней");
