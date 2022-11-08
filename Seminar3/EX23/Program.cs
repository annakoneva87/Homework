//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

System.Console.WriteLine("Введите число");
int n = int.Parse(Console.ReadLine());
{
    for (int i = 1; i <= n; i++)
    {
    int result = i * i * i;
   Console.WriteLine($"{result}");}
}