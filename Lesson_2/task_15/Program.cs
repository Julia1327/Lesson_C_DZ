// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет


Console.Write("Введите номер дня недели (от 1 до 7 включительно): ");
int number = Convert.ToInt32(Console.ReadLine());

switch (number)
{
    case 1:
    Console.WriteLine("Не выходной");
    break;

    case 2:
    Console.WriteLine("Не выходной");
    break;

    case 3:
    Console.WriteLine("Не выходной");
    break;

    case 4:
    Console.WriteLine("Не выходной");
    break;

    case 5:
    Console.WriteLine("Не выходной");
    break;

    case 6:
    Console.WriteLine("Выходной");
    break;

    case 7:
    Console.WriteLine("Выходной");
    break;

    default:
    Console.WriteLine("Введен не номер дня недели");
    break;
}