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
Console.Write("введите число K: ");
int K = Convert.ToInt32(Console.ReadLine()); // вводим число на которое нам нужно сдвинуть наш массив
if (K > 0)
{
    for (int j = 0; j < K; j++)
    {
        int temp = array[array.Length - 1];
        for (int i = array.Length - 1; i > 0; i--)
        {
            array[i] = array[i - 1];
        }
        array[0] = temp;
    }
}
else
{
    for (int j = 0; j < -K; j++)
    {
        int temp = array[0];
        for (int i = 0; i < array.Length - 1; i++)
        {
            array[i] = array[i + 1];
        }
        array[array.Length - 1] = temp;
    }
}
Console.WriteLine("Последовательность со сдвигом: ");
Console.WriteLine($"[{string.Join(", ", array)}]");