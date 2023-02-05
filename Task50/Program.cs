// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue+1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}\t ");
        }
        Console.WriteLine();
    }
}

void SearchElementArr(int[,] array)
{
    Console.WriteLine("Введите индекс элемента: ");
    int i = int.Parse(Console.ReadLine()!);
    int j = int.Parse(Console.ReadLine()!);

    if (i < array.GetLength(0) && j < array.GetLength(1))
    {

         
         Console.WriteLine($"По заданному индексу найден элемент - {array[i,j]}");
       
    }
       
    else
    {
         Console.WriteLine("Элемента с такими индексами не существует в массиве");
    }
     
}

Console.Clear();
int[,] testArray = GetArray(5,5,-5,5);
PrintArray(testArray);
SearchElementArr(testArray);
