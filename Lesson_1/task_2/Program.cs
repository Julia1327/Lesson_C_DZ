﻿// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
int max = 0;
int min = 0;

if (a < b)
{
    max = b;
    min = a;
    Console.Write("Максимальное число: " + max + ". " + "Минимальное число: " + min);
}

else if (b < a)
{
    max = a;
    min = b;
    Console.Write("Максимальное число: " + max + ". " + "Минимальное число: " + min);
}
