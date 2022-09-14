// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
/*
double [,] CreatRandom2dArray()
{
    Console.Write("Input number of ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input  number of ");
    int colums = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input min possible value ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input max possible value ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"m = {rows}, n = {colums}.");
    double [,] newArray = new double[rows, colums];

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < colums; j++)
        {
        // newArray[i,j] = Math.Round(Convert.ToDouble(new Random().NextDouble(minValue, maxValue)), 2); - Павел! Почему то не работает, пришлось использовать способ ниже(
        newArray[i, j] = Convert.ToDouble(new Random().Next(minValue, maxValue)) / 10;
        }
    }

    return newArray;
}

void Show2dArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine();
    }

    Console.WriteLine();
}

double [,] newArray = CreatRandom2dArray();
Show2dArray(newArray);
*/
// ____________________________________________________________________________________________________________________

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
/*
int [,] CreatRandom2dArray()
{
    Console.Write("Input number of rows ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input  number of colomns ");
    int colums = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input min possible value ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input max possible value ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

        int[,] newArray = new int[rows, colums];

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < colums; j++)
        {
            newArray[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }

    return newArray;
}

void Show2dArray(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine();
    }

    Console.WriteLine();
}

void CheckPosition(int [,] array)
{
Console.Write("Input the number of row: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Inpu thr number of column: ");
int m = Convert.ToInt32(Console.ReadLine());

if (n > array.GetLength(0) || m > array.GetLength(1))
    Console.WriteLine("There is no such element");
else
    Console.WriteLine($"The element in row {n} and column {m} is {array[n-1,m-1]}");
}

int[,] newArray = CreatRandom2dArray();
Show2dArray(newArray);
CheckPosition(newArray);
*/

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
/*
int [,] CreatRandom2dArray()
{
    Console.Write("Input number of rows ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input  number of colomns ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input min possible value ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input max possible value ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

        int[,] newArray = new int[rows, columns];

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            newArray[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }

    return newArray;
}

void Show2dArray(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine();
    }

    Console.WriteLine();
}

void AveregSumOfColumns (int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        double averegSum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            averegSum += array[j, i];
        }
    averegSum = Math.Round(averegSum / array.GetLength(1), 1);
    Console.WriteLine($"Column {i+1} -> {averegSum}");
    }
}

int[,] newArray = CreatRandom2dArray();
Show2dArray(newArray);
AveregSumOfColumns(newArray);

*/