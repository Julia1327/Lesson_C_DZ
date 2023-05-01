// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());



int result = number / 100 % 10;
int result1 = number % 10;

if (number < 100)
    Console.WriteLine("Третьего числа нет");
    

else if (number > 10000)
    Console.WriteLine("Третья цифра числа: " + result);



else if (number < 100 || number < 1000)
    Console.WriteLine("Третья цифра числа: " + result1);



