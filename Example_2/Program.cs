int rows = Convert.ToInt32(Console.ReadLine());
int columns = Convert.ToInt32(Console.ReadLine());
if (rows != columns)
{
    Console.WriteLine("Заменить элементы невозможно");
    return;
}
int[,] GetArray(int m, int n)
{
    int [,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(11);
        }
    }
    return matrix;
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int[,] ChangeArray(int[,] matrix)
{
    int [,] result = new int[matrix.GetLength(0), matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            result[j, i] = matrix[i, j];
        }
    }
    return result;
}

int [,] resultMatrix = GetArray(rows, columns);
PrintArray(resultMatrix);
Console.WriteLine("Результат: ");

PrintArray(ChangeArray(resultMatrix));



