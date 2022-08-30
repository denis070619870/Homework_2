// Найти сумму чисел от 1 до А

Console.WriteLine("Введите число до которого нужно посчитать сумму всех чисел:");
int A = int.Parse(Console.ReadLine());
Console.WriteLine();

int count = 1;
int sum = 0;


while (count <= A)
{
    Console.Write(sum = sum + count);
    count = count + 1;
}
Console.WriteLine();
Console.WriteLine($"Сумма чисел от 1 до {A} составляет {sum}");
Console.WriteLine();