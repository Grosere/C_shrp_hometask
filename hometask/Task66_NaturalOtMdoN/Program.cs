/* 
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/ 

using System;

class SumOfNaturals
{
    public static void Main()
    {
        Console.WriteLine("Введите M и N:");
        string input = Console.ReadLine();
        string[] nums = input.Split(' ');
        int m = int.Parse(nums[0]);
        int n = int.Parse(nums[1]);

        int sum = 0;
        for (int i = m; i >= n; i--)
        {
            if (i % 2 == 0)
            {
                sum += i;
            }
        }

        Console.WriteLine($"Сумма натуральных чисел от {m} до {n}: {sum}");
    }
}