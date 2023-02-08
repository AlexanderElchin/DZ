// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
Console.Clear();
Console.Write("введите число:");
int n = Convert.ToInt32(Console.ReadLine());
int summ = 0;
int a = 0;
while (n > 0)
{
    a = n % 10;
    summ = summ + a;
    n = n / 10;
}
Console.Write($"сумма цифр числа: {summ}");