// Напишите программу, которая задает массив из 8 элементов и выводит их на экран

System.Console.WriteLine("Введите параметры массива");
int begin = int.Parse(Console.ReadLine());
int last = int.Parse(Console.ReadLine());

int size =8;
 int[] arr = new int[size];

for (int i = 0; i < size; i++)
{
    arr[i] = new Random().Next(begin, last+1);
    Console.Write($"{arr[i]}, ");
}

