// Напишите программу, которая принимает на вход число и выдает сумму цифр в числе.
System.Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());

int sum = 0;
for (int i = 0; num >=1; i++)
{
    sum +=num % 10;
    num /= 10;
}
System.Console.WriteLine($"{sum}");