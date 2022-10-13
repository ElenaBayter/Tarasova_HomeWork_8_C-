// Отсортировать нечетные столбцы массива по возрастанию. 
// Вывести массив изначальный и массив с отсортированными нечетными столбцами

int[,] array = GetArray(4, 6, 0, 9);
PrintArray(array);
Console.WriteLine("");
int[,] SortedOddConumns = SortOddColumns(array);
PrintArray(SortedOddConumns);

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
int[,] SortOddColumns(int[,] array)
{
    int temp;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 1; j < array.GetLength(1); j+=2)
        {
            for (int k = i+1; k < array.GetLength(0); k++)
            {
                if (array[i,j] > array[k,j])
                {
                    temp = array[i,j];
                    array[i,j] = array[k,j];
                    array[k,j] = temp;
                }
            }
        }
    }
    return array;
}