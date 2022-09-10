// Возвращает значение этого элемента или же указание, что такого элемента нет. (Если принимает на вход позицию эелента)

void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 10);
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

Console.WriteLine("Введите номер строки: ");
int row = int.Parse(Console.ReadLine());
Console.WriteLine("Введите номер столбца: ");
int column = int.Parse(Console.ReadLine());

int[,] array = new int[4, 3];
FillArray(array);
PrintArray(array);
Console.WriteLine();

int result = 0;
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (i == row - 1 && j == column - 1) result = array[i, j];
    }
}

if (result == 0) Console.WriteLine("Указанных позиций в массиве не существует");
else Console.WriteLine($"{result} -> число на указанных позициях");