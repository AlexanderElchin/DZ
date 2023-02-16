// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
// сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
Console.Clear();
Console.WriteLine($"Введите M чисел через пробел: ");
double[] array = Array.ConvertAll(Console.ReadLine()!.Split(" "), double.Parse); // ввод массива с клавиатуры без обозначения длинны
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
        count++;
    }
}
Console.WriteLine($"Количество элементов больше 0 : {count}");