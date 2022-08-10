// По двум заданным числам проверять является ли одно квадратом другого

Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine());

if (a * a == b)
{
    Console.WriteLine("число " + a + " "+ "является квадратом числа: " + b);
}
else if (b * b == a)
{
    Console.WriteLine("число " + b + " "+ "является квадратом числа: " + a);
}
else
{
    Console.WriteLine("числа не являются квадратом друг друга");
}