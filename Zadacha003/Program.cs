﻿/*3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
3 -> Среда 
5 -> Пятница*/

Console.Write("Введите число: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());
if(dayNumber == 1)
{
    Console.WriteLine("Понедельник");
}
if(dayNumber == 2)
{
    Console.WriteLine("Вторник");
}
if(dayNumber == 3)
{
    Console.WriteLine("Среда");
}
if(dayNumber == 4)
{
    Console.WriteLine("Четверг");
}
if(dayNumber == 5)
{
    Console.WriteLine("Пятница");
}
if(dayNumber == 6)
{
    Console.WriteLine("Суббота");
}
if(dayNumber == 7)
{
    Console.WriteLine("Воскресенье");
}