// Задача 52.Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив: 3 4
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
Console.Clear();
Console.Write("Введите размер массива: ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(1, 10); // [1, 9]
    }
}
InputMatrix(matrix);

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} \t");
        Console.WriteLine();
    }
}
PrintMatrix(matrix);

void Sra(int[,] matrix)
{
    Console.Write("среднее арифметическое каждого столбца"); // меняем местами и получаем ср.ар. по столбцам
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        double result = 0;
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            result = result + matrix[j, i];
        }
        double otvet = result / matrix.GetLength(0);
        Console.Write($" {otvet}; ");
    }
}
Sra(matrix);