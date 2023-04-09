void GapNumberSum (int numberM, int numberN, int sum)
{
    if (numberM > numberN) 
    {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}"); 
        return;
    }
    sum = sum + (numberM++);
    GapNumberSum(numberM, numberN, sum);
}

Console.Clear();
Console.WriteLine("Введите начальное число M:");
int numberM = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите начальное число N:");
int numberN = int.Parse(Console.ReadLine()!);
int sum = 0;
GapNumberSum(numberM, numberN, sum);