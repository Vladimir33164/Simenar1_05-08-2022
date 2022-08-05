/*1. Напишите программу, которая на вход принимает два 
числа и проверяет, является ли первое число квадратом второго.

a = 25, b = 5 -> да 
a = 2, b = 10 -> нет 
a = 9, b = -3 -> да 
a = -3 b = 9 -> нет*/

Console.Write("Введите число №1: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число №2: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
if(firstNumber == secondNumber * secondNumber) //firstNumber = 25:secondNumber = 5
{
if(firstNumber == secondNumber * secondNumber) //firstNumber = 25:secondNumber = 5
    Console.WriteLine(firstNumber + " является квадратом от " + secondNumber);
    //Конкатенация - это сложение двух строк "1" + "1" = "11"
}
    // "!=" - проверка на неравенство. Например: 5 != 5 - False
    // "!==" - равенство. Например: 5 == 5 - True
else // if (firstNumber !!!= secondNumber * secondNumber) 
{
    Console.WriteLine(firstNumber + " Не является квадратом от " + secondNumber);
}