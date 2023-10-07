/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

using System;

public class MatrixMulti
{
public static void Main()
{
const int matrixSize = 3;
Random rand = new Random();

    // Создаем две матрицы
    int[][] matrix1 = new int[matrixSize][];
    int[][] matrix2 = new int[matrixSize][];

    for (int i = 0; i < matrixSize; i++)
    {
        int[] row = new int[matrixSize];
        matrix1[i] = row;
        matrix2[i] = row;
    }

    // Заполняем матрицы случайными числами от 0 до 19
    Console.WriteLine("Матрица 1:");
    FillMatrix(matrix1, rand);
    PrintMatrix(matrix1);
    Console.WriteLine("");
    Console.WriteLine("Матрица 2:");
    FillMatrix(matrix2, rand);
    PrintMatrix(matrix2);

    // Находим произведение матриц
    int[][] productMatrix = MatrixMulti.MatrixMultiplication(matrix1, matrix2);
    PrintMatrix(productMatrix);

}

// Функция для заполнения матрицы случайными числами
private static void FillMatrix(int[][] matrix, Random rand)
{
    for (int i = 0; i < matrix.Length; i++)
    {
        for (int j = 0; j < matrix[i].Length; j++)
        {
            matrix[i][j] = rand.Next(20);
        }
    }
}

// Метод для печати матрицы
private static void PrintMatrix(int[][] matrix)
{
    Console.WriteLine("[");
    foreach(var row in matrix)
    {
      Console.WriteLine(String.Join(" ",row));
     }
    Console.WriteLine("]");
}

// Метод нахождения произведения матриц
public static int[][] MatrixMultiplication(int[][] a, int[][] b)
{
    if (a.Length != b[0].Length)
    {
        throw new Exception("Некорректные размеры матриц!");
    }
    int n = a.Length;
int[][] c = new int[n][];

for (int i = 0; i < n; ++i)
{
c[i] = new int[b.Length];
}

    for (int i = 0; i < a.Length; ++i)
    {
        for (int j = 0; j < b.Length; ++j)
        {
            for (int k = 0; k < n; ++k)
            {
                c[i][j] += a[i][k] * b[k][j];
            }
        }
    }

    return c;
}
}

