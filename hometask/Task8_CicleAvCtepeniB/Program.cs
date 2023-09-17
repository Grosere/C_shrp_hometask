/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

using System;

namespace PowerCalculator
{
class Program
{
static void Main(string[] args)
{
Console.Write("Введите число A: ");
int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите степень B: ");
        int b = Convert.ToInt32(Console.ReadLine());

        CalculatePower(a, b);

        Console.ReadKey();
    }

    static void CalculatePower(int a, int b)
    {
        if (b == 0)
        {
            Console.WriteLine("Результат: 1");
            return;
        }

        int result = a;
        for (int i = 1; i < b; i++)
        {
            result *= a;
        }

        Console.WriteLine($"Результат: {result}");
    }
}
}