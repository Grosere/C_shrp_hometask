/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

using System;

namespace SumOfDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            do
            {
                Console.Write("Введите число: ");
                if (!int.TryParse(Console.ReadLine(), out number) || number < 0)
                {
                    Console.WriteLine("Ошибка ввода! Повторите попытку.");
                }
            } 
            while (number < 0);

            int sum = GetSumOfDigits(number);
            Console.WriteLine($"Сумма цифр числа {number} равна {sum}");
        }

        static int GetSumOfDigits(int number)
        {
            if (number == 0) return 0;

            int lastDigit = number % 10;
            int otherDigitsSum = GetSumOfDigits(number / 10);

            return lastDigit + otherDigitsSum;
        }
    }
}
