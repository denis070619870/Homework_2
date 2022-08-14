// Написать программу вычисления произведения чисел от 1 до N
Console.WriteLine("Введите число, до которого нужно вывести произведения чисел: ");
int n = int.Parse(Console.ReadLine());

int count = 1;

while (count <= n)
{
    for ( int i = 2; i <=n; i++)
    {
        for (int j =2; j <=n; j++)
        {
            Console.WriteLine($"{i} * {j} = {i * j} ");
        }
        Console.WriteLine();
    }
    break;
}

