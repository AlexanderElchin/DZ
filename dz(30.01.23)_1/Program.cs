/*Напишите программу, которая принимает на вход трёхзначное 
число и на выходе показывает вторую цифру этого числа.*/
Console.Clear();

Console.Write("Введите 3-х значное число: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a < 100 || a > 999)
{
    Console.WriteLine("Вы ввели не трехзначное число");
}
else
{
    int a1 = ((a / 10) % 10);
    Console.WriteLine(a1);
}