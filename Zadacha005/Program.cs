/*5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые 
числа в промежутке от -N до N.
4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
2 -> " -2, -1, 0, 1, 2"*/

Console.Write("Введите число N: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0)
{
    number*=-1; // -5 * -1 = 5 - N   
}
//-N = N*(-1)
// [-N ; N] -> [negativeNumber ; number]
int negativeNumber = number * (-1);
while (negativeNumber <= number) // Пока справедливо условие
{
    Console.WriteLine(negativeNumber);
    negativeNumber++;
    //negativeNumber = negativeNumber + 1
    //Инкремент
    //negativeNumber--
    //negativeNumber = negativeNumber - 1
    //Декремент
    //negativeNumber +=1
}