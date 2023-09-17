/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

using System;

public class Program
{
    public static void Main()
    {
        int[] arr = new int[8];
        Random rnd = new Random();

        for(int i=0; i<arr.Length; i++)
        {
            arr[i] = rnd.Next();
            Console.Write(arr[i]);
            if(i != arr.Length - 1) Console.Write(", ");
        }
        Console.WriteLine("");
    }
}
