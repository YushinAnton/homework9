//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
//Даны два неотрицательных числа m и n.

﻿int Akermann(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if ((m > 0) && (n == 0))
    {
        return Akermann(m - 1, 1);
    }
    else if ((m > 0) && (n > 0))
    {
        return Akermann(m - 1, Akermann(m, n - 1));
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

int result = Akermann(m, n);
Console.WriteLine($"Akermann({m}, {n}) = {result}");
