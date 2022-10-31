//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

System.Console.WriteLine("Введите три числа");
int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
int num3 = int.Parse(Console.ReadLine());

if ((num1>num2) && (num1>num3))
{
    Console.WriteLine($"Максимальное = {num1}");
}
else if((num2>num3) && (num2>num1))
{
   Console.WriteLine($"Максимальное = {num2}");
}
 else 
{
   Console.WriteLine($"Максимальное = {num3}");
}
