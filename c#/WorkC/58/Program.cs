// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


int[,] GetMatrixArray(int m, int n, int minValue , int maxValue)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
     for (int j = 0; j < n; j++)
         {
             array[i, j] = new Random().Next(minValue, maxValue);
        }
     }
  
    return array;
}

void PrintToArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]}\t");
        }
        Console.WriteLine();
    }
}

int[,] multarray(int[,] matrA, int[,]matrB )
{
    int RowA = matrA.GetLength(0);
    int ColA = matrA.GetLength(1);
    int RowB = matrB.GetLength(0);
    int ColB = matrB.GetLength(1);

    int[,] multarray = new int[RowA,ColB];

    for (int i = 0; i < RowA;i++ )
    {
            for (int j = 0; j < ColB; j++)
            {  
                for (int k = 0; k < RowB; k++)
                {
                    multarray[i,j] += matrA[i, k] * matrB[k, j];
                
                }
            }
    }
    return multarray;
}

void Main()
{
    Console.Clear();
    Console.Write("Введите количество строк A: ");
    int rowA = int.Parse(Console.ReadLine()!);
    Console.Write("Введите количество столбцов A: ");
    int columnsA = int.Parse(Console.ReadLine()!);

    Console.Write("Введите количество строк B: ");
    int rowB = int.Parse(Console.ReadLine()!);
    Console.Write("Введите количество столбцов B: ");
    int columnsB = int.Parse(Console.ReadLine()!);
    
    if (columnsA != rowB)
    {
        Console.WriteLine("Произведение невозможно");
        return;
    }

    Console.WriteLine("\nМатрица A :\n");
    int[,] arrayToA = GetMatrixArray(rowA, columnsA, 1, 5);
    PrintToArray(arrayToA);
    Console.WriteLine("\nМатрица B :\n");
    int[,] arrayToB = GetMatrixArray(rowB, columnsB, 5, 9);
    PrintToArray(arrayToB);
    Console.WriteLine("\nРезультирующая матрица :\n");
    PrintToArray(multarray(arrayToA,arrayToB));
}
Main();

