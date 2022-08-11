// Задать номер четверти, показать диапазоны для возможных координат

Console.WriteLine("Введите номер четверти от 1 до 4-й, чтобы узнать ее координаты: ");
int QuartNumb = int.Parse(Console.ReadLine());

string range = "";

if (QuartNumb == 1) range = "x > 0, y > 0";
else if (QuartNumb == 2) range = "x > 0, y < ";
else if (QuartNumb == 3) range = "x < 0, y > 0";
else if (QuartNumb == 4 ) range = "x > 0, y < 0";
else if (QuartNumb > 4 ) range = "Отсутствуют";
{
     Console.WriteLine("Введен неверный номер четверти. Введите значение от 1 до 4-х");
}

Console.WriteLine($"Координаты для {QuartNumb} четверти: {range}");
Console.WriteLine();
