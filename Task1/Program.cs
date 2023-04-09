void NaturalToLow(int n, int count)
{
    if (n < 0) Console.Write($"{n} не натуральное число");
    if (count > n)
    {
    return;
    }
    else
    {
    NaturalToLow(n, count + 1);
    Console.Write(count + " ");
    }
}

Console.Clear();
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 1;
NaturalToLow(number, count);