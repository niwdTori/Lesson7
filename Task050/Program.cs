// Возвращает значение этого элемента или же указание, что такого элемента нет. (Если принимает на вход значение эелента)

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

Console.WriteLine("Введите значение элемента: ");
int value = int.Parse(Console.ReadLine());

bool result = false;
for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(value == array[i,j]) result = true;
        }
    }

if(result == true)
{
    Console.WriteLine($"{value} -> такой элемент есть в массиве");
}
else
{
    Console.WriteLine($"{value} -> такого элемента нет в массиве");
}