int[,] FillArray(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(1, 100);
        }
    }
    return array;
}

void PrintArray(int[,] table)
{
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            Console.Write(table[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

bool FindNumber(int[,] array, int m, int n, int num)
{
    bool result = true;
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if (array[i, j] == num)
            {
                result = true;
                break;
            }
            else result = false;
        }
    }
    return result;
}

Console.WriteLine("Введите колличество строк двумерного массива: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите колличество столбцов двумерного массива: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число, которое нужно найти в массиве: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine();

int[,] mas = FillArray(m, n);

PrintArray(mas);
Console.WriteLine();

if (FindNumber(mas, m, n, num) == true) Console.WriteLine($"Число {num} есть в массиве");
else Console.WriteLine($"{FindNumber(mas, m, n, num)} Число {num} не найдено в массиве");