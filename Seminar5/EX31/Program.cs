//  Задача 55: Задайте двумерный массив.  
//  Напишите программу, которая заменяет строки на столбцы.  
//  В случае, если это невозможно, программа должна вывести  
//  сообщение для пользователя. 
 
int SetNumber(string str) 
{ 
    Console.WriteLine(str); 
    int num = int.Parse(Console.ReadLine()); 
    return num; 
} 
 
int[,] GetRandomMatrix(int rows, int columns, int maxVal = 100, int minVal = -100) 
{ 
int[,] matrix = new int[rows, columns]; 
var random = new Random(); 
for (int i = 0; i < rows; i++) 
{ 
    for (int j = 0; j < columns; j++) 
    { 
        matrix[i,j] = random.Next(minVal, maxVal+1); 
    } 
} 
return matrix; 
} 
 
 int[,] matrix = GetRandomMatrix(4,5, 10, 0); 
 
void PrintMatrix(int[,] matrix) 
{ 
    for (int i = 0; i < matrix.GetLength(0); i++) 
{ 
  for (int j = 0; j < matrix.GetLength(1); j++)   
  { 
    Console.Write(matrix[i,j] + " "); 
  } 
  Console.WriteLine();  
} 
} 
 
PrintMatrix(matrix); 
System.Console.WriteLine( ); 
 
 
static int[,] SwapRow(int[,] matrix) 
 
{   
      
     int[,] matrix2 = new int[matrix.GetLength(1), matrix.GetLength(0)];                                                    //int rows = matrix.GetLength(0) - 1; 
    for (int i = 0; i < matrix.GetLength(0); i++) 
    { 
        for (int j = 0; j < matrix.GetLength(1); j++)     // которая заменяет строки на столбцы. 
        { 
          matrix2[j,i] = matrix[i,j]; 
        } 
      
    } 
 return matrix2; 
} 
 
 
PrintMatrix(SwapRow(matrix));



System.Console.WriteLine("Введите число");
int num1 = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите знак");
char symbol = Console.ReadKey().KeyChar;
System.Console.WriteLine("Введите второе число");
double num2 = int.Parse(Console.ReadLine());
double result = 0;
while (symbol != 'q' || symbol !='Q')
{
    switch (symbol)
    {
        case '+':
        {
            result = num1 + num2;
            Console.WriteLine(result);
        }
        break;
        case '-':
        {
            result = num1 - num2;
            Console.WriteLine(result);
            
        }
        break;
        case '*':
        {
            result = num1 * num2;
            Console.WriteLine(result);
        }
        break;
        case '/':
        {
            result = num1 / num2;
            Console.WriteLine(result);

        }
        break;
        default:
        {
            break;
        }
    }
    //result = num1;
}
