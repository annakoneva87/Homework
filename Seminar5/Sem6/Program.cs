//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.WriteLine("Введите элементы через пробел");
string str = Console.ReadLine();
var arrStr = str.Split(" ");
int[] arr = Array.ConvertAll(arrStr, int.Parse);
int count = 0;
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i]>0)
    {
        count++;
    }
}
Console.WriteLine($"Количество элементов больше 0  = {count}");


//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

Console.WriteLine("Enter a value B1");
double b1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter a value K1");
double k1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter a value B2");
double b2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter a value K2");
double k2 = Convert.ToInt32(Console.ReadLine());

double x = (b1-b2)/(k2-k1);
double y = k2*x+b2;
Console.WriteLine($"Точка пересечения между прямыми Х: {x};Y:{y}");
Console.ReadLine();
