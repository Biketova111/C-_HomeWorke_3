/*  Задача 21

Напишите программу, которая принимает на вход координаты двух точек 
и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53 */


using System;

int GetNumber(string message)
{
    int result = 0;
    while (true)
    {
        Console.Write(message);
        if (int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Вы ввели не число. Повторите ввод");
        }
    }
    return result;
}

double GetDistance (int x1, int y1, int z1, int x2, int y2, int z2)
{
    double result = Math.Round(Math.Sqrt(Math.Pow((x2-x1),2)+Math.Pow((y2-y1),2)+Math.Pow((z2-z1),2)),2);
    return result;
}

Console.WriteLine ("Ведите координаты точки А:");
int xa = GetNumber("xa = ");
int ya = GetNumber("ya = ");
int za = GetNumber("za = ");
Console.WriteLine ("Ведите координаты точки В:");
int xb = GetNumber("xb = ");
int yb = GetNumber("yb = ");
int zb = GetNumber("zb = ");

double distance = GetDistance(xa, ya, za, xb, yb, zb);

Console.WriteLine ($"Расстояние между точками А и В в 3D пространстве равно {distance}");