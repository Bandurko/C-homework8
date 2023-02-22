// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

using System;
using static System.Console;

Clear();

Write("Введите количество строк матрицы A: ");
int rowsA = int.Parse(ReadLine());
Write("Введите количество столбцов матрицы A: ");
int columnsA = int.Parse(ReadLine());
WriteLine();

Write("Введите количество строк матрицы B: ");
int rowsB = int.Parse(ReadLine());
Write("Введите количество столбцов матрицы B: ");
int columnsB = int.Parse(ReadLine());
WriteLine();

if (columnsA != rowsB)
{
    Console.WriteLine("Матрицы перемножить невозможно");
}

int[,] arrayA = GetArrayA(rowsA, columnsA, 0, 10);
int[,] arrayB = GetArrayB(rowsB, columnsB, 0, 10);

Console.WriteLine("Матрица A:");
PrintArrayA(arrayA);
WriteLine();

Console.WriteLine("Матрица B:");
PrintArrayB(arrayB);
WriteLine();

int[,] arrayC = MatrixMultC(arrayA, arrayB);

Console.WriteLine("Произведение матриц A и B (C = A * B):");
PrintArrayB(arrayC);

int[,] MatrixMultC(int[,] a, int[,] b)
{

    int[,] result = new int[a.GetLength(0), b.GetLength(1)];

    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < b.GetLength(1); j++)
        {
            for (int k = 0; k < b.GetLength(0); k++)
            {
                result[i,j] += a[i,k] * b[k,j];
            }
        }
    }
    return result;
}

void PrintArrayC(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Write($"{array[i, j]} ");
        }
        WriteLine();
    }
}



int[,] GetArrayA(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max + 1);
        }

    }
    return result;
}

void PrintArrayA(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Write($"{array[i, j]} ");
        }
        WriteLine();
    }
}


int[,] GetArrayB(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max + 1);
        }

    }
    return result;
}

void PrintArrayB(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Write($"{array[i, j]} ");
        }
        WriteLine();
    }
}