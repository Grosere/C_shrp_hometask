/* 
Задача 36: Задайте одномерный массив, заполненный случайными числами. Выведите массив  в консоль. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
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
        
        // Подсчет суммы нечетных элементов
        int sum = 0;
        for (int i = 1; i < arr.Length; i += 2) 
        {
            sum += arr[i];
        }

        Console.WriteLine($"Сумма нечетных элементов: {sum}");

    }
}
