//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

//[345, 897, 568, 234] -> 2

//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

//[3, 7, 23, 12] -> 19

//[-4, -6, 89, 6] -> 0

//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

//[3 7 22 2 78] -> 76

Start();
void Start()
{
    while (true){
        Console.ReadLine();
        Console.Clear();

        System.Console.WriteLine("34) Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.");
        System.Console.WriteLine("36) Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.");
        System.Console.WriteLine("38) Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.");
        System.Console.WriteLine("0) End");

        int numTask = SetNumber("task");

        switch (numTask)
        {
            case 0: return; break;
            case 34:
                Console.Clear();
                int[] startArray = GetArray(12, 100, 999);
                Console.WriteLine(String.Join(" ", startArray));
                Console.WriteLine($"Количество четных элементов в массиве = {GetEvenCount(startArray)}");
                break;
            case 36:
                 Console.Clear();
                 startArray = GetArray(6, 0, 999);
                 Console.WriteLine(String.Join(" ", startArray)); 
                 Console.WriteLine($"Сумма элементов на нечетных позициях = {GetSumOdd(startArray)}");
                 break;
            case 38:
                 Console.Clear();
                 double[] startArrayDouble = GetArrayDouble(6, 0, 999);
                 Console.WriteLine(String.Join(" ", startArrayDouble)); 
                 Console.WriteLine($"Разница = {GetDifference(startArrayDouble)}");
                 break;
        }
    }
    
}

int SetNumber(string numberName)
{
    Console.WriteLine($"Enter number {numberName}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i=0; i< size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue +1);
    }
    return res;
}

double[] GetArrayDouble(int size, int minValue, int maxValue)
{
    double[] res = new double[size];
    var random = new Random();
    for (int i=0; i< size; i++)
    {
        res[i] = random.Next(minValue, maxValue +1) + random.NextDouble();
    }
    return res;
}

int GetEvenCount(int[] array)
{
    int count = 0;
    foreach (var item in array)
    {
        if (item % 2 ==0) count++;
    }
    return count;
}

int GetSumOdd(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 ==1) sum+=array[i];
    }
    return sum;
}

double GetDifference(double[] array)
{
    double min = array[0];
    double max = array[0];
    foreach (var item in array)
    {
        if (min > item) min = item;
        if (max < item) max = item;
    }
    return max-min;
}