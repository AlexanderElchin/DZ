// Задайте массив целых чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3, 7, 22, 2, 78] -> 76
Console.WriteLine("Введите длину массива  ");
int size = Convert.ToInt32(Console.ReadLine());
int[] number = new int[size];
FillArrayRandomNumbers(number);
Console.WriteLine("Массив: ");
PrintArray(number);
void FillArrayRandomNumbers(int[] number)
{
    for (int i = 0; i < number.Length; i++)
    {
        number[i] = Convert.ToInt32(new Random().Next(1, 10));
    }
}
void PrintArray(int[] number)
{
    Console.Write("[ ");
    for (int i = 0; i < number.Length; i++)
    {
        Console.Write(number[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}
int min = Int32.MaxValue;
int max = Int32.MinValue;
for (int j = 0; j < number.Length; j++)
{
    if (number[j] > max)
    {
        max = number[j];
    }
    if (number[j] < min)
    {
        min = number[j];
    }
}
Console.WriteLine($"Всего в массиве {number.Length} чисел. Максимальное = {max}, Минимальное = {min}");
Console.WriteLine($"Разность между максимальным и минимальным = {max - min}");