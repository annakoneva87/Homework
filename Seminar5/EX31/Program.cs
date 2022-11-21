int [,] nums2 = { { 0, 1, 2 }, { 3, 4, 5 } };

int l = nums2.GetLength(0)-1;

int []temp = nums2[l];
int l2 = temp.GetLength(0);

for (int i = 0; i < l2-1; i++)
{
    System.Console.WriteLine($"{temp[i]}" );
}
