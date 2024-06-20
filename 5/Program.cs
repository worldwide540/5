using System;

class Program
{
    static void Main()
    {
        int number = 5;
        long factorial = CalculateFactorial(number);
        Console.WriteLine($"Факториал числа {number} равен {factorial}");
    }

    static long CalculateFactorial(int n)
    {
        if (n == 0)
        {
            return 1;
        }
        long result = 1;
        for (int i = 1; i <= n; i++)
        {
            result *= i;
        }
        return result;
    }
}
