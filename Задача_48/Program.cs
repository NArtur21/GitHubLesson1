// 

Console.Clear();

int[,] GetArray(int row, int col)
{
    int[,] arroy = new int[row, col];
    for (int i = 0; i < row; i++);
    {
        for (int j = 0; j < col; j++)
        {
            array[i, j] = i + j;
        }
    }
    return array;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}\t ");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите размер строк: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите размер столбцов: ");
int col = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(row, col);
PrintArray(array);