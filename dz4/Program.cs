/*                                Задача HARD SORT Задайте двумерный массив из целых чисел. 
                                Количество строк и столбцов задается с клавиатуры. 
                                Отсортировать элементы по возрастанию слева направо и сверху вниз.

Например, задан массив:
1 4 7 2
5 9 10 3

После сортировки
1 2 3 4
5 7 9 10
*/

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

int[] ChangeArrayOneLine(int[,] array, int[] massiveOneLine)
{
    int indexOneLIne = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            massiveOneLine[indexOneLIne] = array[i, j];
            indexOneLIne++;
        }
    }
    return massiveOneLine;
}

void ArraySort(int[] massiveOneLine)
{
    int lenghtArray = massiveOneLine.Length;

    for (int i = 0; i < lenghtArray ; i++)
    {
        int min = i;
        for (int j = i+1; j < lenghtArray; j++)
        {
            if (massiveOneLine[min] > massiveOneLine[j])
            {
                min = j;
            }
        }
            int temp = massiveOneLine[i];
            massiveOneLine[i] = massiveOneLine[min];
            massiveOneLine[min] = temp;
    }
}

void PrintArrayOneLine(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int[,] ChangeArrayTwoLine(int[,] array, int[] massiveOneLine)
{
    int indexOneLIne = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = massiveOneLine[indexOneLIne];
            indexOneLIne++;
        }
    }
    return array;
}


Console.WriteLine("Введите колличество строк двумерного массива: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите колличество столбцов двумерного массива: ");
int n = int.Parse(Console.ReadLine());

int[,] mas = FillArray(m, n);

Console.WriteLine();
PrintArray(mas);
Console.WriteLine();
int[] massive = new int[n * m];

ChangeArrayOneLine(mas, massive);
PrintArrayOneLine(massive);
Console.WriteLine();

ArraySort(massive);
PrintArrayOneLine(massive);

Console.WriteLine();
PrintArray(ChangeArrayTwoLine(mas, massive));
