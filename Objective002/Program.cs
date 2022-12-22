Console.Clear();

Console.Write("Введите первое число: ");
int N = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int M = int.Parse(Console.ReadLine());

if (N>M)
{
    Console.WriteLine($"Большее число: {N}");
}
else if (M>N)
{
    Console.WriteLine($"Большее число: {M}");
}
