// Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет,
// является ли этот день выходным.
Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
while (n < 1 || n > 7)
{
    Console.Write("Вы ошиблись!\nВведите число: ");
    n = Convert.ToInt32(Console.ReadLine());
}
if (n < 6)
    Console.WriteLine("Будни");
else
    Console.WriteLine("Выходные");
