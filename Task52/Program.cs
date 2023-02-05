// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
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

double[] averegeColumnsArray(int[,] array)
{
    double[] average = new double[array.GetLength(1)];
   for (int i = 0; i < array.GetLength(1); i++)
   {
    double aver = Average(array, i);
    average[i] = aver;
   }
    return average;
}

double Average(int[,] arr1,int j)
{
  double sum = 0;
  for (int i = 0; i < arr1.GetLength(0); i++)
  {
    sum = sum + arr1[i,j];
  }
  double average = sum/arr1.GetLength(0);
  return average;
}


Console.Clear();
int[,] matrix = GetArray(5,4,-10,10);
PrintArray(matrix);
double[] averMatrix = averegeColumnsArray(matrix);
System.Console.WriteLine("Среднее арифметическое каждого столбца:");
System.Console.WriteLine(String.Join("  |  ", averMatrix));
