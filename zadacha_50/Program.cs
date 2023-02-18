// Задача 50.Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этот элемент или же указание, что такого элемента нет.
// Например, задан массив: 3 4
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет
Console.Clear();
Console.Write("Введите размер массива: ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(1, 10); // [1, 20]
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

Console.Write("Введите номер строки: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число проверки: ");
int proverka = Convert.ToInt32(Console.ReadLine());
void Address(int[,] matrix, int proverka)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] == proverka)
            {
                Console.WriteLine($"Число расположено в {i + 1} строке, {j + 1} столбце\t ");
                return;
            }

        }
    }
    Console.WriteLine("Число отвутствует в массиве.");
}
Address(matrix, proverka);
