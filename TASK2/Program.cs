﻿// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// i = 1, j = 2 -> 2
// i = 4, j = 2 -> такого элемента не существует


// Вариант 1

Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, columns, -50, 50);
PrintArray(array);

Console.WriteLine();


int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return result;
}

Console.WriteLine("Введите i");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите j");
int b = Convert.ToInt32(Console.ReadLine());
if (a < rows && b < columns)

    Console.WriteLine($"i = {a} j = {b} -> { array.GetValue(a, b)}");
else
{
     Console.WriteLine($"i = {a} j = {b} -> такого элемента не существует");
}


void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}




//  Вариант 2



// int[,] array = GetArray(10, 10, -50, 50);
// PrintArray(array);

// Console.WriteLine();


// int[,] GetArray(int m, int n, int minValue, int maxValue)
// {
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = new Random().Next(minValue, maxValue);
//         }
//     }
//     return result;
// }

// Console.WriteLine("Введите i");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите j");
// int b = Convert.ToInt32(Console.ReadLine());
// if (a < array.GetLength(0) && b < array.GetLength(1))

//     Console.WriteLine($"i = {a} j = {b} -> { array.GetValue(a, b)}");
// else
// {
//      Console.WriteLine($"i = {a} j = {b} -> такого элемента не существует");
// }


// void PrintArray(int[,] inArray)
// {
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             Console.Write($"{inArray[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }
