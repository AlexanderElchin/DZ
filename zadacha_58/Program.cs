// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 6 16
// 9 6

// строку 1й матрицы мы умножаем на столбец 2й матрицы и сладываем.(первая вектор строка первой матрицы 
//умножиная на первый вектор столбца второй матрицы) тоесть 1я строка (2*3 + 4*3)(2*4 + 4*3) и вторая строка (3*3+2*3)(3*4+2*3)
//тоесть мы первую строку первой матрицы перемножаем и складываем со всеми столбцами второй матрицы, второй и сл. так же.
//А+В=В+А при сложении
//А*В!=В*А, тоесть произведение матриц А*В не будет ровно В*А например:
//возьмем матрицу А 1 2 В 5 6 то мы получим А*В 19 22 и В*А 23 34 а это значит, что порядок(последовательность) при умножении очень важен! 
//                  3 4   7 8                   43 50       31 46

void CreateRandomArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 10);
        }
    }
}

void ShowArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void MultiplyMatrix(int[,] firstMatr, int[,] secondMatr, int[,] resultMatr)
{
    for (int i = 0; i < resultMatr.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatr.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < firstMatr.GetLength(1); k++)
            {
                sum += firstMatr[i, k] * secondMatr[k, j];
            }
            resultMatr[i, j] = sum;
        }
    }
}

Console.Clear();
Console.Write("Введите количество строк 1 массива: ");
int rowsFirstMatrix = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов 1 массива: ");
int columnsFirstMatrix = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество строк 2 массива: ");
int rowsSecondMatrix = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов 2 массива: ");
int columnsSecondMatrix = Convert.ToInt32(Console.ReadLine());

if (columnsFirstMatrix != rowsSecondMatrix)
{
    Console.WriteLine("Такие матирицы перемножать нельзя!");
    return;
}

int[,] firstMatrix = new int[rowsFirstMatrix, columnsFirstMatrix];
CreateRandomArray(firstMatrix);
Console.WriteLine($"Первая матрица:");
ShowArray(firstMatrix);

int[,] secondMatrix = new int[rowsSecondMatrix, columnsSecondMatrix];
CreateRandomArray(secondMatrix);
Console.WriteLine($"Вторая матрица:");
ShowArray(secondMatrix);

int[,] resultMatrix = new int[rowsFirstMatrix, columnsSecondMatrix];

MultiplyMatrix(firstMatrix, secondMatrix, resultMatrix);
Console.WriteLine($"Произведение первой и второй матриц:");
ShowArray(resultMatrix);