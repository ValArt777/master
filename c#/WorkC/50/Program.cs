//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет
int[,] GetArray(int m, int n)
{
    int[,] newArray = new int[m, n];
    Random Randomizer = new Random();

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            newArray[i, j] = Randomizer.Next(1, 10);
        }
    }
    return newArray;
}

void Printarray(int[,] arrayForPrint, int iSearch = -1, int jSearch = -1, bool search = false)
{
    int row = arrayForPrint.GetLength(0);
    int column = arrayForPrint.GetLength(1);
    if (search)
    {
        System.Console.WriteLine($"Наш массив: ");
    }
    for (int y = 0; y < row; y++)
    {
        for (int x = 0; x < column; x++)
        {
            System.Console.Write(" {0,3:F0} ", arrayForPrint[y, x]);
        }
        System.Console.WriteLine();
    }

    if (search)
    {
        if (iSearch - 1 < row && iSearch - 1 < column && jSearch >= 0 && jSearch >= 0)
        {
            System.Console.WriteLine($"Значение в указанной ячейке ({iSearch},{jSearch}) равно {arrayForPrint[iSearch - 1, jSearch - 1]}");
        }
        else
        {
            System.Console.WriteLine($"Указанной ячейки ({iSearch},{jSearch}) не существует");
        }
    }
}

void Main()
{
    
    int rowCount = new Random().Next(5, 10);
    int columnCount = new Random().Next(5, 10);
    System.Console.WriteLine();
    int[,] intoArray = GetArray(rowCount, columnCount);
    Printarray(intoArray);
    System.Console.WriteLine();
    System.Console.Write($"Введите номер строки для поиска: "); int jRow = int.Parse(Console.ReadLine()!);
    System.Console.Write($"Введите номер столбца для поиска: "); int iRow = int.Parse(Console.ReadLine()!);
    Console.Clear();
    Printarray(intoArray, iRow, jRow, true);
}

Main();
