//Задача 2 Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Введите два числа");
int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());

if (num1>num2)
{
    Console.WriteLine($"Максимальное = {num1},минимальное= {num2}");
}
else
{
   Console.WriteLine($"Максимальное = {num2},минимальное= {num1}");
}
