﻿// Задача 60. ...Сформируйте трёхмерный массив 
// из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить 
// массив, добавляя индексы каждого элемента.

// Массив размером 2 x 2 x 2

// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.Clear();

int[,,] triplearray = {{{001, 002},{011, 012},{021, 022}},
{{101, 102},{111, 112},{121, 122}},
{{201, 202},{211, 212},{221, 222}}};

void pr(int[,,] array){
    int a = array.GetLength(0);
    int b = array.GetLength(1);
    int c = array.GetLength(2);

    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            for (int k = 0; k < c; k++)
            {
                Console.Write($"{array[i,j,k]}({i} {j} {k})");
            }
            Console.WriteLine();
        }
         Console.WriteLine();
    }
}
pr(triplearray);
