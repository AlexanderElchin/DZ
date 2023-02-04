// Напишите программу, которая принимает 
// на вход координаты двух точек и находит 
// расстояние между ними в 3D пространстве.
Console.Clear();
Console.Write("Введите координату X: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Y: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Z: ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату X: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Y: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Z: ");
double z2 = Convert.ToDouble(Console.ReadLine());
double l = Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2)), 2);
Console.WriteLine($"Результат: {l}");