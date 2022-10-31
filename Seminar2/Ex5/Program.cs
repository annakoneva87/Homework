// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. 
 
 System.Console.WriteLine("Введите трехзначное число");
int num = int.Parse(Console.ReadLine());
int result=num%10;

if ((num<100)||(num>999))
{
    Console.WriteLine($"ТРЕХЗНАЧНОЕ");
}
else
{
   Console.WriteLine($"{result}");   
}