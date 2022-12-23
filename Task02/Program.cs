/*Напишите программу, которая принимает на вход координаты двух точек 
и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/
using static System.Console;
Write("Введите координату x точки 1: ");
bool isParse1 = int.TryParse(ReadLine(), out int x1);
Write("Введите координату y точки 1: ");
bool isParse2 = int.TryParse(ReadLine(), out int y1);
Write("Введите координату z точки 1: ");
bool isParse3 = int.TryParse(ReadLine(), out int z1);
Write("Введите координату x точки 2: ");
bool isParse4 = int.TryParse(ReadLine(), out int x2);
Write("Введите координату y точки 2: ");
bool isParse5 = int.TryParse(ReadLine(), out int y2);
Write("Введите координату z точки 2: ");
bool isParse6 = int.TryParse(ReadLine(), out int z2);
if (!isParse1 | !isParse2 | !isParse3 | !isParse4 | !isParse5 | !isParse6)
{
    Write("Введено не число");
    return;
}
int deltaX = x2 - x1;
int deltaY = y2 - y1;
int deltaZ = z2 - z1;

double X1 = Math.Pow(deltaX, 2);
double Y1 = Math.Pow(deltaY, 2);
double Z1 = Math.Pow(deltaZ, 2);

double result = Math.Sqrt(X1 + Y1 + Z1);
Write($"Расстояние {result:f2}");