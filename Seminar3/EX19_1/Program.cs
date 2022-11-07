//Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

System.Console.WriteLine("Введите пятизначное число");
int num = int.Parse(Console.ReadLine());

if ((num<10000) ||(num>99999)){
 Console.WriteLine($"ПЯТИЗНАЧНОЕ");}
else if (num%10==((num/10000)) && ((num/10)%10)==((num/1000)%10)){
  Console.WriteLine($"палиндром");}
else {
Console.WriteLine($"не палиндром");}
