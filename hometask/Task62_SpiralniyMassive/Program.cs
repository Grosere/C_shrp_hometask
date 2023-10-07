/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

using System;

class SpiralArray
{
static void Main()
{
int[,] array = new int[4, 4];

    int startX = 0;
    int startY = 0;
    int endX = array.GetLength(0) - 1;
    int endY = array.GetLength(1) - 1;

    for (int i = 0; i < 16; i++)
    {
        array[startX, startY] = i;

        if (startX < endX && startY < endY)
        {
            if (startX > 0) startX--;
            else if (startY > 0)
            {
                startY--;
                endX--;
            }
            else endY--;
        }
        else if (endY > startY)
        {
            endX--;
        }

        else
        {
            startX++;

            if (endX > 1) endX--;

            endY--;
         }
         }

    static int[] intToArray(int num)
    {
    String holder = num.ToString();
    int[] numbers = new int[Holder.ToString().Length]; 

    for(int i=0;i<numbers.length;i++)
    {
        numbers[i] = Convert.toInt32(holder.CharAt(i));
    }
    return numbers;
    }

    static void PrintArray(int[,] array)
    {
        foreach (int[] row in array)
        {
            foreach (int num in row)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }

    PrintArray(array);
}
}
