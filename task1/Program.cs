Console.Write("Введите пятизначное число: ");
int number = int.Parse(Console.ReadLine() ?? "");

int num1 = number / 10000 % 10;
int num2 = number / 1000 % 10;
int num4 = number / 10 % 10;
int num5 = number % 10;

if (num1 == num5 && num2 == num4)
{
    Console.Write($"{number} -> является палиндромом.");
}
else
{
    Console.Write($"{number} -> не является палиндромом.");
}