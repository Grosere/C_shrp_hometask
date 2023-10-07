/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/
using System;

class Program
{
static void Main()
{
// Ввод размера массива и создание двумерного массива
Console.WriteLine("Введите размер массива: ");
string[] size = Console.ReadLine().Split();
int rows = int.Parse(size[0]);
int columns = int.Parse(size[1]);
double[,] array = new double[rows, columns];

    // Заполняем массив случайными числами и выводим на экран
    Random rnd = new Random();
    Console.WriteLine($"Исходный массив:");
    for (int i=0; i<rows; i++)
    {
        for(int j=0; j<columns; j++)
        {
            array[i,j] = rnd.NextDouble() * 100;
            Console.Write($"{array[i,j]:F2} ");
        }
        Console.WriteLine();
    }
    // Сортируем строки массива по убыванию и выводим результат
for(int i=0; i<rows; i++)
{
double[] row = new double[columns];
for(int j=0; j<columns; j++) row[j] = array[i,j];
Array.Sort(row);
for(int j=columns-1; j>=0; j--) array[i,j] = row[j];
}
Console.WriteLine($"Отсортированный по убыванию массив: ");
for(int i=0; i<rows; i++)
{
for(int j=0; j<columns; j++) Console.Write($"{array[i,j]:F2} ");
Console.WriteLine();
}
}
}