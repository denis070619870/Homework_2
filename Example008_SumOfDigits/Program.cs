// Подсчитать сумму цифр в числе

Console.WriteLine("Введите число, чтобы сумму цифр из которых оно состоит: ");
int n = int.Parse(Console.ReadLine());

int sum = 0;
int digit = 0;

while (n > 0)
{
    digit = n % 10;
    sum = sum + digit;
    n = n / 10;
}

Console.WriteLine($"Сумма всех чисел в числе{n} будет составлять: {sum}");