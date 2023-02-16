// Площадь треугольника
// (Время: 1 сек. Память: 16 Мб Сложность: 15%)
// По целочисленным координатам вершин треугольника (x1,y1), (x2,y2) и (x3,y3) требуется вычислить его площадь.
// Входные данные
// Входной файл INPUT.TXT содержит 6 целых чисел x1,y1,x2,y2,x3,y3 – координаты вершин треугольника. 
// Все числа не превышают 106 по абсолютной величине.
// Выходные данные
// В выходной файл OUTPUT.TXT выведите точное значение площади заданного треугольника.
Console.Clear();
Console.Write("Введите x1: ");
double x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите y1: ");
double y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите x2: ");
double x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите y2: ");
double y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите x3: ");
double x3 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите y3: ");
double y3 = Convert.ToInt32(Console.ReadLine());
double s = 0.5 * (x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2));
Console.WriteLine($"s:{s * (-1)}");





