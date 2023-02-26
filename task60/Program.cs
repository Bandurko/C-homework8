// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.

// КОМЕНТАРИИ ЧИСТО ДЛЯ СЕБЯ!!!

// Трехмерный массив можно представить как
// Количество таблиц
// [0, 0, 0] [0, 0, 1] [0, 0, 2] [0, 0, 3]
// [0, 1, 0] [0, 1, 1] [0, 1, 2] [0, 1, 3]

// [1, 0, 0] [1, 0, 1] [1, 0, 2] [1, 0, 3]
// [1, 1, 0] [1, 1, 1] [1, 1, 2] [1, 1, 3]

// Чтобы обратиться к элементу указываем его индекс [I, j, k]
// таблица - i
// строка - j
// столбец - k



using System;
using static System.Console;

Clear();

// зададим трехмерный массив по аналогии с двумерным 

Write("Введите количество двумерных массивов: ");
int tables = int.Parse(ReadLine());

Write("Введите количество строк двумерного массива: ");
int rows = int.Parse(ReadLine());

Write("Введите количество столбцов двумерного массива: ");
int columns = int.Parse(ReadLine());
WriteLine();

// от 0 до 10 будет мало. возьмем до 100
int[,,] array = GetArray(tables, rows, columns, 0, 99);
PrintArray(array);

// Зададим функцию генерирующую элементы трехмерного массива (нужно 3 вложенных цикла)
// Нужно чтобы элементы не повторялись...

int[,,] GetArray(int x, int y, int z, int min, int max)
{
    int[,,] result = new int[x, y, z];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            // for (int k = 0; k < result.GetLength(2); k++)
            // {
            // result[i, j, k] = new Random().Next(min, max + 1);
            // }
            int k = 0;
            while (k < result.GetLength(2))
            {
                int element = new Random().Next(min, max + 1);
                if (FindElement(result, element)) continue;
                result[i, j, k] = element;
                k++;
            }
        }
    }
    return result;
}


bool FindElement(int[,,] array, int el)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if (array[i, j, k] == el) return true;
            }
        }
    }
    return false;
}


// функция вывода на экран почти такая-же как и для двумерного (только 3 цикла)
void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Write($"{array[i, j, k]} ({i},{j},{k})   ");
            }
            WriteLine();
        }
        // WriteLine();
    }

}

