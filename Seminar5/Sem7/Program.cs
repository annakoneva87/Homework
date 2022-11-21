//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
Console.Clear();

Console.Wtite("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());

Console.Wtite("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());

double[,] arrayDouble = GetArrayDouble(rows, columns, 0, 10);
PrintArrayDouble(arrayDouble);

double[,] GetArrayDouble(int m, int n, int min, int max)
{
    double[,] result = new double [m, n];
    for (int i=0; i<m; i++)
    {
        for (int j = 0; j<n; j++)
        {
            result [i,j] = new Random().NextDouble()*(max-min);
        }
    }
    return result;
}

void PrintArrayDouble(double[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i,j]:f1} ");
        }
    Console.WriteLine();
    }
}
Console.ReadLine();
//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.Clear();
var random = new Random();
int[,] array = GetArray(random.Next(3,10), random.Next(3,10),0,10);
PrintArray(array);
Console.Wtite("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());

Console.Wtite("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());

if ((rows>=0 && rows < array.GetLength(0)) && (columns< array.GetLength(1)))
{
    Console.WriteLine($"Элемент найден {array[rows,columns]}");
}
else
{
    Console.WriteLine($"Элемент  не найден");
}

int[,] GetArray(int m,int n, int min, int max)
{
    int[,] result = new int[m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i,j]=new Random().Next(min, max+1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i=0; i<inArray.GetLength(0);i++)
    {
        for (int j=0; j<inArray.GetLength(0);j++)
        {
            Console.Write($"{inArray[i, j]} ");
        } 
        Console.WriteLine();
        }
}
bool FindElement(int[,] array, int el)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i,j] == el) return true;
        }
    }
    return false;
}

//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Console.ReadLine();
Console.Clear();


Console.Wtite("Введите количество строк массива: ");
rows = int.Parse(Console.ReadLine());

Console.Wtite("Введите количество столбцов массива: ");
columns = int.Parse(Console.ReadLine());
array= GetArray(rows,columns,0,10);
PrintArray(array);
double[] averageColumns = GetResultArray(array);
Console.WriteLine($"Среднее арифметическое каждого столбца = {String.Join(";", averageColumns)}");
char input1 = Console.ReadKey().KeyChar;

double[] GetResultArray(int[,] array)
{
    double[] result = new double[array.GetLength(1)];
    for (int i=0; i<array.GetLength(1);i++)
    {
        double sum = 0;
        for (int j=0; j<array.GetLength(0);j++)
        {
            sum+=array[j,i];
        }
        result[i]=Math.Round(sum/array.GetLength(0),2);
    }
    return result;
}
