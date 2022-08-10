// По двум заданным числам проверять является ли первое квадратом второго

Console.WriteLine("Введите число, которое будет являться квадратом второго: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine());

int square = a * a;

if ( square == b)
{
    Console.WriteLine("Число: " + a + " " + "является квадратом числа: " + b);
}
else
Console.WriteLine("Число: " + a + " " + "не является квадратом числа: " + b);