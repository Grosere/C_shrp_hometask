﻿/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

using System;

namespace ConsoleApp1 
{ 
class Program 
{ 
static void Main(string[] args) 
{ 

int n = 5; // Размер массива 
int m = 10; // Количество элементов в строке 
int[,] arr = new int[n, m]; // Создаем двумерный массив
Random r = new Random(); // Инициализация генератора случайных чисел

    for (int i = 0; i < n; i++) // Заполнение массива случайными числами 
    {
        for (int j = 0; j < m; j++)
        {
            arr[i, j] = r.Next(0, 10); // Генерируем случайное число от 0 до 9
        }
    }

    int sum = 0; // Сумма элементов в каждой строке
    for (int i = 0; i < n; i++)
    {
        sum = 0;
        for (int j = 0; j < m; j++) // Находим сумму элементов в строке
        {
            sum += arr[i, j];
        }

        Console.WriteLine($"Сумма элементов в {i+1}-й строке равна {sum}"); // Выводим сумму элементов строки
}

    int minSum = int.MaxValue; // Минимальная сумма элементов в строке
    int indexMinSum = 0; // Индекс строки с минимальной суммой

    for (int i = 0; i < n; i++) // Ищем строку с минимальной суммой элементов
    {
        if (sum < minSum)
        {
            minSum = sum;
            indexMinSum = i;
        }
    }
    Console.WriteLine($"Строка с минимальной суммой ({minSum}) имеет индекс {indexMinSum+1}"); // Выводим строку с минимальной суммой и ее индекс

}
}
}