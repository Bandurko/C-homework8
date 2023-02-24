// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

using System;
using static System.Console;

Clear();

int n = 4;

    int[,] spiralMatrix = new int[n, n];

    int el = 1;
    int i = 0;
    int j = 0;

    while (el <= spiralMatrix.GetLength(0) * spiralMatrix.GetLength(1))
    {
      spiralMatrix[i, j] = el;
      el++;
      if (i <= j + 1 && i + j < spiralMatrix.GetLength(1) - 1)
        j++;
      else if (i < j && i + j >= spiralMatrix.GetLength(0) - 1)
        i++;
      else if (i >= j && i + j > spiralMatrix.GetLength(1) - 1)
        j--;
      else
        i--;
    }


PrintArray(spiralMatrix);

void PrintArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i, j] / 10 == 0)
      Console.Write($"0{array[i, j]} ");

      else
      Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
  }
}

