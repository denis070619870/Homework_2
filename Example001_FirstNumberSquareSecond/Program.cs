﻿// Дано число обозначающее день недели. Выяснить является номер дня недели выходным

Console.WriteLine("Введите номер дня недели: ");
int numberDay = int.Parse(Console.ReadLine());

while (numberDay > 5)
{
    Console.WriteLine("Этот день выходной");
    break;
}
   if (numberDay == 1)
    {
        Console.WriteLine("Понедельник");
    }
    else if (numberDay == 2)
    {
        Console.WriteLine("Вторник");
    }
    else if (numberDay == 3)
    {
        Console.WriteLine("Среда");
    }
    else if (numberDay == 4)
    {
        Console.WriteLine("Четверг");
    }
    else if (numberDay == 5)
    {
        Console.WriteLine("Пятница");
    }
    else if (numberDay == 6)
    {
        Console.WriteLine("Суббота");
    }
    else if (numberDay == 7)
    {
        Console.WriteLine("Воскресенье");
    }