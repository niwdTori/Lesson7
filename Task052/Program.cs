// Cреднее арифметическое элементов в каждом столбце.

void FillArray(int[,] arr)
{
   for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1,10);
        }
    }    
}
void PrintArray(int[,] matr)
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
int[,] array = new int[3, 4];
FillArray(array);
PrintArray(array);

Console.WriteLine();

void ArithmeticMean(int[,] mas)
{
    for (int j = 0; j < mas.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < mas.GetLength(0); i++)
        {
            sum += mas[i,j];
        }
        sum = sum/mas.GetLength(0);
        Console.Write($"{Math.Round(sum, 1)} ");
    }

}
ArithmeticMean(array);