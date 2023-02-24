// Задача 61: Вывести первые N строк треугольника Паскаля. 
// Сделать вывод в виде равнобедренного треугольника


using System;
using static System.Console;

Clear();

Write("Введите количество строк треугольника Паскаля: ");
int N = int.Parse(ReadLine());

PrintTriangle(N);

double fact(int n)
{
    double num = 1;
    for (int i = 1; i <= n; i++)
    {
        num *= i;
    }
    return num;
}

void PrintTriangle(int rows)
{
    for (int i = 0; i < rows; i++)
    {
        for (int indent = 0; indent <= (rows - i); indent++)
        {
            Write("  ");
        }
        for (int indent = 0; indent <= i; indent++)
        {
            Write("   ");
            Write(fact(i) / (fact(indent) * fact(i - indent)));
        }
        WriteLine();
    }
}


