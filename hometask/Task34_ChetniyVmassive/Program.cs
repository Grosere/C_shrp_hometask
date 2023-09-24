/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

using System;

class Program
{
    static void Main()
    {
        // Инициализация массива
        int[] arr = new int[10];

        // Заполнение массива случайными трехзначными числами
        Random rnd = new Random();
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = rnd.Next(10, 999);
        }
    
        // Вывод массива чисел
        Console.WriteLine("Получили массив: ");
        foreach(var item in arr)
        {
        Console.Write(item + " ");
        }
        Console.WriteLine();
        
        // Подсчет количества четных чисел
        int evenCount = 0;
        foreach (int num in arr)
        {
            if (num % 2 == 0)
                evenCount++;
        }
        Console.WriteLine("Количество четных чисел: " + evenCount);
    }
}