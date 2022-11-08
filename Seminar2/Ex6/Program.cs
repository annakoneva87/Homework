//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.  

System.Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());

if (num<100)
{
   Console.WriteLine($" нет");
   return;
}
else
while (num>1000)
{
    num/=10;}
int result = num % 10;
   Console.WriteLine($" {result}");
