// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

int[,] array = GetArray(5, 4, 0, 9);
PrintArray(array);
Console.WriteLine("");

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue+1);
        }
    }
    return result;
}
void PrintArray(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}
int minsum = 0;
for (int i = 0; i < array.GetLength(1); i++)
{
    minsum+= array[0,i];
}
Console.WriteLine($"The row with min sum of elements is: {FindMinRowSum(array)}");

int FindMinRowSum(int[,] array)
{
    int row = 0;
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum+=array[i,j];
            if (sum<minsum)
            {
                minsum = sum;
                row = i;
            }
        }
        sum = 0;
    }
    return row;
}
