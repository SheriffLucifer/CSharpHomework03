Console.Write("Введите целое число: ");
int number = int.Parse(Console.ReadLine() ?? "");

int count = 1;

Console.Write($"{number} -> ");
while (count <= number)
{
    Console.Write($"{Math.Pow(count, 3)}, ");
    count++;
}