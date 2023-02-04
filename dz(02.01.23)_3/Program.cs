// Напишите программу, которая принимает на вход пятизначное 
// число и проверяет, является ли оно палиндромом.
Console.Clear();
Console.Write("Введите 5ти значное число: ");
int n = Convert.ToInt32(Console.ReadLine());
while (n < 9999 || n > 100000)
{
    Console.Write("Вы ошиблись! \nвведите 5ти значное число ");
    n = Convert.ToInt32(Console.ReadLine());
}
if (n / 10000 == n % 10 && (n / 1000) % 10 == (n / 10) % 10)
    Console.Write("Это палиндром!");
else
    Console.Write("Это не палиндром!");


