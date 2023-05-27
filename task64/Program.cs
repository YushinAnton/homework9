//Задача 64: Задайте значение N. 
//Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
//Выполнить с помощью рекурсии.

﻿void PrintNumber(int firstNumber, int secondNumber)
{   
    Console.WriteLine($"{firstNumber} ");
    if (firstNumber <= secondNumber)
    {
        PrintNumber(firstNumber + 1, secondNumber);
        
    }
}

Console.Write("Введите число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
int firstNumber = 1;
PrintNumber(firstNumber, secondNumber);