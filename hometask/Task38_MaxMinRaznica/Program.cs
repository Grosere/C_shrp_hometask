/* 
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
*/ 

double[] arr = { 3.22, 4.2, 1.15, 77.15, 65.2 };
    double max = double.MinValue;
    double min = double.MaxValue;

    foreach (var item in arr)
     {
        max = Math.Max(max, item);
        min = Math.Min(min, item);
    }

    double result = Math.Abs(max - min);
    Console.WriteLine(result);
//мне было лень писать рандом для массива...