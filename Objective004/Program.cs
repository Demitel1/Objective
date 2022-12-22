Console.Clear();

Console.Write("Введите первое число: ");
int B = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int N = int.Parse(Console.ReadLine());
Console.Write("Введите третье число: ");
int M = int.Parse(Console.ReadLine());

if (M<B && N<B)
{
    Console.WriteLine($"Большее число: {B}");
}
else if (B<N && M<N)
{
    Console.WriteLine($"Большее число: {N}");
}
else if (B<M && N<M)
{
    Console.WriteLine($"Большее число: {M}");
}
