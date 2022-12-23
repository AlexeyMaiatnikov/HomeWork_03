/*Напишите программу, которая принимает на вход число (N) 
и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/
using static System.Console;
Write("Введите число N: ");
bool isParse = int.TryParse((ReadLine()), out int N);
if (!isParse)
{
    Write("Введено не число");
    return;
}
int count = 1;
WriteLine($"Кубы от 1 до {N}");
while (count <= N)
{
    double result = Math.Pow(count, 3);
    count = count + 1;
    Write($"{result} ");
}
