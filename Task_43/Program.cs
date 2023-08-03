﻿// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void FindPoint(int b1, int k1, int b2, int k2)
{
    if (k1 == k2) Console.Write("Прямые параллельны");
    else
    {
        int x = (b2 - b1) / (k1 - k2);
        int y = k1 * x + b1;
        Console.Write($"Точка пересечения прямых X: {x}, Y: {y}");
    }
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int b1 = GetInput("Введите значение b1: ");
int k1 = GetInput("Введите значение k1: ");
int b2 = GetInput("Введите значение b2: ");
int k2 = GetInput("Введите значение b2: ");
FindPoint(b1, k1, b2, k2);