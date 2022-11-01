//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());

if ((num==6)||(num==7)){
    Console.WriteLine($"выходной");}
else if ((num>7)||(num<1)){
    Console.WriteLine("введите число от 1 до 7");}
else { 
    Console.WriteLine($"Не выходной");}
