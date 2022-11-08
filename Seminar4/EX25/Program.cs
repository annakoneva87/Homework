//Напишите цикл, который принимает на вход два числа (А и В) и возводит число А в натуральную степень В.

System.Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите степень");
int degree = int.Parse(Console.ReadLine());
int sum=1;
for (int i = 0; i < degree; i++)
{
   sum = sum*num;
}
Console.WriteLine($"число {num} в степени {degree} равно {sum}");