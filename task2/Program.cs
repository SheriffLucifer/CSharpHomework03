Console.Write("Введите координаты X первой точки: ");
int XA = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите координаты Y первой точки: ");
int YA = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите координаты Z первой точки: ");
int ZA = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите координаты X второй точки: ");
int XB = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите координаты Y второй точки: ");
int YB = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите координаты Z второй точки: ");
int ZB = int.Parse(Console.ReadLine() ?? "");

double result = Math.Sqrt(Math.Pow(XA - XB, 2) + Math.Pow(YB - YA, 2) + Math.Pow(ZA - ZB, 2));
result = Math.Round(result, 2);

Console.WriteLine($"A ({XA},{YA},{ZA}); B ({XB},{YB},{ZB}) -> {result}");