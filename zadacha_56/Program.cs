// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер 
// строки с наименьшей суммой элементов: 1 строка
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

// void NumberSumm(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         int sum = 0;
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             sum = sum + matrix[i, j];
//         }
//         Console.WriteLine($" {i + 1}-ая строка: {sum} ");

//     }
// }
// Console.WriteLine("Сумма строк по порядку ");
// NumberSumm(matrix);

void NumberRowMinSum(int[,] matrix)
{
    int minRow = 0;
    int minSumRow = 0;
    int sumRow = 0;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        minRow = minRow + matrix[0, i];
    }
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        sumRow = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sumRow = sumRow + matrix[i, j];
        }
        Console.WriteLine($" {i + 1}-ая строка: {sumRow} ");
        if (sumRow < minRow)
        {
            minRow = sumRow;
            minSumRow = i;
        }

    }
    Console.Write($"Ответ: {minSumRow + 1} строка");

}
Console.WriteLine("Строка с наименьшей суммой элементов: ");
NumberRowMinSum(matrix);

