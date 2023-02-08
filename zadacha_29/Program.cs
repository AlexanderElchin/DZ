Console.Clear();
Console.Write("введите массив от 1 до 1000: ");
int massiv = int.Parse(Console.ReadLine()!); // это длина нашего массива
while (massiv < 1 || massiv > 1000)
{
    Console.Write("Слишком мало!,ну или слишком много!!! \nвведите числа от 1 до 1000: ");
    massiv = int.Parse(Console.ReadLine()!);
}
int[] array = new int[massiv];
Console.WriteLine("введите числа массива: ");
for (int i = 0; i < array.Length; i++) // заполняем наш массив 
{
    Console.Write($"введите числа: {i} ");
    array[i] = int.Parse(Console.ReadLine()!);
}
Console.Write("введите число Х: ");
int x = Convert.ToInt32(Console.ReadLine());
int count = 0;
for (int i = 0; i < array.Length; i++)

    if (array[i] == x)
        count = count + 1;

if (count < massiv || count > 0)
    Console.WriteLine($"Цифра {x} встречается {count} раз(a)");