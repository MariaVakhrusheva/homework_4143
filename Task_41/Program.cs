﻿// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

void CheckPlus(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] > 0) count++;
    Console.Write($"{String.Join(", ", array)} -> {count}");
}

int[] CreateArray(int number)
{
    int[] array = new int[number];
    for (int i = 0; i < number; i++)
        array[i] = GetInput("Вводите эти числа по одному: ");
    return array;
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int number = GetInput("Сколько чисел Вы хотите ввести? : ");
int[] array = CreateArray(number);
CheckPlus(array);