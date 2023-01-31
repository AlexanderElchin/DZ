Console.Clear();
Console.WriteLine("Введите число:  ");
int number = Convert.ToInt32(Console.ReadLine());
int a = number;
while (number > 1000)
    number = number / 10;
if (number < 100)
    Console.WriteLine("В введеном числе нет третьей цифры");
else
{
    int a1 = number % 10;
    Console.WriteLine($"Третья цифра чилса {a} - {a1}");
}




