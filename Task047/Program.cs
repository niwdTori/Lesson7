// Двумерный массив размером m×n.

double[,] GetArray(int m, int n)
{
    double[,] res = new double[m,n];
    for (int i=0; i < m; i++)
    {
        for (int j=0; j < n; j++)
    {
        res[i, j] = new Random().Next(-10, 10);
    }
    }
    return res;
}
void PrintArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите колличество строк: ");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите колличество столбцов: ");
int columns = int.Parse(Console.ReadLine());

double[,] array = GetArray(rows, columns);
PrintArray(array);