/*Напишите программу, которая принимает на вход пятизначное 
число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/
using static System.Console;
Write("Введите пятизначное число: ");
bool isParse = int.TryParse(ReadLine(), out int result);
if (!isParse)
{
    WriteLine("Введено не число!");
    return;
}
if (result < 10000 || result >= 100000)
{
    WriteLine("Число не пятизначное");
    return;
}
if (result >= 10000 && result < 100000 && result / 10000 == result % 10)
{
    WriteLine("Да");
}
else
{
    WriteLine("Нет");
}

