int Ackermann(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if ((m > 0) && (n == 0))
    {
        return Ackermann(m - 1, 1);
    }
    else if ((m > 0) && (n > 0))
    {
        return Ackermann(m - 1, Ackermann(m, n - 1));
    }
    else
    {
        return n + 1;
    }
}

Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());

int result = Ackermann(m, n);
Console.WriteLine($"А({m},{n}) = {result}");
