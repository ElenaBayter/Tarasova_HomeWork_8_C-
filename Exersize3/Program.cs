//Задача 58: Задайте две матрицы. Напишите программу, 
//которая будет находить произведение двух матриц.

int[,] arrayA = GetArray(2, 2, 1, 6);
PrintArray(arrayA);
Console.WriteLine("");
int[,] arrayB = GetArray(2, 2, 1, 6);
PrintArray(arrayB);
Console.WriteLine("");
int[,] arrayC = MatrixMultiplication(arrayA, arrayB);
PrintArray(arrayC);

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
int [,] MatrixMultiplication(int [,] arrayA, int [,] arrayB)
{
    int[,] res = new int[arrayA.GetLength(0), arrayA.GetLength(1)];
    for (int i = 0; i < arrayA.GetLength(0); i++)
        {
            for (int j = 0; j < arrayB.GetLength(1); j++)
            {
                for (int k = 0; k < arrayB.GetLength(0); k++)
                {
                    res[i,j] += arrayA[i,k] * arrayB[k,j];
                }
            }
        }
    return res;
}