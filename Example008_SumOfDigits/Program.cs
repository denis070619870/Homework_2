﻿// Подсчитать сумму цифр в числе

Console.WriteLine("Введите число, чтобы сумму цифр из которых оно состоит: ");
string n = Console.ReadLine();
int num = Convert.ToInt32(n);
int result = num;

int count = 0;

while (result > 0)
{
    result = result / 10;
    count++;
}
Console.WriteLine($"В числе{num} имеется {count} чисел.");
Console.WriteLine();
