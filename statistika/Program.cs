// Вася не любит английский язык, но каждый раз старается получить хотя бы четверку за четверть, чтобы оставаться ударником. 
// В текущей четверти Вася заметил следующую закономерность: по нечетным дням месяца он получал тройки, а по четным – четверки. 
// Так же он помнит, в какие дни он получал эти оценки. Поэтому он выписал на бумажке все эти дни для того, чтобы оценить,
// сколько у него троек и сколько четверок. Помогите Васе это сделать, расположив четные и нечетные числа в разных строчках. 
// Вася может рассчитывать на оценку 4, если четверок не меньше, чем троек.

// Входные данные
// В первой строке входного файла INPUT.TXT записано единственное число N – количество элементов целочисленного массива (1 ≤ N ≤ 100). 
// Вторая строка содержит N чисел, представляющих заданный массив. Каждый элемент массива – натуральное число от 1 до 31. 
// Все элементы массива разделены пробелом.

// Выходные данные
// В первую строку выходного файла OUTPUT.TXT нужно вывести числа, которые соответствуют дням месяцев, в которые Вася получил тройки,
// а во второй строке соответственно расположить числа месяца, в которые Вася получил четверки. В третьей строке нужно вывести «YES»,
// если Вася может рассчитывать на четверку и «NO» в противном случае. В каждой строчке числа следует выводить в том же порядке,
// в котором они идут во входных данных. При выводе числа отделяются пробелом.
// Примеры
// №	INPUT.TXT	OUTPUT.TXT
// 1	5
// 4 16 19 31 2	19 31
// 4 16 2
// YES
// 2	8
// 29 4 7 12 15 17 24 1	29 7 15 17 1
// 4 12 24
// NO

Console.Clear();
Console.WriteLine("Введите длину массива(зачётов)  ");
int size = Convert.ToInt32(Console.ReadLine());
while (size < 1 || size > 100)
{
    Console.Write("Вы ошиблись!\nВведите число: ");
    size = Convert.ToInt32(Console.ReadLine());
}
int[] number = new int[size];
FillArrayRandomNumbers(number);
Console.WriteLine("Даты зачетов: ");
PrintArray(number);
void FillArrayRandomNumbers(int[] number)
{
    for (int i = 0; i < number.Length; i++)
    {
        number[i] = Convert.ToInt32(new Random().Next(1, 32));
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
int f = 0; // 4
int t = 0; // 3
for (int i = 0; i < number.Length; i++)
{
    if (number[i] % 2 == 0)
    {
        f++;
    }
    else
    {
        t++;
    }
}
int[] fourArray = new int[f];
int[] threeArray = new int[t];

int fourIndex = 0;
int threeIndex = 0;

for (int i = 0; i < number.Length; i++)
{
    if (number[i] % 2 == 0)
    {
        fourArray[fourIndex] = number[i];
        fourIndex++;
    }
    else
    {
        threeArray[threeIndex] = number[i];
        threeIndex++;
    }
}
// Console.WriteLine($"Даты зачетов: [{string.Join(", ", number)}]");
Console.WriteLine($"Даты, когда получали оценку 4 :  [{string.Join(", ", fourArray)}]");
Console.WriteLine($"Даты, когда получали оценку 3 :  [{string.Join(", ", threeArray)}]");
if (f >= t)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}
