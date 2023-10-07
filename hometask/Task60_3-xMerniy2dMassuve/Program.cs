/* 
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
*/

using System;

class MainClass 
{
public static void Main (string[] args)
{
int[, ,] threeDArray = new int[2, 2, 2];
Random random = new Random();

for (int i = 0; i < 2; i++)  
{  
  for (int j = 0; j < 2; j++)                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         
  {  
    for (int k = 0; k < 2; k++)  
    {  
      threeDArray[i, j, k] = random.Next(1, 10);  
    }  
  }  
}  

foreach (var row in threeDArray)  
{  
  foreach (var element in row)  
  {  
    Console.Write($"({i}, {j}, {k}), ");  
  }  
  Console.WriteLine();  
}  
}
}