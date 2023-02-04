Console.Clear();
Console.Write("наша грядка вмещает кусты от 3 до 1000: ");
int kusti = int.Parse(Console.ReadLine()); // это длина нашего массива
while (kusti < 3 || kusti > 1000)
{
    Console.Write("Слишком мало!,ну или слишком много!!! \nвведите число кустов от 3 до 1000: ");
    kusti = int.Parse(Console.ReadLine());
}
int[] array = new int[kusti];
Console.WriteLine("введите сколько ягод растет на каждом кусте: ");
for (int i = 0; i < array.Length; i++) // заполняем наш массив ягодками
{
    Console.Write($"введите число ягод: {i} ");
    array[i] = int.Parse(Console.ReadLine());
}
int max = 0;
for (int i = 1; i < array.Length - 1; i++) // считаем ягодки (sum), проверяем макс
{
    int sum = array[i - 1] + array[i] + array[i + 1];
    if (sum > max)
        max = sum;
}
if (array[0] + array[1] + array[array.Length - 1] > max)
    max = array[0] + array[1] + array[array.Length - 1];

if (array[array.Length - 1] + array[array.Length - 2] + array[0] > max)
    max = array[array.Length - 1] + array[array.Length - 2] + array[0];

Console.WriteLine($"наш комбайн собрал: {max}");