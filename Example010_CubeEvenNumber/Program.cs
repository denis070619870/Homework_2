// Показать кубы чисел, заканчивающихся на четную цифру

Console.WriteLine("Введите число до которого нужно вывести кубы четных чисел:");
int n = int.Parse(Console.ReadLine());

int count = 1;

while (count <= n)
{
    if (count % 2 == 0)
    {
        int cubNumber = count * count * count;
        if (cubNumber % 2 == 0) 
        {
            Console.Write(cubNumber + " ");
        }
    }
    count = count + 1;
}
