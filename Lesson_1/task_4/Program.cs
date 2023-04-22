// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());

int max = 0;
int min = 0;

if (a < b)
{
    max = b;
    min = a;
    if (max < c)
    max = c;
    Console.Write("Максимальное число: " + max);
}

else 
{
    max = a;
    min = b;
    if (max < c)
    max = c;
    Console.Write("Максимальное число: " + max);
}

